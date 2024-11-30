namespace HastanYonetim_RandevuSistem.UserControls
{
    partial class BilgiDuzenle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hastaneYonetimDbDataSet1 = new HastanYonetim_RandevuSistem.HastaneYonetimDbDataSet1();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new HastanYonetim_RandevuSistem.HastaneYonetimDbDataSet1TableAdapters.BranchesTableAdapter();
            this.BtnGuncelle = new Sipaa.Framework.SButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.combocinsiyet = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHastaTelefon = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHastakimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHastaSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHastaAd = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hastaneYonetimDbDataSet1
            // 
            this.hastaneYonetimDbDataSet1.DataSetName = "HastaneYonetimDbDataSet1";
            this.hastaneYonetimDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.hastaneYonetimDbDataSet1;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnGuncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnGuncelle.BorderRadius = 25;
            this.BtnGuncelle.BorderSize = 0;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.FlatAppearance.BorderSize = 0;
            this.BtnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuncelle.ForeColor = System.Drawing.Color.White;
            this.BtnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuncelle.Location = new System.Drawing.Point(349, 594);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(311, 67);
            this.BtnGuncelle.TabIndex = 48;
            this.BtnGuncelle.Text = "Güncelleyin";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.update;
            this.pictureBox2.Location = new System.Drawing.Point(450, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.combocinsiyet);
            this.guna2Panel2.Location = new System.Drawing.Point(283, 504);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(446, 72);
            this.guna2Panel2.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cinsiyet";
            // 
            // combocinsiyet
            // 
            this.combocinsiyet.BackColor = System.Drawing.Color.Transparent;
            this.combocinsiyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combocinsiyet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combocinsiyet.DropDownHeight = 110;
            this.combocinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocinsiyet.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocinsiyet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combocinsiyet.FocusedState.FillColor = System.Drawing.Color.White;
            this.combocinsiyet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combocinsiyet.ForeColor = System.Drawing.Color.Black;
            this.combocinsiyet.HoverState.FillColor = System.Drawing.Color.White;
            this.combocinsiyet.IntegralHeight = false;
            this.combocinsiyet.ItemHeight = 30;
            this.combocinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.combocinsiyet.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.combocinsiyet.ItemsAppearance.SelectedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.combocinsiyet.Location = new System.Drawing.Point(127, 3);
            this.combocinsiyet.MaxDropDownItems = 2;
            this.combocinsiyet.Name = "combocinsiyet";
            this.combocinsiyet.Size = new System.Drawing.Size(305, 36);
            this.combocinsiyet.StartIndex = 0;
            this.combocinsiyet.TabIndex = 21;
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.Animated = true;
            this.txtHastaTelefon.BorderRadius = 5;
            this.txtHastaTelefon.BorderThickness = 2;
            this.txtHastaTelefon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaTelefon.DefaultText = "";
            this.txtHastaTelefon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastaTelefon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastaTelefon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaTelefon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaTelefon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaTelefon.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHastaTelefon.ForeColor = System.Drawing.Color.Black;
            this.txtHastaTelefon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaTelefon.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastaTelefon.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaTelefon.Location = new System.Drawing.Point(283, 410);
            this.txtHastaTelefon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.PasswordChar = '\0';
            this.txtHastaTelefon.PlaceholderText = "Telefon";
            this.txtHastaTelefon.SelectedText = "";
            this.txtHastaTelefon.Size = new System.Drawing.Size(446, 72);
            this.txtHastaTelefon.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(343, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 34);
            this.label4.TabIndex = 44;
            this.label4.Text = " Bilgi Düzenleme Panel";
            // 
            // txtHastakimlik
            // 
            this.txtHastakimlik.Animated = true;
            this.txtHastakimlik.BorderRadius = 5;
            this.txtHastakimlik.BorderThickness = 2;
            this.txtHastakimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastakimlik.DefaultText = "";
            this.txtHastakimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastakimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastakimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastakimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastakimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastakimlik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHastakimlik.ForeColor = System.Drawing.Color.Black;
            this.txtHastakimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastakimlik.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastakimlik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastakimlik.Location = new System.Drawing.Point(283, 326);
            this.txtHastakimlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastakimlik.Name = "txtHastakimlik";
            this.txtHastakimlik.PasswordChar = '\0';
            this.txtHastakimlik.PlaceholderText = "TC Kimlik No";
            this.txtHastakimlik.SelectedText = "";
            this.txtHastakimlik.Size = new System.Drawing.Size(446, 72);
            this.txtHastakimlik.TabIndex = 43;
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Animated = true;
            this.txtHastaSoyad.BorderRadius = 5;
            this.txtHastaSoyad.BorderThickness = 2;
            this.txtHastaSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaSoyad.DefaultText = "";
            this.txtHastaSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastaSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastaSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaSoyad.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHastaSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtHastaSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaSoyad.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastaSoyad.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaSoyad.Location = new System.Drawing.Point(283, 231);
            this.txtHastaSoyad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.PasswordChar = '\0';
            this.txtHastaSoyad.PlaceholderText = "Soyad";
            this.txtHastaSoyad.SelectedText = "";
            this.txtHastaSoyad.Size = new System.Drawing.Size(446, 72);
            this.txtHastaSoyad.TabIndex = 42;
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Animated = true;
            this.txtHastaAd.BorderRadius = 5;
            this.txtHastaAd.BorderThickness = 2;
            this.txtHastaAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaAd.DefaultText = "";
            this.txtHastaAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHastaAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHastaAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHastaAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaAd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtHastaAd.ForeColor = System.Drawing.Color.Black;
            this.txtHastaAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHastaAd.HoverState.FillColor = System.Drawing.Color.White;
            this.txtHastaAd.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHastaAd.Location = new System.Drawing.Point(283, 147);
            this.txtHastaAd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.PasswordChar = '\0';
            this.txtHastaAd.PlaceholderText = "Ad";
            this.txtHastaAd.SelectedText = "";
            this.txtHastaAd.Size = new System.Drawing.Size(446, 72);
            this.txtHastaAd.TabIndex = 41;
            // 
            // BilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.txtHastaTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHastakimlik);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.txtHastaAd);
            this.Name = "BilgiDuzenle";
            this.Size = new System.Drawing.Size(957, 707);
            this.Load += new System.EventHandler(this.BilgiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private HastaneYonetimDbDataSet1 hastaneYonetimDbDataSet1;
        private HastaneYonetimDbDataSet1TableAdapters.BranchesTableAdapter branchesTableAdapter;
        private Sipaa.Framework.SButton BtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox combocinsiyet;
        private Guna.UI2.WinForms.Guna2TextBox txtHastaTelefon;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtHastakimlik;
        private Guna.UI2.WinForms.Guna2TextBox txtHastaSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtHastaAd;
    }
}
