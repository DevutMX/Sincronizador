using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using SyncFTP.Controllers;
using System;
using System.Windows.Forms;

namespace SyncFTP.Views
{
    public partial class Central : XtraForm
    {
        public Central()
        {
            InitializeComponent();

            ReadSettings();
        }

        public static bool _combinado = false;

        /// <summary>
        /// Objeto a nivel global que permite interactuar con el nucleo para hacer lectura y validaciones de los ajustes de los servidores
        /// </summary>
        Kernel _kernel = new Kernel();

        /// <summary>
        /// Objeto a nivel global que permite interactuar con los metodos de cifrado
        /// </summary>
        Secret _secret = new Secret();

        /// <summary>
        /// Objeto a nivel global que permite almacenar los ajustes de ambos servidores
        /// </summary>
        Servers _server = new Servers();

        /// <summary>
        /// Muetra la ventana de ayuda para la correcta configuracion del servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaConexion _ayudaConexion = new AyudaConexion();

            _ayudaConexion.ShowDialog();
        }

        /// <summary>
        /// Se autoriza el poder ver sin cifrar, la contraseña del servidor FTP, cuando el boton del mouse este presionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '\0';
            petVerPassword.Image = Properties.Resources.Bloquear;
        }

        /// <summary>
        /// Al dejar de presionar el boton del mouse, se vuelve a cifrar la contraseña para no ser observable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '•';
            petVerPassword.Image = Properties.Resources.Desbloquear;
        }

        /// <summary>
        /// Cierra la ventana, pero no el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        /// <summary>
        /// Detecta los cambios en cualquiera de los campos, para pedir de nuevo la autenticación de los mismos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            btnContinuar.Visible = false;
        }

        /// <summary>
        /// Verifica la existencia de los ajustes del servidor local y remoto
        /// </summary>
        private void ReadSettings()
        {
            try
            {
                Servers _settings = _kernel.ReadSettings();

                if (_settings != null)
                {
                    if (_settings.Remote.Server != null)
                    {
                        txtServidor.Text = _secret.Decrypt(_settings.Remote.Server);
                        if (_secret.Decrypt(_settings.Remote.IsAnonymous) == "True")
                        {
                            chkAnonimo.Checked = true;
                        }
                        txtUsuario.Text = _secret.Decrypt(_settings.Remote.User);
                        txtContrasena.Text = _secret.Decrypt(_settings.Remote.Password);
                        txtPuerto.Text = _secret.Decrypt(_settings.Remote.Port);
                        txtDirectorio.Text = _secret.Decrypt(_settings.Remote.Find);
                        cbxEncriptacion.SelectedIndex = Convert.ToInt32(_secret.Decrypt(_settings.Remote.FTPMode));
                        if (_secret.Decrypt(_settings.Remote.IsActive) == "True")
                        {
                            chkActivo.Checked = true;
                        }
                        if (_secret.Decrypt(_settings.Remote.WithCert) == "True")
                        {
                            chkAutenticar.Checked = true;
                        }
                        if (_secret.Decrypt(_settings.Remote.Combined) == "True")
                        {
                            _combinado = true;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Determina si se activo la casilla de anónimo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAnonimo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnonimo.Checked)
            {
                txtUsuario.Text = "anonymous";
                txtUsuario.ReadOnly = true;
                txtContrasena.Text = "anonymous@example.com";
                txtContrasena.ReadOnly = true;
            }

            else
            {
                txtUsuario.Text = "";
                txtUsuario.ReadOnly = false;
                txtContrasena.Text = "";
                txtContrasena.ReadOnly = false;
            }

            btnContinuar.Visible = false;
        }

        /// <summary>
        /// Evento que establece conexion con el servidor que se desea configurar, si las configuraciones permiten establecer conexión estas se almacenarán.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProbar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtServidor.Text == "" || txtUsuario.Text == "" || txtContrasena.Text == "" || txtPuerto.Text == "" || Convert.ToInt32(txtPuerto.Text) < 0 || cbxEncriptacion.SelectedIndex < 0)
                {
                    XtraMessageBox.Show(UserLookAndFeel.Default, "Son necesarios todos los datos para poder probar la conexión", "SyncFTP - Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtServidor.Focus();
                }

                else
                {
                    string _ftpServer = "";

                    if (txtServidor.Text.Contains("localhost") || txtServidor.Text.Contains("127.0.0.1"))
                    {
                        _ftpServer = "localhost";
                    }

                    else
                    {
                        _ftpServer = txtServidor.Text.Contains("ftp.") ? txtServidor.Text : "ftp." + txtServidor.Text;
                    }

                    _server = new Servers { Remote = new Remote { Server = _secret.Encrypt(_ftpServer), IsAnonymous = _secret.Encrypt(chkAnonimo.Checked.ToString()), User = _secret.Encrypt(txtUsuario.Text), Password = _secret.Encrypt(txtContrasena.Text), Port = _secret.Encrypt(txtPuerto.Text), Find = _secret.Encrypt(txtDirectorio.Text == "" ? "/" : txtDirectorio.Text), FTPMode = _secret.Encrypt(cbxEncriptacion.SelectedIndex.ToString()), IsActive = _secret.Encrypt(chkActivo.Checked.ToString()), WithCert = _secret.Encrypt(chkAutenticar.Checked.ToString()), Combined = _secret.Encrypt(_combinado.ToString()) }, Local = new Local { Server = "", IsAnonymous = "", User = "", Password = "", Port = "", Find = "", FTPMode = "", IsActive = "", WithCert = "", Combined = _secret.Encrypt(_combinado.ToString()) } };

                    if (_kernel.RemoteIsValid(_server) != null)
                    {
                        if (_kernel.TestAndSaveSettings(_server.Local, _server.Remote))
                        {
                            XtraMessageBox.Show(UserLookAndFeel.Default, "Los datos proporcionados son correctos y se ha conectado al servidor correctamente.", "Conexión establecida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            btnContinuar.Visible = true;

                            txtServidor.Focus();
                        }
                    }

                    else
                    {
                        XtraMessageBox.Show(UserLookAndFeel.Default, "Los datos proporcionados son incorrectos o estan incompletos\nverifique por favor los datos.", "Datos incorrectos o incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        btnContinuar.Visible = false;

                        txtServidor.Focus();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        /// <summary>
        /// Al ser correctas las configuraciones, este procede con la siguiente acción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}