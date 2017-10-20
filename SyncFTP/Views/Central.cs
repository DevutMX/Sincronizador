﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using SyncFTP.Controllers;

namespace SyncFTP.Views
{
    public partial class Central : XtraForm
    {
        public Central()
        {
            InitializeComponent();

            ReadSettings();
        }

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
            DialogResult = DialogResult.OK;

            Close();
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
            petContinuar.Visible = false;
            lblContinuar.Visible = false;
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
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void petProbar_Click(object sender, EventArgs e)
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

                _server = new Servers { Remote = new Remote { Server = _secret.Encrypt(_ftpServer), IsAnonymous = _secret.Encrypt(chkAnonimo.Checked.ToString()), User = _secret.Encrypt(txtUsuario.Text), Password = _secret.Encrypt(txtContrasena.Text), Port = _secret.Encrypt(txtPuerto.Text), Find = _secret.Encrypt(txtDirectorio.Text == "" ? "/" : txtDirectorio.Text), FTPMode = _secret.Encrypt(cbxEncriptacion.SelectedIndex.ToString()), IsActive = _secret.Encrypt(chkActivo.Checked.ToString()), WithCert = _secret.Encrypt(chkAutenticar.Checked.ToString()) }, Local = new Local { Server = "", IsAnonymous = "", User = "", Password = "", Port = "", Find = "", FTPMode = "", IsActive = "", WithCert = "" } };

                if (_kernel.RemoteIsValid(_server) != null)
                {
                    if (_kernel.TestAndSaveSettings(_server.Local, _server.Remote))
                    {
                        XtraMessageBox.Show(UserLookAndFeel.Default, "Los datos proporcionados son correctos y se ha conectado al servidor correctamente.", "Conexión establecida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        petContinuar.Visible = true;
                        lblContinuar.Visible = true;

                        txtServidor.Focus();
                    }
                }

                else
                {
                    XtraMessageBox.Show(UserLookAndFeel.Default, "Los datos proporcionados son incorrectos o estan incompletos\nverifique por favor los datos.", "Datos incorrectos o incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    petContinuar.Visible = false;
                    lblContinuar.Visible = false;

                    txtServidor.Focus();
                }
            }
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

            petContinuar.Visible = false;
            lblContinuar.Visible = false;
        }
    }
}