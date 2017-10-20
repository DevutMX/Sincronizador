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
    public partial class Bienvenido : XtraForm
    {
        public Bienvenido()
        {
            InitializeComponent();
        }

        private void petSi_Click(object sender, EventArgs e)
        {
            Servidores _servidores = new Servidores();

            Hide();

            _servidores.Show();
        }

        private void petNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}