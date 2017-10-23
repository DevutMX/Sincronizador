using System;
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
    public partial class Bienvenido : XtraForm
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Objeto a nivel global que permite interactuar con el nucleo para hacer lectura y validaciones de los ajustes de los servidores
        /// </summary>
        Kernel _kernel = new Kernel();

        private void petSi_Click(object sender, EventArgs e)
        {
            Servidores _servidores = new Servidores();

            Hide();

            _servidores.ShowDialog();
        }

        private void petNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PromptSettings()
        {
            try
            {
                Servers _settings = _kernel.ReadSettings();

                if (_settings != null)
                {
                    Servidores _servidores = new Servidores();

                    if (_settings.Remote.Server == "")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"central\"...\n¿Desea ir a la pantalla de configuración?", "SyncFTP - Servidor central desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Hide();

                            _servidores.ShowDialog();
                        }

                        else
                        {
                            Principal _principal = new Principal();

                            Hide();

                            _principal.Show();
                        }
                    }

                    if (_settings.Local.Server == "")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"replica\"...\n¿Desea ir a la pantalla de configuración?", "SyncFTP - Servidor replica desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Hide();

                            _servidores.ShowDialog();
                        }

                        else
                        {
                            Principal _principal = new Principal();

                            Hide();

                            _principal.Show();
                        }
                    }

                    if (_settings.Remote.Server != "" && _settings.Local.Server != "")
                    {
                        Principal _principal = new Principal();

                        Hide();

                        _principal.Show();
                    }
                }

                else
                {
                    Show();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Bienvenido_Shown(object sender, EventArgs e)
        {
            Hide();

            PromptSettings();
        }
    }
}