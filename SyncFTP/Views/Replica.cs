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
    public partial class Replica : XtraForm
    {
        public Replica()
        {
            InitializeComponent();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaConexion _ayudaConexion = new AyudaConexion();

            _ayudaConexion.ShowDialog();
        }
    }
}