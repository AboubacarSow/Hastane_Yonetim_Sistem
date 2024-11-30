namespace HastanYonetim_RandevuSistem.Forms
{
    partial class DoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGiris));
            this.BtnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkSifreunuttum = new System.Windows.Forms.LinkLabel();
            this.BtnGiris = new Sipaa.Framework.SButton();
            this.txtdoktorasifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdoktorTckimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnGoBack = new Sipaa.Framework.SButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BorderRadius = 5;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FillColor = System.Drawing.Color.Red;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(412, 23);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(45, 29);
            this.BtnExit.TabIndex = 13;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(158, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "Giriş Panel";
            // 
            // linkSifreunuttum
            // 
            this.linkSifreunuttum.AutoSize = true;
            this.linkSifreunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSifreunuttum.Location = new System.Drawing.Point(25, 526);
            this.linkSifreunuttum.Name = "linkSifreunuttum";
            this.linkSifreunuttum.Size = new System.Drawing.Size(133, 22);
            this.linkSifreunuttum.TabIndex = 17;
            this.linkSifreunuttum.TabStop = true;
            this.linkSifreunuttum.Text = "Şifrem Unuttum";
            this.linkSifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifreunuttum_LinkClicked);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGiris.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGiris.BorderRadius = 25;
            this.BtnGiris.BorderSize = 0;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatAppearance.BorderSize = 0;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGiris.Location = new System.Drawing.Point(84, 565);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(311, 67);
            this.BtnGiris.TabIndex = 16;
            this.BtnGiris.Text = "Giriş Yapınız";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // txtdoktorasifre
            // 
            this.txtdoktorasifre.BorderRadius = 5;
            this.txtdoktorasifre.BorderThickness = 2;
            this.txtdoktorasifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoktorasifre.DefaultText = "";
            this.txtdoktorasifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdoktorasifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdoktorasifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoktorasifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoktorasifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoktorasifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoktorasifre.ForeColor = System.Drawing.Color.Black;
            this.txtdoktorasifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoktorasifre.HoverState.FillColor = System.Drawing.Color.White;
            this.txtdoktorasifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoktorasifre.Location = new System.Drawing.Point(29, 421);
            this.txtdoktorasifre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdoktorasifre.Name = "txtdoktorasifre";
            this.txtdoktorasifre.PasswordChar = '●';
            this.txtdoktorasifre.PlaceholderText = "Şifre";
            this.txtdoktorasifre.SelectedText = "";
            this.txtdoktorasifre.Size = new System.Drawing.Size(427, 85);
            this.txtdoktorasifre.TabIndex = 15;
            this.txtdoktorasifre.UseSystemPasswordChar = true;
            // 
            // txtdoktorTckimlik
            // 
            this.txtdoktorTckimlik.Animated = true;
            this.txtdoktorTckimlik.BorderRadius = 5;
            this.txtdoktorTckimlik.BorderThickness = 2;
            this.txtdoktorTckimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoktorTckimlik.DefaultText = "";
            this.txtdoktorTckimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdoktorTckimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdoktorTckimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoktorTckimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdoktorTckimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoktorTckimlik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdoktorTckimlik.ForeColor = System.Drawing.Color.Black;
            this.txtdoktorTckimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdoktorTckimlik.HoverState.FillColor = System.Drawing.Color.White;
            this.txtdoktorTckimlik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdoktorTckimlik.Location = new System.Drawing.Point(29, 297);
            this.txtdoktorTckimlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdoktorTckimlik.Name = "txtdoktorTckimlik";
            this.txtdoktorTckimlik.PasswordChar = '\0';
            this.txtdoktorTckimlik.PlaceholderText = "TC Kimlik No";
            this.txtdoktorTckimlik.SelectedText = "";
            this.txtdoktorTckimlik.Size = new System.Drawing.Size(427, 85);
            this.txtdoktorTckimlik.TabIndex = 14;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 8;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnGoBack.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.arrow_left;
            this.BtnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGoBack.BorderRadius = 6;
            this.BtnGoBack.BorderSize = 0;
            this.BtnGoBack.FlatAppearance.BorderSize = 0;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.Location = new System.Drawing.Point(12, 696);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(72, 40);
            this.BtnGoBack.TabIndex = 18;
            this.BtnGoBack.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.doctor1;
            this.pictureBox1.Location = new System.Drawing.Point(151, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 759);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.linkSifreunuttum);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.txtdoktorasifre);
            this.Controls.Add(this.txtdoktorTckimlik);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoktorGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkSifreunuttum;
        private Sipaa.Framework.SButton BtnGiris;
        private Guna.UI2.WinForms.Guna2TextBox txtdoktorasifre;
        private Guna.UI2.WinForms.Guna2TextBox txtdoktorTckimlik;
        private Sipaa.Framework.SButton BtnGoBack;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}