namespace SyncFTP.Views
{
    partial class Servidores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidores));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.chkCentral = new DevExpress.XtraEditors.CheckEdit();
            this.chkReplica = new DevExpress.XtraEditors.CheckEdit();
            this.btnAyuda = new DevExpress.XtraEditors.SimpleButton();
            this.btnContinuar = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCentral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReplica.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(71, 23);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "SyncFTP";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(232, 23);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Configuración de servidores";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(156, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(258, 19);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Selecciona los servidores a conectar:";
            // 
            // chkCentral
            // 
            this.chkCentral.Location = new System.Drawing.Point(289, 174);
            this.chkCentral.Name = "chkCentral";
            this.chkCentral.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.chkCentral.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkCentral.Properties.Appearance.Options.UseFont = true;
            this.chkCentral.Properties.Appearance.Options.UseForeColor = true;
            this.chkCentral.Properties.Caption = "Central";
            this.chkCentral.Size = new System.Drawing.Size(89, 23);
            this.chkCentral.TabIndex = 1;
            // 
            // chkReplica
            // 
            this.chkReplica.Location = new System.Drawing.Point(289, 251);
            this.chkReplica.Name = "chkReplica";
            this.chkReplica.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.chkReplica.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkReplica.Properties.Appearance.Options.UseFont = true;
            this.chkReplica.Properties.Appearance.Options.UseForeColor = true;
            this.chkReplica.Properties.Caption = "Replica";
            this.chkReplica.Size = new System.Drawing.Size(89, 23);
            this.chkReplica.TabIndex = 2;
            // 
            // btnAyuda
            // 
            this.btnAyuda.ImageOptions.Image = global::SyncFTP.Properties.Resources.Help32;
            this.btnAyuda.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAyuda.Location = new System.Drawing.Point(532, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(40, 40);
            this.btnAyuda.TabIndex = 35;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.Appearance.Options.UseFont = true;
            this.btnContinuar.ImageOptions.Image = global::SyncFTP.Properties.Resources.Next48;
            this.btnContinuar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnContinuar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnContinuar.Location = new System.Drawing.Point(488, 238);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(84, 71);
            this.btnContinuar.TabIndex = 34;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit5.EditValue = global::SyncFTP.Properties.Resources.LocalServer;
            this.pictureEdit5.Location = new System.Drawing.Point(214, 238);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.AllowFocused = false;
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.ShowMenu = false;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(57, 50);
            this.pictureEdit5.TabIndex = 12;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit4.EditValue = global::SyncFTP.Properties.Resources.WebServer;
            this.pictureEdit4.Location = new System.Drawing.Point(214, 161);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.AllowFocused = false;
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.ShowMenu = false;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(57, 50);
            this.pictureEdit4.TabIndex = 10;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit2.EditValue = global::SyncFTP.Properties.Resources.SyncFTP;
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
            this.pictureEdit2.TabIndex = 4;
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
            this.pictureEdit1.Size = new System.Drawing.Size(560, 2);
            this.pictureEdit1.TabIndex = 3;
            // 
            // Servidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 319);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.chkReplica);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.chkCentral);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Servidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente de configuración - SyncFTP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Servidores_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chkCentral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkReplica.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.CheckEdit chkCentral;
        private DevExpress.XtraEditors.CheckEdit chkReplica;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.SimpleButton btnContinuar;
        private DevExpress.XtraEditors.SimpleButton btnAyuda;
    }
}