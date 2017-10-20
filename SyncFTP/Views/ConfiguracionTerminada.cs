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
    public partial class ConfiguracionTerminada : XtraForm
    {
        public ConfiguracionTerminada()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}