namespace HastanYonetim_RandevuSistem.Forms
{
    partial class HastaGirisPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirisPaneli));
            this.txtHastaTckimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHastasifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkkayitol = new System.Windows.Forms.LinkLabel();
            this.linkSifreunuttum = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.BtnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnGiris = new Sipaa.Framework.SButton();
            this.BtnGoBack = new Sipaa.Framework.SButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHastaTckimlik
            // 
            this.txtHastaTckimlik.Animated = true;
            this.txtHastaTckimlik.BorderRadius = 5;
            this.txtHastaTckimlik.BorderThickness = 2;
            this.txtHastaTckimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaTckimlik.DefaultText = "";
            this.txtHastaTckimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastaTckimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastaTckimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaTckimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaTckimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaTckimlik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastaTckimlik.ForeColor = System.Drawing.Color.Black;
            this.txtHastaTckimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaTckimlik.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastaTckimlik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaTckimlik.Location = new System.Drawing.Point(39, 285);
            this.txtHastaTckimlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastaTckimlik.Name = "txtHastaTckimlik";
            this.txtHastaTckimlik.PasswordChar = '\0';
            this.txtHastaTckimlik.PlaceholderText = "TC Kimlik No";
            this.txtHastaTckimlik.SelectedText = "";
            this.txtHastaTckimlik.Size = new System.Drawing.Size(427, 85);
            this.txtHastaTckimlik.TabIndex = 0;
            // 
            // txtHastasifre
            // 
            this.txtHastasifre.BorderRadius = 5;
            this.txtHastasifre.BorderThickness = 2;
            this.txtHastasifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastasifre.DefaultText = "";
            this.txtHastasifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastasifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastasifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastasifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastasifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastasifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastasifre.ForeColor = System.Drawing.Color.Black;
            this.txtHastasifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastasifre.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastasifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastasifre.Location = new System.Drawing.Point(39, 409);
            this.txtHastasifre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastasifre.Name = "txtHastasifre";
            this.txtHastasifre.PasswordChar = '●';
            this.txtHastasifre.PlaceholderText = "Şifre";
            this.txtHastasifre.SelectedText = "";
            this.txtHastasifre.Size = new System.Drawing.Size(427, 85);
            this.txtHastasifre.TabIndex = 1;
            this.txtHastasifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(170, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giriş Panel";
            // 
            // linkkayitol
            // 
            this.linkkayitol.AutoSize = true;
            this.linkkayitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkkayitol.Location = new System.Drawing.Point(217, 650);
            this.linkkayitol.Name = "linkkayitol";
            this.linkkayitol.Size = new System.Drawing.Size(103, 22);
            this.linkkayitol.TabIndex = 4;
            this.linkkayitol.TabStop = true;
            this.linkkayitol.Text = "Kayıt Olun !";
            this.linkkayitol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkkayitol_LinkClicked);
            // 
            // linkSifreunuttum
            // 
            this.linkSifreunuttum.AutoSize = true;
            this.linkSifreunuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSifreunuttum.Location = new System.Drawing.Point(35, 514);
            this.linkSifreunuttum.Name = "linkSifreunuttum";
            this.linkSifreunuttum.Size = new System.Drawing.Size(133, 22);
            this.linkSifreunuttum.TabIndex = 3;
            this.linkSifreunuttum.TabStop = true;
            this.linkSifreunuttum.Text = "Şifrem Unuttum";
            this.linkSifreunuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSifreunuttum_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kayıt değil mısınız?";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 7;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BorderRadius = 5;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FillColor = System.Drawing.Color.Red;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(452, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(45, 29);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(249)))));
            this.BtnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGiris.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGiris.BorderRadius = 10;
            this.BtnGiris.BorderSize = 0;
            this.BtnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGiris.FlatAppearance.BorderSize = 0;
            this.BtnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGiris.ForeColor = System.Drawing.Color.White;
            this.BtnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGiris.Location = new System.Drawing.Point(95, 564);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(311, 67);
            this.BtnGiris.TabIndex = 2;
            this.BtnGiris.Text = "Giriş Yapınız";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(249)))));
            this.BtnGoBack.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.arrow_left;
            this.BtnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGoBack.BorderRadius = 6;
            this.BtnGoBack.BorderSize = 0;
            this.BtnGoBack.FlatAppearance.BorderSize = 0;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.Location = new System.Drawing.Point(12, 792);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(81, 36);
            this.BtnGoBack.TabIndex = 5;
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.patient;
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HastaGirisPaneli
            // 
            this.AcceptButton = this.BtnGiris;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 840);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkSifreunuttum);
            this.Controls.Add(this.linkkayitol);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastasifre);
            this.Controls.Add(this.txtHastaTckimlik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(509, 840);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(509, 840);
            this.Name = "HastaGirisPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaDto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtHastaTckimlik;
        private Guna.UI2.WinForms.Guna2TextBox txtHastasifre;
        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.SButton BtnGoBack;
        private Sipaa.Framework.SButton BtnGiris;
        private System.Windows.Forms.LinkLabel linkkayitol;
        private System.Windows.Forms.LinkLabel linkSifreunuttum;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox BtnExit;
    }
}