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
        //750, 435 Completo || Divisor 710, 2
        //470, 435 Reducido || Divisor 430, 2

        //Localizacion 455, 76
        //Tamaño 267, 312

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
        }
    }
}