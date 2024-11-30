namespace HastanYonetim_RandevuSistem.Forms
{
    partial class SekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterGiris));
            this.BtnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnGiris = new Sipaa.Framework.SButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSekretersifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSekreterTckimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnGoBack = new Sipaa.Framework.SButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
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
            this.BtnExit.Location = new System.Drawing.Point(437, 46);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(45, 29);
            this.BtnExit.TabIndex = 19;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnGiris
            // 
            this.BtnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.BtnGiris.Location = new System.Drawing.Point(91, 581);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(311, 67);
            this.BtnGiris.TabIndex = 15;
            this.BtnGiris.Text = "Giriş Yapınız";
            this.BtnGiris.UseVisualStyleBackColor = false;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(168, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giriş Panel";
            // 
            // txtSekretersifre
            // 
            this.txtSekretersifre.BorderRadius = 5;
            this.txtSekretersifre.BorderThickness = 2;
            this.txtSekretersifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSekretersifre.DefaultText = "";
            this.txtSekretersifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSekretersifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSekretersifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSekretersifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSekretersifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSekretersifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSekretersifre.ForeColor = System.Drawing.Color.Black;
            this.txtSekretersifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSekretersifre.HoverState.FillColor = System.Drawing.Color.White;
            this.txtSekretersifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSekretersifre.Location = new System.Drawing.Point(39, 452);
            this.txtSekretersifre.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSekretersifre.Name = "txtSekretersifre";
            this.txtSekretersifre.PasswordChar = '●';
            this.txtSekretersifre.PlaceholderText = "Şifre";
            this.txtSekretersifre.SelectedText = "";
            this.txtSekretersifre.Size = new System.Drawing.Size(427, 85);
            this.txtSekretersifre.TabIndex = 2;
            this.txtSekretersifre.UseSystemPasswordChar = true;
            // 
            // txtSekreterTckimlik
            // 
            this.txtSekreterTckimlik.Animated = true;
            this.txtSekreterTckimlik.BorderRadius = 5;
            this.txtSekreterTckimlik.BorderThickness = 2;
            this.txtSekreterTckimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSekreterTckimlik.DefaultText = "";
            this.txtSekreterTckimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSekreterTckimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSekreterTckimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSekreterTckimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSekreterTckimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSekreterTckimlik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSekreterTckimlik.ForeColor = System.Drawing.Color.Black;
            this.txtSekreterTckimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSekreterTckimlik.HoverState.FillColor = System.Drawing.Color.White;
            this.txtSekreterTckimlik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSekreterTckimlik.Location = new System.Drawing.Point(39, 337);
            this.txtSekreterTckimlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSekreterTckimlik.Name = "txtSekreterTckimlik";
            this.txtSekreterTckimlik.PasswordChar = '\0';
            this.txtSekreterTckimlik.PlaceholderText = "TC Kimlik No";
            this.txtSekreterTckimlik.SelectedText = "";
            this.txtSekreterTckimlik.Size = new System.Drawing.Size(427, 85);
            this.txtSekreterTckimlik.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.secretary;
            this.pictureBox1.Location = new System.Drawing.Point(157, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BtnGoBack
            // 
            this.BtnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(106)))));
            this.BtnGoBack.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.arrow_left;
            this.BtnGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGoBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGoBack.BorderRadius = 10;
            this.BtnGoBack.BorderSize = 0;
            this.BtnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoBack.FlatAppearance.BorderSize = 0;
            this.BtnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoBack.ForeColor = System.Drawing.Color.White;
            this.BtnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGoBack.Location = new System.Drawing.Point(23, 710);
            this.BtnGoBack.Name = "BtnGoBack";
            this.BtnGoBack.Size = new System.Drawing.Size(84, 47);
            this.BtnGoBack.TabIndex = 20;
            this.BtnGoBack.UseVisualStyleBackColor = false;
            this.BtnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // SekreterGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 784);
            this.Controls.Add(this.BtnGoBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSekretersifre);
            this.Controls.Add(this.txtSekreterTckimlik);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SekreterGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SekreterGiris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox BtnExit;
        private Sipaa.Framework.SButton BtnGiris;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSekretersifre;
        private Guna.UI2.WinForms.Guna2TextBox txtSekreterTckimlik;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sipaa.Framework.SButton BtnGoBack;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}