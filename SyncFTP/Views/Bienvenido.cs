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

        /// <summary>
        /// Objeto a nivel global que permite interactuar con los metodos de cifrado
        /// </summary>
        Secret _secret = new Secret();

        /// <summary>
        /// Evento que se ejecuta cuando se hace click en la opcion "Si"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petSi_Click(object sender, EventArgs e)
        {
            //Se instancia el formulario Servidores
            Servidores _servidores = new Servidores();
       
            //Se oculta este formulario
            Hide();

            //Se muestra el formulario servidores
            _servidores.ShowDialog();
        }

        /// <summary>
        /// Si se selecciona la opcion "No", se cierra el programa totalmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petNo_Click(object sender, EventArgs e)
        {
            //Cierra completamente el programa
            Application.Exit();
        }

        /// <summary>
        /// Evalua si es la primera vez que se ejecuta el asistente de configuracion, para definir si continua o procede al formulario principal
        /// </summary>
        private void PromptSettings()
        {
            try
            {
                Servers _settings = _kernel.ReadSettings();

                if (_settings != null)
                {
                    Servidores _servidores = new Servidores();

                    if (_settings.Remote.Server == "" && _secret.Decrypt(_settings.Remote.Combined) == "True")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"central\"...\n¿Desea ir a la pantalla de configuración?", "SyncFTP - Servidor central desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Hide();

                            _servidores.ShowDialog();
                        }

                        else
                        {
                            Principal _principal = Principal.ObtenerInstancia();

                            Hide();

                            _principal.Show();
                        }
                    }

                    if (_settings.Local.Server == "" && _secret.Decrypt(_settings.Local.Combined) == "True")
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Parece que no configuró el servidor \"replica\"...\n¿Desea ir a la pantalla de configuración?", "SyncFTP - Servidor replica desconocido", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Hide();

                            _servidores.ShowDialog();
                        }

                        else
                        {
                            Principal _principal = Principal.ObtenerInstancia();

                            Hide();

                            _principal.Show();
                        }
                    }

                    if (_settings.Remote.Server != "" || _settings.Local.Server != "")
                    {
                        Principal _principal = Principal.ObtenerInstancia();

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

        /// <summary>
        /// Detecta la situacion de SyncFTP, al cargar por primera vez la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bienvenido_Shown(object sender, EventArgs e)
        {
            Hide();

            PromptSettings();
        }

        /// <summary>
        /// Continua con la configuracion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petSi_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Cancela la configuracion y cierra por completo SyncFTP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void petSi_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}