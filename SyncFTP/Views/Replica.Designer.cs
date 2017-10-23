namespace SyncFTP.Views
{
    partial class Replica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replica));
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.lblContinuar = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.chkAutenticar = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbxEncriptacion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkAnonimo = new DevExpress.XtraEditors.CheckEdit();
            this.txtDirectorio = new DevExpress.XtraEditors.TextEdit();
            this.txtPuerto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.petVerPassword = new DevExpress.XtraEditors.PictureEdit();
            this.petProbar = new DevExpress.XtraEditors.PictureEdit();
            this.petContinuar = new DevExpress.XtraEditors.PictureEdit();
            this.btnAyuda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutenticar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEncriptacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnonimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petProbar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petContinuar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(324, 452);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(100, 14);
            this.labelControl10.TabIndex = 55;
            this.labelControl10.Text = "Probar conexión";
            // 
            // lblContinuar
            // 
            this.lblContinuar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblContinuar.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblContinuar.Appearance.Options.UseFont = true;
            this.lblContinuar.Appearance.Options.UseForeColor = true;
            this.lblContinuar.Location = new System.Drawing.Point(457, 452);
            this.lblContinuar.Name = "lblContinuar";
            this.lblContinuar.Size = new System.Drawing.Size(58, 14);
            this.lblContinuar.TabIndex = 53;
            this.lblContinuar.Text = "Siguiente";
            this.lblContinuar.Visible = false;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(251, 310);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkActivo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkActivo.Properties.Appearance.Options.UseFont = true;
            this.chkActivo.Properties.Appearance.Options.UseForeColor = true;
            this.chkActivo.Properties.Caption = "Modo Activo";
            this.chkActivo.Size = new System.Drawing.Size(173, 22);
            this.chkActivo.TabIndex = 51;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // chkAutenticar
            // 
            this.chkAutenticar.Location = new System.Drawing.Point(251, 267);
            this.chkAutenticar.Name = "chkAutenticar";
            this.chkAutenticar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkAutenticar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkAutenticar.Properties.Appearance.Options.UseFont = true;
            this.chkAutenticar.Properties.Appearance.Options.UseForeColor = true;
            this.chkAutenticar.Properties.Caption = "Requiere Autenticar";
            this.chkAutenticar.Size = new System.Drawing.Size(150, 22);
            this.chkAutenticar.TabIndex = 50;
            this.chkAutenticar.CheckedChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(13, 269);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 18);
            this.labelControl8.TabIndex = 49;
            this.labelControl8.Text = "* Encriptación:";
            // 
            // cbxEncriptacion
            // 
            this.cbxEncriptacion.EditValue = "Sin encriptar";
            this.cbxEncriptacion.Location = new System.Drawing.Point(113, 266);
            this.cbxEncriptacion.Name = "cbxEncriptacion";
            this.cbxEncriptacion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.cbxEncriptacion.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cbxEncriptacion.Properties.Appearance.Options.UseFont = true;
            this.cbxEncriptacion.Properties.Appearance.Options.UseForeColor = true;
            this.cbxEncriptacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEncriptacion.Properties.Items.AddRange(new object[] {
            "Sin encriptar",
            "TLS/SSL Implícita",
            "TLS/SSL Explícita"});
            this.cbxEncriptacion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxEncriptacion.Size = new System.Drawing.Size(132, 24);
            this.cbxEncriptacion.TabIndex = 48;
            this.cbxEncriptacion.SelectedIndexChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // chkAnonimo
            // 
            this.chkAnonimo.Location = new System.Drawing.Point(431, 181);
            this.chkAnonimo.Name = "chkAnonimo";
            this.chkAnonimo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkAnonimo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkAnonimo.Properties.Appearance.Options.UseFont = true;
            this.chkAnonimo.Properties.Appearance.Options.UseForeColor = true;
            this.chkAnonimo.Properties.Caption = "Anónimo";
            this.chkAnonimo.Size = new System.Drawing.Size(84, 22);
            this.chkAnonimo.TabIndex = 47;
            this.chkAnonimo.CheckedChanged += new System.EventHandler(this.chkAnonimo_CheckedChanged);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(113, 356);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDirectorio.Properties.Appearance.Options.UseFont = true;
            this.txtDirectorio.Properties.NullText = "/Carpeta1/Carpeta2";
            this.txtDirectorio.Size = new System.Drawing.Size(311, 24);
            this.txtDirectorio.TabIndex = 46;
            this.txtDirectorio.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(113, 309);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPuerto.Properties.Appearance.Options.UseFont = true;
            this.txtPuerto.Properties.Mask.BeepOnError = true;
            this.txtPuerto.Properties.Mask.EditMask = "d";
            this.txtPuerto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPuerto.Properties.MaxLength = 5;
            this.txtPuerto.Properties.NullText = "00000";
            this.txtPuerto.Size = new System.Drawing.Size(132, 24);
            this.txtPuerto.TabIndex = 45;
            this.txtPuerto.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(42, 359);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 18);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Directorio:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(47, 312);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 43;
            this.labelControl6.Text = "* Puerto:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 226);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 18);
            this.labelControl5.TabIndex = 42;
            this.labelControl5.Text = "* Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(113, 223);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.NullText = "password";
            this.txtContrasena.Properties.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(288, 24);
            this.txtContrasena.TabIndex = 41;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(41, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "* Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(113, 180);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.NullText = "usuario";
            this.txtUsuario.Size = new System.Drawing.Size(311, 24);
            this.txtUsuario.TabIndex = 39;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(37, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 18);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "* Servidor:";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(113, 137);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServidor.Properties.Appearance.Options.UseFont = true;
            this.txtServidor.Properties.NullText = "ftp.server.com";
            this.txtServidor.Size = new System.Drawing.Size(311, 24);
            this.txtServidor.TabIndex = 37;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.AllowHtmlString = true;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.Location = new System.Drawing.Point(16, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(501, 38);
            this.labelControl4.TabIndex = 36;
            this.labelControl4.Text = "El servidor replica <b>no requiere de conexión a internet</b>. En este servidor s" +
    "e subirá la información del servidor central.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(79, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(312, 23);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Configuración para el servidor replica";
            // 
            // petVerPassword
            // 
            this.petVerPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.petVerPassword.EditValue = global::SyncFTP.Properties.Resources.Desbloquear;
            this.petVerPassword.Location = new System.Drawing.Point(400, 223);
            this.petVerPassword.Name = "petVerPassword";
            this.petVerPassword.Properties.AllowFocused = false;
            this.petVerPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petVerPassword.Properties.Appearance.Options.UseBackColor = true;
            this.petVerPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petVerPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petVerPassword.Properties.ShowMenu = false;
            this.petVerPassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petVerPassword.Size = new System.Drawing.Size(24, 24);
            this.petVerPassword.TabIndex = 56;
            this.petVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petVerPassword_MouseDown);
            this.petVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.petVerPassword_MouseUp);
            // 
            // petProbar
            // 
            this.petProbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.petProbar.EditValue = global::SyncFTP.Properties.Resources.Test;
            this.petProbar.Location = new System.Drawing.Point(343, 396);
            this.petProbar.Name = "petProbar";
            this.petProbar.Properties.AllowFocused = false;
            this.petProbar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petProbar.Properties.Appearance.Options.UseBackColor = true;
            this.petProbar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petProbar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petProbar.Properties.ShowMenu = false;
            this.petProbar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petProbar.Size = new System.Drawing.Size(58, 50);
            this.petProbar.TabIndex = 54;
            this.petProbar.Click += new System.EventHandler(this.petProbar_Click);
            // 
            // petContinuar
            // 
            this.petContinuar.Cursor = System.Windows.Forms.Cursors.Default;
            this.petContinuar.EditValue = global::SyncFTP.Properties.Resources.Next;
            this.petContinuar.Location = new System.Drawing.Point(457, 396);
            this.petContinuar.Name = "petContinuar";
            this.petContinuar.Properties.AllowFocused = false;
            this.petContinuar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petContinuar.Properties.Appearance.Options.UseBackColor = true;
            this.petContinuar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petContinuar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petContinuar.Properties.ShowMenu = false;
            this.petContinuar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petContinuar.Size = new System.Drawing.Size(58, 50);
            this.petContinuar.TabIndex = 52;
            this.petContinuar.Visible = false;
            this.petContinuar.Click += new System.EventHandler(this.petContinuar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.ImageOptions.Image = global::SyncFTP.Properties.Resources.Question36;
            this.btnAyuda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAyuda.Location = new System.Drawing.Point(477, 14);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 35;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::SyncFTP.Properties.Resources.Gear36;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(431, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::SyncFTP.Properties.Resources.LocalServer;
            this.pictureEdit2.Location = new System.Drawing.Point(16, 14);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(57, 50);
            this.pictureEdit2.TabIndex = 32;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::SyncFTP.Properties.Resources.LineaDelgada;
            this.pictureEdit1.Location = new System.Drawing.Point(15, 70);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(502, 2);
            this.pictureEdit1.TabIndex = 31;
            // 
            // Replica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 481);
            this.Controls.Add(this.petVerPassword);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.petProbar);
            this.Controls.Add(this.lblContinuar);
            this.Controls.Add(this.petContinuar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.chkAutenticar);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbxEncriptacion);
            this.Controls.Add(this.chkAnonimo);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Replica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de configuración - SyncFTP";
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutenticar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEncriptacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnonimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petProbar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petContinuar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.PictureEdit petProbar;
        private DevExpress.XtraEditors.LabelControl lblContinuar;
        private DevExpress.XtraEditors.PictureEdit petContinuar;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.CheckEdit chkAutenticar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEncriptacion;
        private DevExpress.XtraEditors.CheckEdit chkAnonimo;
        private DevExpress.XtraEditors.TextEdit txtDirectorio;
        private DevExpress.XtraEditors.TextEdit txtPuerto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnAyuda;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit petVerPassword;
    }
}