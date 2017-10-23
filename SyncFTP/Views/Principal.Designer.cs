namespace SyncFTP.Views
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlOptions = new DevExpress.XtraEditors.PanelControl();
            this.lblElapsedTime = new DevExpress.XtraEditors.LabelControl();
            this.btnAvanzados = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDispositivos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblAvance = new DevExpress.XtraEditors.LabelControl();
            this.pbcProgress = new DevExpress.XtraEditors.ProgressBarControl();
            this.pnlLabels = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlTabs = new DevExpress.XtraEditors.PanelControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gdcCentral = new DevExpress.XtraGrid.GridControl();
            this.gdvCentral = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gdcReplica = new DevExpress.XtraGrid.GridControl();
            this.gdvReplica = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gbcSincronizar = new DevExpress.XtraEditors.GroupControl();
            this.btnIniciarReplica = new DevExpress.XtraEditors.SimpleButton();
            this.btnIniciarCentral = new DevExpress.XtraEditors.SimpleButton();
            this.dlafSkins = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.fbdFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.nicSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmpMenuSysTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.remotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartRemoteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPauseRemoteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopRemoteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemoteTreeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.descargasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartLocalStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPauseLocalStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStopLocalStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLocalTreeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitSysTray = new System.Windows.Forms.ToolStripMenuItem();
            this.nicToMinimized = new System.Windows.Forms.NotifyIcon(this.components);
            this._tmpElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.lblNotifications = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOptions)).BeginInit();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDispositivos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLabels)).BeginInit();
            this.pnlLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabs)).BeginInit();
            this.pnlTabs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcCentral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCentral)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcReplica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReplica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcSincronizar)).BeginInit();
            this.gbcSincronizar.SuspendLayout();
            this.cmpMenuSysTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(75, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(215, 23);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Historial de sincronización";
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.lblNotifications);
            this.pnlOptions.Controls.Add(this.lblElapsedTime);
            this.pnlOptions.Controls.Add(this.btnAvanzados);
            this.pnlOptions.Controls.Add(this.btnConfirmar);
            this.pnlOptions.Controls.Add(this.labelControl4);
            this.pnlOptions.Controls.Add(this.cbxDispositivos);
            this.pnlOptions.Controls.Add(this.lblAvance);
            this.pnlOptions.Controls.Add(this.pbcProgress);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOptions.Location = new System.Drawing.Point(0, 376);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(484, 157);
            this.pnlOptions.TabIndex = 12;
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblElapsedTime.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblElapsedTime.Appearance.Options.UseFont = true;
            this.lblElapsedTime.Appearance.Options.UseForeColor = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(245, 78);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(0, 16);
            this.lblElapsedTime.TabIndex = 18;
            // 
            // btnAvanzados
            // 
            this.btnAvanzados.ImageOptions.Image = global::SyncFTP.Properties.Resources.Avanzados;
            this.btnAvanzados.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAvanzados.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btnAvanzados.Location = new System.Drawing.Point(407, 9);
            this.btnAvanzados.Name = "btnAvanzados";
            this.btnAvanzados.Size = new System.Drawing.Size(65, 73);
            this.btnAvanzados.TabIndex = 17;
            this.btnAvanzados.Text = "Avanzados";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(245, 31);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 23);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(178, 16);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Elija medio extraíble o local:";
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.Location = new System.Drawing.Point(12, 31);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbxDispositivos.Properties.Appearance.Options.UseFont = true;
            this.cbxDispositivos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDispositivos.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxDispositivos.Size = new System.Drawing.Size(227, 22);
            this.cbxDispositivos.TabIndex = 14;
            // 
            // lblAvance
            // 
            this.lblAvance.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvance.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblAvance.Appearance.Options.UseFont = true;
            this.lblAvance.Appearance.Options.UseForeColor = true;
            this.lblAvance.Location = new System.Drawing.Point(12, 78);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(163, 16);
            this.lblAvance.TabIndex = 13;
            this.lblAvance.Text = "0% de 100% completado";
            // 
            // pbcProgress
            // 
            this.pbcProgress.Location = new System.Drawing.Point(12, 100);
            this.pbcProgress.Name = "pbcProgress";
            this.pbcProgress.Size = new System.Drawing.Size(460, 31);
            this.pbcProgress.TabIndex = 0;
            // 
            // pnlLabels
            // 
            this.pnlLabels.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.pnlLabels.Controls.Add(this.labelControl2);
            this.pnlLabels.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLabels.Location = new System.Drawing.Point(0, 346);
            this.pnlLabels.Name = "pnlLabels";
            this.pnlLabels.Size = new System.Drawing.Size(484, 30);
            this.pnlLabels.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(227, 16);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Sincronización con unidad extraíble";
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.tabControl1);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTabs.Location = new System.Drawing.Point(0, 78);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(484, 268);
            this.pnlTabs.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gdcCentral);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Central";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gdcCentral
            // 
            this.gdcCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcCentral.Location = new System.Drawing.Point(3, 3);
            this.gdcCentral.MainView = this.gdvCentral;
            this.gdcCentral.Name = "gdcCentral";
            this.gdcCentral.Size = new System.Drawing.Size(466, 232);
            this.gdcCentral.TabIndex = 0;
            this.gdcCentral.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvCentral});
            // 
            // gdvCentral
            // 
            this.gdvCentral.GridControl = this.gdcCentral;
            this.gdvCentral.Name = "gdvCentral";
            this.gdvCentral.OptionsBehavior.Editable = false;
            this.gdvCentral.OptionsView.ShowGroupPanel = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gdcReplica);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Replica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gdcReplica
            // 
            this.gdcReplica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcReplica.Location = new System.Drawing.Point(3, 3);
            this.gdcReplica.MainView = this.gdvReplica;
            this.gdcReplica.Name = "gdcReplica";
            this.gdcReplica.Size = new System.Drawing.Size(466, 232);
            this.gdcReplica.TabIndex = 1;
            this.gdcReplica.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvReplica});
            // 
            // gdvReplica
            // 
            this.gdvReplica.GridControl = this.gdcReplica;
            this.gdvReplica.Name = "gdvReplica";
            this.gdvReplica.OptionsBehavior.Editable = false;
            this.gdvReplica.OptionsView.ShowGroupPanel = false;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::SyncFTP.Properties.Resources.Historial;
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit2.TabIndex = 10;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::SyncFTP.Properties.Resources.LineaDelgada;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 68);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(460, 2);
            this.pictureEdit1.TabIndex = 9;
            // 
            // gbcSincronizar
            // 
            this.gbcSincronizar.AppearanceCaption.Options.UseTextOptions = true;
            this.gbcSincronizar.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gbcSincronizar.Controls.Add(this.btnIniciarReplica);
            this.gbcSincronizar.Controls.Add(this.btnIniciarCentral);
            this.gbcSincronizar.Location = new System.Drawing.Point(310, 9);
            this.gbcSincronizar.Name = "gbcSincronizar";
            this.gbcSincronizar.Size = new System.Drawing.Size(162, 53);
            this.gbcSincronizar.TabIndex = 15;
            this.gbcSincronizar.Text = "Sincronizar";
            // 
            // btnIniciarReplica
            // 
            this.btnIniciarReplica.Location = new System.Drawing.Point(84, 23);
            this.btnIniciarReplica.Name = "btnIniciarReplica";
            this.btnIniciarReplica.Size = new System.Drawing.Size(64, 23);
            this.btnIniciarReplica.TabIndex = 18;
            this.btnIniciarReplica.Text = "Replica";
            this.btnIniciarReplica.Click += new System.EventHandler(this.btnIniciarReplica_Click);
            // 
            // btnIniciarCentral
            // 
            this.btnIniciarCentral.Location = new System.Drawing.Point(14, 23);
            this.btnIniciarCentral.Name = "btnIniciarCentral";
            this.btnIniciarCentral.Size = new System.Drawing.Size(64, 23);
            this.btnIniciarCentral.TabIndex = 17;
            this.btnIniciarCentral.Text = "Central";
            this.btnIniciarCentral.Click += new System.EventHandler(this.btnIniciarCentral_Click);
            // 
            // dlafSkins
            // 
            this.dlafSkins.LookAndFeel.SkinName = "Foggy";
            // 
            // fbdFolderSelect
            // 
            this.fbdFolderSelect.Description = "Ubicación para almacenar archivos...";
            this.fbdFolderSelect.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // nicSystemTray
            // 
            this.nicSystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicSystemTray.BalloonTipText = "Trabajando en segundo plano...";
            this.nicSystemTray.ContextMenuStrip = this.cmpMenuSysTray;
            this.nicSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("nicSystemTray.Icon")));
            this.nicSystemTray.Text = "SyncFTP";
            this.nicSystemTray.Visible = true;
            this.nicSystemTray.DoubleClick += new System.EventHandler(this.nicSystemTray_DoubleClick);
            // 
            // cmpMenuSysTray
            // 
            this.cmpMenuSysTray.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmpMenuSysTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remotoToolStripMenuItem,
            this.descargasToolStripMenuItem,
            this.btnExitSysTray});
            this.cmpMenuSysTray.Name = "cmpMenuSysTray";
            this.cmpMenuSysTray.Size = new System.Drawing.Size(171, 94);
            // 
            // remotoToolStripMenuItem
            // 
            this.remotoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartRemoteStrip,
            this.btnPauseRemoteStrip,
            this.btnStopRemoteStrip,
            this.btnRemoteTreeStrip});
            this.remotoToolStripMenuItem.Image = global::SyncFTP.Properties.Resources.Remote16;
            this.remotoToolStripMenuItem.Name = "remotoToolStripMenuItem";
            this.remotoToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.remotoToolStripMenuItem.Text = "Servidor Remoto";
            // 
            // btnStartRemoteStrip
            // 
            this.btnStartRemoteStrip.Image = global::SyncFTP.Properties.Resources.Play16;
            this.btnStartRemoteStrip.Name = "btnStartRemoteStrip";
            this.btnStartRemoteStrip.Size = new System.Drawing.Size(179, 30);
            this.btnStartRemoteStrip.Text = "Iniciar";
            this.btnStartRemoteStrip.Click += new System.EventHandler(this.btnStartRemote_Click);
            // 
            // btnPauseRemoteStrip
            // 
            this.btnPauseRemoteStrip.Image = global::SyncFTP.Properties.Resources.Pause16;
            this.btnPauseRemoteStrip.Name = "btnPauseRemoteStrip";
            this.btnPauseRemoteStrip.Size = new System.Drawing.Size(179, 30);
            this.btnPauseRemoteStrip.Text = "Pausar";
            this.btnPauseRemoteStrip.Visible = false;
            // 
            // btnStopRemoteStrip
            // 
            this.btnStopRemoteStrip.Image = global::SyncFTP.Properties.Resources.Stop16;
            this.btnStopRemoteStrip.Name = "btnStopRemoteStrip";
            this.btnStopRemoteStrip.Size = new System.Drawing.Size(179, 30);
            this.btnStopRemoteStrip.Text = "Detener";
            this.btnStopRemoteStrip.Visible = false;
            // 
            // btnRemoteTreeStrip
            // 
            this.btnRemoteTreeStrip.Image = global::SyncFTP.Properties.Resources.Tree16;
            this.btnRemoteTreeStrip.Name = "btnRemoteTreeStrip";
            this.btnRemoteTreeStrip.Size = new System.Drawing.Size(179, 30);
            this.btnRemoteTreeStrip.Text = "Obtener directorio";
            this.btnRemoteTreeStrip.Click += new System.EventHandler(this.btnRemoteTreeStrip_Click);
            // 
            // descargasToolStripMenuItem
            // 
            this.descargasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartLocalStrip,
            this.btnPauseLocalStrip,
            this.btnStopLocalStrip,
            this.btnLocalTreeStrip});
            this.descargasToolStripMenuItem.Image = global::SyncFTP.Properties.Resources.Local16;
            this.descargasToolStripMenuItem.Name = "descargasToolStripMenuItem";
            this.descargasToolStripMenuItem.Size = new System.Drawing.Size(170, 30);
            this.descargasToolStripMenuItem.Text = "Servidor Local";
            // 
            // btnStartLocalStrip
            // 
            this.btnStartLocalStrip.Image = global::SyncFTP.Properties.Resources.Play16;
            this.btnStartLocalStrip.Name = "btnStartLocalStrip";
            this.btnStartLocalStrip.Size = new System.Drawing.Size(179, 30);
            this.btnStartLocalStrip.Text = "Iniciar";
            this.btnStartLocalStrip.Click += new System.EventHandler(this.btnStartLocal_Click);
            // 
            // btnPauseLocalStrip
            // 
            this.btnPauseLocalStrip.Image = global::SyncFTP.Properties.Resources.Pause16;
            this.btnPauseLocalStrip.Name = "btnPauseLocalStrip";
            this.btnPauseLocalStrip.Size = new System.Drawing.Size(179, 30);
            this.btnPauseLocalStrip.Text = "Pausar";
            this.btnPauseLocalStrip.Visible = false;
            // 
            // btnStopLocalStrip
            // 
            this.btnStopLocalStrip.Image = global::SyncFTP.Properties.Resources.Stop16;
            this.btnStopLocalStrip.Name = "btnStopLocalStrip";
            this.btnStopLocalStrip.Size = new System.Drawing.Size(179, 30);
            this.btnStopLocalStrip.Text = "Detener";
            this.btnStopLocalStrip.Visible = false;
            // 
            // btnLocalTreeStrip
            // 
            this.btnLocalTreeStrip.Image = global::SyncFTP.Properties.Resources.Tree16;
            this.btnLocalTreeStrip.Name = "btnLocalTreeStrip";
            this.btnLocalTreeStrip.Size = new System.Drawing.Size(179, 30);
            this.btnLocalTreeStrip.Text = "Obtener directorio";
            this.btnLocalTreeStrip.Click += new System.EventHandler(this.btnLocalTreeStrip_Click);
            // 
            // btnExitSysTray
            // 
            this.btnExitSysTray.Image = global::SyncFTP.Properties.Resources.Exit16;
            this.btnExitSysTray.Name = "btnExitSysTray";
            this.btnExitSysTray.Size = new System.Drawing.Size(170, 30);
            this.btnExitSysTray.Text = "Salir";
            this.btnExitSysTray.Click += new System.EventHandler(this.btnExitSysTray_Click);
            // 
            // nicToMinimized
            // 
            this.nicToMinimized.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicToMinimized.Icon = ((System.Drawing.Icon)(resources.GetObject("nicToMinimized.Icon")));
            // 
            // _tmpElapsedTime
            // 
            this._tmpElapsedTime.Interval = 1000;
            this._tmpElapsedTime.Tick += new System.EventHandler(this._tmpElapsedTime_Tick);
            // 
            // lblNotifications
            // 
            this.lblNotifications.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotifications.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblNotifications.Appearance.Options.UseFont = true;
            this.lblNotifications.Appearance.Options.UseForeColor = true;
            this.lblNotifications.Location = new System.Drawing.Point(12, 136);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(35, 16);
            this.lblNotifications.TabIndex = 19;
            this.lblNotifications.Text = "Listo.";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 533);
            this.Controls.Add(this.gbcSincronizar);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.pnlLabels);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SyncFTP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Principal_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseClick);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pnlOptions)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDispositivos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLabels)).EndInit();
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTabs)).EndInit();
            this.pnlTabs.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcCentral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvCentral)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcReplica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvReplica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbcSincronizar)).EndInit();
            this.gbcSincronizar.ResumeLayout(false);
            this.cmpMenuSysTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl pnlOptions;
        private DevExpress.XtraEditors.PanelControl pnlLabels;
        private DevExpress.XtraEditors.PanelControl pnlTabs;
        private DevExpress.XtraEditors.ProgressBarControl pbcProgress;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.SimpleButton btnAvanzados;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDispositivos;
        private DevExpress.XtraEditors.LabelControl lblAvance;
        private DevExpress.XtraGrid.GridControl gdcCentral;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvCentral;
        private DevExpress.XtraGrid.GridControl gdcReplica;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvReplica;
        private DevExpress.XtraEditors.GroupControl gbcSincronizar;
        private DevExpress.XtraEditors.SimpleButton btnIniciarReplica;
        private DevExpress.XtraEditors.SimpleButton btnIniciarCentral;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlafSkins;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderSelect;
        private System.Windows.Forms.NotifyIcon nicSystemTray;
        private System.Windows.Forms.ContextMenuStrip cmpMenuSysTray;
        private System.Windows.Forms.ToolStripMenuItem remotoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStartRemoteStrip;
        private System.Windows.Forms.ToolStripMenuItem btnPauseRemoteStrip;
        private System.Windows.Forms.ToolStripMenuItem btnStopRemoteStrip;
        private System.Windows.Forms.ToolStripMenuItem btnRemoteTreeStrip;
        private System.Windows.Forms.ToolStripMenuItem descargasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnStartLocalStrip;
        private System.Windows.Forms.ToolStripMenuItem btnPauseLocalStrip;
        private System.Windows.Forms.ToolStripMenuItem btnStopLocalStrip;
        private System.Windows.Forms.ToolStripMenuItem btnLocalTreeStrip;
        private System.Windows.Forms.ToolStripMenuItem btnExitSysTray;
        private System.Windows.Forms.NotifyIcon nicToMinimized;
        private System.Windows.Forms.Timer _tmpElapsedTime;
        private DevExpress.XtraEditors.LabelControl lblElapsedTime;
        private DevExpress.XtraEditors.LabelControl lblNotifications;
    }
}