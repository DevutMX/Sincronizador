namespace SyncFTP.Views
{
    partial class Central
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Central));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtServidor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPuerto = new DevExpress.XtraEditors.TextEdit();
            this.txtDirectorio = new DevExpress.XtraEditors.TextEdit();
            this.chkAnonimo = new DevExpress.XtraEditors.CheckEdit();
            this.cbxEncriptacion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.chkAutenticar = new DevExpress.XtraEditors.CheckEdit();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.btnContinuar = new DevExpress.XtraEditors.SimpleButton();
            this.btnProbar = new DevExpress.XtraEditors.SimpleButton();
            this.petVerPassword = new DevExpress.XtraEditors.PictureEdit();
            this.btnAyuda = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnonimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEncriptacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutenticar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(314, 23);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Configuración para el servidor central";
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
            this.labelControl4.Location = new System.Drawing.Point(12, 76);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(501, 38);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "El servidor central <b>requiere de conexión a internet</b>. De este servidor se d" +
    "escargará la información al equipo o unidad extraíble.";
            // 
            // txtServidor
            // 
            this.txtServidor.EditValue = "";
            this.txtServidor.Location = new System.Drawing.Point(109, 135);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtServidor.Properties.Appearance.Options.UseFont = true;
            this.txtServidor.Properties.NullText = "ftp.server.com";
            this.txtServidor.Size = new System.Drawing.Size(311, 24);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(33, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 18);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "* Servidor:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 181);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 18);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "* Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.EditValue = "";
            this.txtUsuario.Location = new System.Drawing.Point(109, 178);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.NullText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(311, 24);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(11, 224);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(92, 18);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "* Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.EditValue = "";
            this.txtContrasena.Location = new System.Drawing.Point(109, 221);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtContrasena.Properties.Appearance.Options.UseFont = true;
            this.txtContrasena.Properties.NullText = "Password";
            this.txtContrasena.Properties.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(288, 24);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(43, 310);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 18);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "* Puerto:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(38, 357);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 18);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Directorio:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.EditValue = "";
            this.txtPuerto.Location = new System.Drawing.Point(109, 307);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPuerto.Properties.Appearance.Options.UseFont = true;
            this.txtPuerto.Properties.Mask.BeepOnError = true;
            this.txtPuerto.Properties.Mask.EditMask = "d";
            this.txtPuerto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPuerto.Properties.MaxLength = 5;
            this.txtPuerto.Properties.NullText = "00000";
            this.txtPuerto.Size = new System.Drawing.Size(132, 24);
            this.txtPuerto.TabIndex = 6;
            this.txtPuerto.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.EditValue = "";
            this.txtDirectorio.Location = new System.Drawing.Point(109, 354);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDirectorio.Properties.Appearance.Options.UseFont = true;
            this.txtDirectorio.Properties.NullText = "/Carpeta1/Carpeta2";
            this.txtDirectorio.Size = new System.Drawing.Size(311, 24);
            this.txtDirectorio.TabIndex = 8;
            this.txtDirectorio.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // chkAnonimo
            // 
            this.chkAnonimo.Location = new System.Drawing.Point(427, 179);
            this.chkAnonimo.Name = "chkAnonimo";
            this.chkAnonimo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkAnonimo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkAnonimo.Properties.Appearance.Options.UseFont = true;
            this.chkAnonimo.Properties.Appearance.Options.UseForeColor = true;
            this.chkAnonimo.Properties.Caption = "Anónimo";
            this.chkAnonimo.Size = new System.Drawing.Size(84, 22);
            this.chkAnonimo.TabIndex = 11;
            this.chkAnonimo.CheckedChanged += new System.EventHandler(this.chkAnonimo_CheckedChanged);
            // 
            // cbxEncriptacion
            // 
            this.cbxEncriptacion.EditValue = "Sin encriptar";
            this.cbxEncriptacion.Location = new System.Drawing.Point(109, 264);
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
            this.cbxEncriptacion.TabIndex = 4;
            this.cbxEncriptacion.SelectedIndexChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(9, 267);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(94, 18);
            this.labelControl8.TabIndex = 24;
            this.labelControl8.Text = "* Encriptación:";
            // 
            // chkAutenticar
            // 
            this.chkAutenticar.Location = new System.Drawing.Point(247, 265);
            this.chkAutenticar.Name = "chkAutenticar";
            this.chkAutenticar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkAutenticar.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkAutenticar.Properties.Appearance.Options.UseFont = true;
            this.chkAutenticar.Properties.Appearance.Options.UseForeColor = true;
            this.chkAutenticar.Properties.Caption = "Requiere Autenticar";
            this.chkAutenticar.Size = new System.Drawing.Size(150, 22);
            this.chkAutenticar.TabIndex = 5;
            this.chkAutenticar.CheckedChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(247, 308);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.chkActivo.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkActivo.Properties.Appearance.Options.UseFont = true;
            this.chkActivo.Properties.Appearance.Options.UseForeColor = true;
            this.chkActivo.Properties.Caption = "Modo Activo";
            this.chkActivo.Size = new System.Drawing.Size(173, 22);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Appearance.Options.UseFont = true;
            this.btnContinuar.ImageOptions.Image = global::SyncFTP.Properties.Resources.Next48;
            this.btnContinuar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnContinuar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnContinuar.Location = new System.Drawing.Point(427, 395);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(84, 71);
            this.btnContinuar.TabIndex = 33;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Visible = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnProbar
            // 
            this.btnProbar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnProbar.Appearance.Options.UseFont = true;
            this.btnProbar.ImageOptions.Image = global::SyncFTP.Properties.Resources.Share48;
            this.btnProbar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnProbar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnProbar.Location = new System.Drawing.Point(315, 395);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(105, 71);
            this.btnProbar.TabIndex = 32;
            this.btnProbar.Text = "Probar conexión";
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // petVerPassword
            // 
            this.petVerPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.petVerPassword.EditValue = global::SyncFTP.Properties.Resources.Desbloquear;
            this.petVerPassword.Location = new System.Drawing.Point(396, 221);
            this.petVerPassword.Name = "petVerPassword";
            this.petVerPassword.Properties.AllowFocused = false;
            this.petVerPassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.petVerPassword.Properties.Appearance.Options.UseBackColor = true;
            this.petVerPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.petVerPassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.petVerPassword.Properties.ShowMenu = false;
            this.petVerPassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.petVerPassword.Size = new System.Drawing.Size(24, 24);
            this.petVerPassword.TabIndex = 31;
            this.petVerPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.petVerPassword_MouseDown);
            this.petVerPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.petVerPassword_MouseUp);
            // 
            // btnAyuda
            // 
            this.btnAyuda.ImageOptions.Image = global::SyncFTP.Properties.Resources.Help32;
            this.btnAyuda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAyuda.Location = new System.Drawing.Point(473, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 12;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = global::SyncFTP.Properties.Resources.Back32;
            this.btnCancelar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancelar.Location = new System.Drawing.Point(427, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::SyncFTP.Properties.Resources.WebServer;
            this.pictureEdit2.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(57, 50);
            this.pictureEdit2.TabIndex = 7;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::SyncFTP.Properties.Resources.LineaDelgada;
            this.pictureEdit1.Location = new System.Drawing.Point(11, 68);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(502, 2);
            this.pictureEdit1.TabIndex = 6;
            // 
            // Central
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 481);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.petVerPassword);
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
            this.Name = "Central";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de configuración - SyncFTP";
            ((System.ComponentModel.ISupportInitialize)(this.txtServidor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuerto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirectorio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAnonimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEncriptacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAutenticar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petVerPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnAyuda;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtServidor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPuerto;
        private DevExpress.XtraEditors.TextEdit txtDirectorio;
        private DevExpress.XtraEditors.CheckEdit chkAnonimo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEncriptacion;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit chkAutenticar;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private DevExpress.XtraEditors.PictureEdit petVerPassword;
        private DevExpress.XtraEditors.SimpleButton btnProbar;
        private DevExpress.XtraEditors.SimpleButton btnContinuar;
    }
}