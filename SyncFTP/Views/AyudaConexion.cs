using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SyncFTP.Views
{
    public partial class AyudaConexion : XtraForm
    {
        public AyudaConexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Indica si el panel de ayuda esta desplegado
        /// </summary>
        private bool expandido = false;

        /// <summary>
        /// Temporizador que determina el efecto de expansion y colapso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmpEfecto_Tick(object sender, EventArgs e)
        {
            if (expandido)
            {
                if (Size.Width > 470)
                {
                    Size = new Size(Size.Width - 40, 435);
                    petDivisor.Width -= 40;
                }

                else
                {
                    expandido = false;
                    tmpEfecto.Enabled = false;
                }
            }
            else
            {
                if (Size.Width < 750)
                {
                    Size = new Size(Size.Width + 40, 435);
                    petDivisor.Width += 40;
                }

                else
                {
                    expandido = true;
                    tmpEfecto.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente al servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServidorFTP_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Servidor");
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Usuario");
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente al puerto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPuerto_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Puerto");
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente al directorio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Directorio");
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente a la encriptacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncriptacion_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Encriptacion");
        }

        /// <summary>
        /// Evento que muestra la ayuda correspondiente al modo activo/pasivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModo_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Activo");
        }

        /// <summary>
        /// Determina que panel de ayuda mostrar
        /// </summary>
        /// <param name="grupo"></param>
        private void Mostrar(string grupo)
        {
            foreach (Control gbc in Controls)
            {
                if (gbc is GroupControl)
                {
                    ((GroupControl)gbc).Visible = false;
                }
            }

            if (grupo == "Servidor")
            {
                gbcServidor.Visible = true;
            }

            if (grupo == "Usuario")
            {
                gbcUsuario.Visible = true;
            }

            if (grupo == "Puerto")
            {
                gbcPuerto.Visible = true;
            }

            if (grupo == "Directorio")
            {
                gbcDirectorio.Visible = true;
            }

            if (grupo == "Encriptacion")
            {
                gbcEncriptacion.Visible = true;
            }

            if (grupo == "Activo")
            {
                gbcActivo.Visible = true;
            }
        }
    }
}