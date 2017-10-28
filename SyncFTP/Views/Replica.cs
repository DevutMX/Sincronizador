using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SyncFTP.Controllers;
using DevExpress.LookAndFeel;

namespace SyncFTP.Views
{
    public partial class Replica : XtraForm
    {
        public Replica()
        {
            InitializeComponent();

            ReadSettings();
        }

        public static bool Combinado = false;

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

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaConexion _ayudaConexion = new AyudaConexion();

            _ayudaConexion.ShowDialog();
        }

        private void petContinuar_Click(object sender, EventArgs e)
        {
            
        }

        private void petVerPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '\0';
            petVerPassword.Image = Properties.Resources.Bloquear;
        }

        private void petVerPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasena.Properties.PasswordChar = '•';
            petVerPassword.Image = Properties.Resources.Desbloquear;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                    if (_settings.Local.Server != null)
                    {
                        txtServidor.Text = _secret.Decrypt(_settings.Local.Server);
                        if (_secret.Decrypt(_settings.Local.IsAnonymous) == "True")
                        {
                            chkAnonimo.Checked = true;
                        }
                        txtUsuario.Text = _secret.Decrypt(_settings.Local.User);
                        txtContrasena.Text = _secret.Decrypt(_settings.Local.Password);
                        txtPuerto.Text = _secret.Decrypt(_settings.Local.Port);
                        txtDirectorio.Text = _secret.Decrypt(_settings.Local.Find);
                        cbxEncriptacion.SelectedIndex = Convert.ToInt32(_secret.Decrypt(_settings.Local.FTPMode));
                        if (_secret.Decrypt(_settings.Local.IsActive) == "True")
                        {
                            chkActivo.Checked = true;
                        }
                        if (_secret.Decrypt(_settings.Local.WithCert) == "True")
                        {
                            chkAutenticar.Checked = true;
                        }
                        if (_secret.Decrypt(_settings.Local.Combined) == "True")
                        {
                            Combinado = true;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void petProbar_Click(object sender, EventArgs e)
        {
            
        }

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
                    //lblLocalStatus.Text = "Conectando... espere por favor.";

                    string _ftpServer = "";

                    if (txtServidor.Text.Contains("localhost") || txtServidor.Text.Contains("127.0.0.1"))
                    {
                        _ftpServer = "localhost";
                    }

                    else
                    {
                        _ftpServer = txtServidor.Text.Contains("ftp.") ? txtServidor.Text : "ftp." + txtServidor.Text;
                    }

                    _server = new Servers { Remote = new Remote { Server = "", IsAnonymous = "", User = "", Password = "", Port = "", Find = "", FTPMode = "", IsActive = "", WithCert = "", Combined = _secret.Encrypt(Combinado.ToString()) }, Local = new Local { Server = _secret.Encrypt(_ftpServer), IsAnonymous = _secret.Encrypt(chkAnonimo.Checked.ToString()), User = _secret.Encrypt(txtUsuario.Text), Password = _secret.Encrypt(txtContrasena.Text), Port = _secret.Encrypt(txtPuerto.Text), Find = _secret.Encrypt(txtDirectorio.Text == "" ? "/" : txtDirectorio.Text), FTPMode = _secret.Encrypt(cbxEncriptacion.SelectedIndex.ToString()), IsActive = _secret.Encrypt(chkActivo.Checked.ToString()), WithCert = _secret.Encrypt(chkAutenticar.Checked.ToString()), Combined = _secret.Encrypt(Combinado.ToString()) } };

                    if (_kernel.LocalIsValid(_server) != null)
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

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}