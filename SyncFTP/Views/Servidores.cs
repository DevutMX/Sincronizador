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

namespace SyncFTP.Views
{
    public partial class Servidores : XtraForm
    {
        public Servidores()
        {
            InitializeComponent();
        }
        
        private void Servidores_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Evento que evalua el tipo de seleccion de servidor, para que muestre los formularios de configuracion pertinentes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!chkCentral.Checked && !chkReplica.Checked)
                {
                    XtraMessageBox.Show(UserLookAndFeel.Default, "Por favor, selecciona al menos un servidor a configurar", "Error de selección", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    chkCentral.Focus();
                }

                else
                {
                    if (chkCentral.Checked && !chkReplica.Checked)
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "El servidor central requiere de conexión internet\n\n¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            Hide();

                            Central _central = new Central();

                            if (_central.ShowDialog() == DialogResult.OK)
                            {
                                ConfiguracionTerminada _configTerm = new ConfiguracionTerminada("central", null);

                                _configTerm.ShowDialog();

                                Principal _principal = Principal.ObtenerInstancia();

                                _principal.Show();
                            }

                            else
                            {
                                Show();
                            }
                        }
                    }

                    else if (!chkCentral.Checked && chkReplica.Checked)
                    {
                        Hide();

                        Replica _replica = new Replica();

                        if (_replica.ShowDialog() == DialogResult.OK)
                        {
                            ConfiguracionTerminada _configTerm = new ConfiguracionTerminada(null, "replica");

                            _configTerm.ShowDialog();

                            Principal _principal = Principal.ObtenerInstancia();

                            _principal.Show();
                        }

                        else
                        {
                            Show();
                        }
                    }

                    else
                    {
                        if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Primero configuraremos el servidor central, para ello necesitas tener conexión a internet\n\n¿Desea continuar?", "¡Vamos por pasos!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            Hide();

                            Central _central = new Central();

                            Replica _replica = new Replica();

                            Central._combinado = true;

                            Replica.Combinado = true;

                            if (_central.ShowDialog() == DialogResult.OK)
                            {
                                if (_replica.ShowDialog() == DialogResult.OK)
                                {
                                    ConfiguracionTerminada _configTerm = new ConfiguracionTerminada("central", "replica");

                                    _configTerm.ShowDialog();

                                    Principal _principal = Principal.ObtenerInstancia();

                                    _principal.Show();
                                }
                            }

                            else
                            {
                                if (DialogResult.Yes == XtraMessageBox.Show(UserLookAndFeel.Default, "Al parecer no se configuro el servidor central.\n\n¿Deseas configurar el servidor replica?", "Continuar configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                                {
                                    if (_replica.ShowDialog() == DialogResult.OK)
                                    {
                                        ConfiguracionTerminada _configTerm = new ConfiguracionTerminada(null, "replica");

                                        _configTerm.ShowDialog();

                                        Principal _principal = Principal.ObtenerInstancia();

                                        _principal.Show();
                                    }

                                    else
                                    {
                                        Show();
                                    }
                                }

                                else
                                {
                                    Show();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaServidores _ayudaServidores = new AyudaServidores();

            Hide();

            _ayudaServidores.ShowDialog();

            Show();
        }
    }
}