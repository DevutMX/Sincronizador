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

namespace SyncFTP.Views
{
    public partial class ConfiguracionTerminada : XtraForm
    {
        public ConfiguracionTerminada(string remoto, string local)
        {
            InitializeComponent();

            ReadSettings();

            Definir(remoto, local);
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
        /// Objeto a nivel global que permite almacenar los ajustes del servidor remoto
        /// </summary>
        Servers _remoteServer;

        /// <summary>
        /// Objeto a nivel global que permite almacenar los ajustes del servidor local
        /// </summary>
        Servers _localServer;

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
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
                        _remoteServer = new Servers
                        {
                            Remote = new Remote
                            {
                                Server = _secret.Decrypt(_settings.Remote.Server),
                                User = _secret.Decrypt(_settings.Remote.User),
                                Find = _secret.Decrypt(_settings.Remote.Find)
                            }
                        };
                    }

                    if (_settings.Local.Server != null)
                    {
                        _localServer = new Servers
                        {
                            Local = new Local
                            {
                                Server = _secret.Decrypt(_settings.Local.Server),
                                User = _secret.Decrypt(_settings.Local.User),
                                Find = _secret.Decrypt(_settings.Local.Find)
                            }
                        };
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Definir(string remote, string local)
        {
            if (!string.IsNullOrWhiteSpace(remote) && !string.IsNullOrWhiteSpace(local))
            {
                lblMensaje.Text = string.Format("La configuración del servidor ha terminado, este servidor se ha configurado con el servidor central: <b>{0}</b>, con el nombre de usuario: <b>{1}</b> en el directorio <b>{2}</b>.\n\nTambién se configuró el servidor replica: <b>{3}</b>, con el nombre de usuario: <b>{4}</b> en el directorio <b>{5}</b>.", _remoteServer.Remote.Server, _remoteServer.Remote.User, _remoteServer.Remote.Find, _localServer.Local.Server, _localServer.Local.User, _localServer.Local.Find);
            }

            else
            {
                if (!string.IsNullOrWhiteSpace(remote) && string.IsNullOrWhiteSpace(local))
                {
                    lblMensaje.Text = string.Format("La configuración del servidor ha terminado, este servidor se ha configurado con el servidor central: <b>{0}</b>, con el nombre de usuario: <b>{1}</b> en el directorio <b>{2}</b>.", _remoteServer.Remote.Server, _remoteServer.Remote.User, _remoteServer.Remote.Find);
                }

                else
                {
                    lblMensaje.Text = string.Format("La configuración del servidor ha terminado, este servidor se ha configurado con el servidor replica: <b>{0}</b>, con el nombre de usuario: <b>{1}</b> en el directorio <b>{2}</b>.", _localServer.Local.Server, _localServer.Local.User, _localServer.Local.Find);
                }
            }
        }
    }
}