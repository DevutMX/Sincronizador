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

        private bool expandido = false;

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

        private void btnServidorFTP_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Servidor");
        }
        
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Usuario");
        }

        private void btnPuerto_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Puerto");
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Directorio");
        }

        private void btnEncriptacion_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Encriptacion");
        }

        private void btnModo_Click(object sender, EventArgs e)
        {
            tmpEfecto.Enabled = true;

            Mostrar("Activo");
        }

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