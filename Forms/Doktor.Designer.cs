namespace HastanYonetim_RandevuSistem.Forms
{
    partial class Doktor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBilgi = new Sipaa.Framework.SButton();
            this.BtnBilgiDuzenle = new Sipaa.Framework.SButton();
            this.BtnDuyurular = new Sipaa.Framework.SButton();
            this.BtnRandevuDetail = new Sipaa.Framework.SButton();
            this.BtnExit = new Sipaa.Framework.SButton();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLayout = new System.Windows.Forms.Panel();
            this.BtnDuzenle = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDuyuru = new Guna.UI2.WinForms.Guna2Button();
            this.BtnRandevu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBilgilerim = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip2 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip3 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip4 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2HtmlToolTip5 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.lblTCNo);
            this.panel1.Controls.Add(this.lblAdSoyad);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 707);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.BtnBilgiDuzenle);
            this.flowLayoutPanel1.Controls.Add(this.BtnDuyurular);
            this.flowLayoutPanel1.Controls.Add(this.BtnRandevuDetail);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 256);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 353);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBilgi);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 72);
            this.panel2.TabIndex = 13;
            // 
            // BtnBilgi
            // 
            this.BtnBilgi.BackColor = System.Drawing.Color.Transparent;
            this.BtnBilgi.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.user_data;
            this.BtnBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilgi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBilgi.BorderRadius = 0;
            this.BtnBilgi.BorderSize = 0;
            this.BtnBilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBilgi.FlatAppearance.BorderSize = 0;
            this.BtnBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilgi.ForeColor = System.Drawing.Color.White;
            this.BtnBilgi.Location = new System.Drawing.Point(0, 0);
            this.BtnBilgi.Name = "BtnBilgi";
            this.BtnBilgi.Size = new System.Drawing.Size(278, 72);
            this.BtnBilgi.TabIndex = 14;
            this.guna2HtmlToolTip2.SetToolTip(this.BtnBilgi, "Bilgilerim");
            this.BtnBilgi.UseVisualStyleBackColor = true;
            this.BtnBilgi.Click += new System.EventHandler(this.BtnBilgi_Click);
            // 
            // BtnBilgiDuzenle
            // 
            this.BtnBilgiDuzenle.BackColor = System.Drawing.Color.Transparent;
            this.BtnBilgiDuzenle.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.update;
            this.BtnBilgiDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilgiDuzenle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBilgiDuzenle.BorderRadius = 0;
            this.BtnBilgiDuzenle.BorderSize = 0;
            this.BtnBilgiDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBilgiDuzenle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBilgiDuzenle.FlatAppearance.BorderSize = 0;
            this.BtnBilgiDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilgiDuzenle.ForeColor = System.Drawing.Color.White;
            this.BtnBilgiDuzenle.Location = new System.Drawing.Point(3, 81);
            this.BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            this.BtnBilgiDuzenle.Size = new System.Drawing.Size(278, 72);
            this.BtnBilgiDuzenle.TabIndex = 15;
            this.guna2HtmlToolTip3.SetToolTip(this.BtnBilgiDuzenle, "Bilginleriniz Güncelleyin");
            this.BtnBilgiDuzenle.UseVisualStyleBackColor = false;
            this.BtnBilgiDuzenle.Click += new System.EventHandler(this.BtnBilgiDuzenle_Click);
            // 
            // BtnDuyurular
            // 
            this.BtnDuyurular.BackColor = System.Drawing.Color.Transparent;
            this.BtnDuyurular.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.announcement;
            this.BtnDuyurular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDuyurular.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDuyurular.BorderRadius = 0;
            this.BtnDuyurular.BorderSize = 0;
            this.BtnDuyurular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDuyurular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDuyurular.FlatAppearance.BorderSize = 0;
            this.BtnDuyurular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDuyurular.ForeColor = System.Drawing.Color.White;
            this.BtnDuyurular.Location = new System.Drawing.Point(3, 159);
            this.BtnDuyurular.Name = "BtnDuyurular";
            this.BtnDuyurular.Size = new System.Drawing.Size(278, 72);
            this.BtnDuyurular.TabIndex = 16;
            this.guna2HtmlToolTip4.SetToolTip(this.BtnDuyurular, "Duyurular");
            this.BtnDuyurular.UseVisualStyleBackColor = false;
            this.BtnDuyurular.Click += new System.EventHandler(this.BtnDuyurular_Click);
            // 
            // BtnRandevuDetail
            // 
            this.BtnRandevuDetail.BackColor = System.Drawing.Color.Transparent;
            this.BtnRandevuDetail.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.appointment_request;
            this.BtnRandevuDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRandevuDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRandevuDetail.BorderRadius = 0;
            this.BtnRandevuDetail.BorderSize = 0;
            this.BtnRandevuDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRandevuDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRandevuDetail.FlatAppearance.BorderSize = 0;
            this.BtnRandevuDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandevuDetail.ForeColor = System.Drawing.Color.White;
            this.BtnRandevuDetail.Location = new System.Drawing.Point(3, 237);
            this.BtnRandevuDetail.Name = "BtnRandevuDetail";
            this.BtnRandevuDetail.Size = new System.Drawing.Size(278, 72);
            this.BtnRandevuDetail.TabIndex = 17;
            this.guna2HtmlToolTip5.SetToolTip(this.BtnRandevuDetail, "Randevu Detayları Görüntüleyin");
            this.BtnRandevuDetail.UseVisualStyleBackColor = false;
            this.BtnRandevuDetail.Click += new System.EventHandler(this.BtnRandevuDetail_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.emergency_exit;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnExit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnExit.BorderRadius = 10;
            this.BtnExit.BorderSize = 0;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(29, 631);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(213, 64);
            this.BtnExit.TabIndex = 12;
            this.guna2HtmlToolTip1.SetToolTip(this.BtnExit, "Çıkış Yapınız");
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.lblTCNo.Location = new System.Drawing.Point(87, 218);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(70, 22);
            this.lblTCNo.TabIndex = 11;
            this.lblTCNo.Text = "HASTA";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(84, 166);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(73, 22);
            this.lblAdSoyad.TabIndex = 10;
            this.lblAdSoyad.Text = "TC NO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.doctor1;
            this.pictureBox1.Location = new System.Drawing.Point(54, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panelLayout
            // 
            this.panelLayout.BackColor = System.Drawing.Color.White;
            this.panelLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLayout.Controls.Add(this.BtnDuzenle);
            this.panelLayout.Controls.Add(this.BtnDuyuru);
            this.panelLayout.Controls.Add(this.BtnRandevu);
            this.panelLayout.Controls.Add(this.BtnBilgilerim);
            this.panelLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLayout.Location = new System.Drawing.Point(281, 0);
            this.panelLayout.Name = "panelLayout";
            this.panelLayout.Size = new System.Drawing.Size(957, 707);
            this.panelLayout.TabIndex = 1;
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.BackColor = System.Drawing.Color.White;
            this.BtnDuzenle.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.update;
            this.BtnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDuzenle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnDuzenle.BorderRadius = 20;
            this.BtnDuzenle.BorderThickness = 2;
            this.BtnDuzenle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuzenle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuzenle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDuzenle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDuzenle.FillColor = System.Drawing.Color.Transparent;
            this.BtnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDuzenle.ForeColor = System.Drawing.Color.White;
            this.BtnDuzenle.Location = new System.Drawing.Point(482, 124);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(328, 165);
            this.BtnDuzenle.TabIndex = 3;
            this.guna2HtmlToolTip3.SetToolTip(this.BtnDuzenle, "Bilginleriniz Güncelleyin");
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.BackColor = System.Drawing.Color.White;
            this.BtnDuyuru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDuyuru.BackgroundImage")));
            this.BtnDuyuru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDuyuru.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnDuyuru.BorderRadius = 20;
            this.BtnDuyuru.BorderThickness = 2;
            this.BtnDuyuru.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuyuru.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDuyuru.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDuyuru.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDuyuru.FillColor = System.Drawing.Color.Transparent;
            this.BtnDuyuru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDuyuru.ForeColor = System.Drawing.Color.White;
            this.BtnDuyuru.Location = new System.Drawing.Point(60, 456);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(328, 165);
            this.BtnDuyuru.TabIndex = 2;
            this.guna2HtmlToolTip4.SetToolTip(this.BtnDuyuru, "Duyurular");
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.BackColor = System.Drawing.Color.White;
            this.BtnRandevu.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.appointment_request;
            this.BtnRandevu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRandevu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnRandevu.BorderRadius = 20;
            this.BtnRandevu.BorderThickness = 2;
            this.BtnRandevu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRandevu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRandevu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRandevu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRandevu.FillColor = System.Drawing.Color.Transparent;
            this.BtnRandevu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRandevu.ForeColor = System.Drawing.Color.White;
            this.BtnRandevu.Location = new System.Drawing.Point(482, 456);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(328, 165);
            this.BtnRandevu.TabIndex = 1;
            this.guna2HtmlToolTip5.SetToolTip(this.BtnRandevu, "Randevu Detayları Görüntüleyin");
            this.BtnRandevu.Click += new System.EventHandler(this.BtnRandevu_Click);
            // 
            // BtnBilgilerim
            // 
            this.BtnBilgilerim.BackColor = System.Drawing.Color.White;
            this.BtnBilgilerim.BackgroundImage = global::HastanYonetim_RandevuSistem.Properties.Resources.user_data;
            this.BtnBilgilerim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilgilerim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(93)))), ((int)(((byte)(94)))));
            this.BtnBilgilerim.BorderRadius = 20;
            this.BtnBilgilerim.BorderThickness = 2;
            this.BtnBilgilerim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilgilerim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBilgilerim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBilgilerim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBilgilerim.FillColor = System.Drawing.Color.Transparent;
            this.BtnBilgilerim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnBilgilerim.ForeColor = System.Drawing.Color.White;
            this.BtnBilgilerim.Location = new System.Drawing.Point(60, 124);
            this.BtnBilgilerim.Name = "BtnBilgilerim";
            this.BtnBilgilerim.Size = new System.Drawing.Size(328, 165);
            this.BtnBilgilerim.TabIndex = 0;
            this.guna2HtmlToolTip2.SetToolTip(this.BtnBilgilerim, "Bilgilerim");
            this.BtnBilgilerim.Click += new System.EventHandler(this.BtnBilgilerim_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.Snow;
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.Red;
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip1.IsBalloon = true;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.guna2HtmlToolTip1.ToolTipTitle = "Dikkat!";
            // 
            // guna2HtmlToolTip2
            // 
            this.guna2HtmlToolTip2.AllowLinksHandling = true;
            this.guna2HtmlToolTip2.BorderColor = System.Drawing.Color.Gray;
            this.guna2HtmlToolTip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip2.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2HtmlToolTip2.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlToolTip2.TitleForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip2.ToolTipTitle = "[Bilgilendirme]";
            // 
            // guna2HtmlToolTip3
            // 
            this.guna2HtmlToolTip3.AllowLinksHandling = true;
            this.guna2HtmlToolTip3.BorderColor = System.Drawing.Color.Gray;
            this.guna2HtmlToolTip3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip3.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2HtmlToolTip3.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlToolTip3.TitleForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip3.ToolTipTitle = "[Bilgilendirme]";
            // 
            // guna2HtmlToolTip4
            // 
            this.guna2HtmlToolTip4.AllowLinksHandling = true;
            this.guna2HtmlToolTip4.BorderColor = System.Drawing.Color.Gray;
            this.guna2HtmlToolTip4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip4.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2HtmlToolTip4.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlToolTip4.TitleForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlToolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip4.ToolTipTitle = "[Bilgilendirme]";
            // 
            // guna2HtmlToolTip5
            // 
            this.guna2HtmlToolTip5.AllowLinksHandling = true;
            this.guna2HtmlToolTip5.BorderColor = System.Drawing.Color.Gray;
            this.guna2HtmlToolTip5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2HtmlToolTip5.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.guna2HtmlToolTip5.TitleFont = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlToolTip5.TitleForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlToolTip5.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.guna2HtmlToolTip5.ToolTipTitle = "[Bilgilendirme]";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.RosyBrown;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 707);
            this.Controls.Add(this.panelLayout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doktor";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sipaa.Framework.SButton BtnExit;
        private System.Windows.Forms.Panel panelLayout;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private Sipaa.Framework.SButton BtnBilgi;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip2;
        private Sipaa.Framework.SButton BtnBilgiDuzenle;
        private Sipaa.Framework.SButton BtnDuyurular;
        private Sipaa.Framework.SButton BtnRandevuDetail;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip3;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip4;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip5;
        private Guna.UI2.WinForms.Guna2Button BtnDuzenle;
        private Guna.UI2.WinForms.Guna2Button BtnDuyuru;
        private Guna.UI2.WinForms.Guna2Button BtnRandevu;
        private Guna.UI2.WinForms.Guna2Button BtnBilgilerim;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}