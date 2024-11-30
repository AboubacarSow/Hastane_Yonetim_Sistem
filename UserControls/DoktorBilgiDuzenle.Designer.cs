namespace HastanYonetim_RandevuSistem.UserControls
{
    partial class DoktorBilgiDuzenle
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
            this.BtnBilgiduzenle = new Sipaa.Framework.SButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.combodoktorBrans = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoktorkimlik = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoktorSoyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDoktorAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.hastaneYonetimDbDataSet1 = new HastanYonetim_RandevuSistem.HastaneYonetimDbDataSet();
            this.hastaneYonetimDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBilgiduzenle
            // 
            this.BtnBilgiduzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnBilgiduzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBilgiduzenle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBilgiduzenle.BorderRadius = 25;
            this.BtnBilgiduzenle.BorderSize = 0;
            this.BtnBilgiduzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBilgiduzenle.FlatAppearance.BorderSize = 0;
            this.BtnBilgiduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBilgiduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBilgiduzenle.ForeColor = System.Drawing.Color.White;
            this.BtnBilgiduzenle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBilgiduzenle.Location = new System.Drawing.Point(331, 579);
            this.BtnBilgiduzenle.Name = "BtnBilgiduzenle";
            this.BtnBilgiduzenle.Size = new System.Drawing.Size(311, 67);
            this.BtnBilgiduzenle.TabIndex = 39;
            this.BtnBilgiduzenle.Text = "Güncelleyin";
            this.BtnBilgiduzenle.UseVisualStyleBackColor = false;
            this.BtnBilgiduzenle.Click += new System.EventHandler(this.BtnBilgiduzenle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.update;
            this.pictureBox1.Location = new System.Drawing.Point(422, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.combodoktorBrans);
            this.guna2Panel1.Location = new System.Drawing.Point(255, 468);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(446, 72);
            this.guna2Panel1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Branş";
            // 
            // combodoktorBrans
            // 
            this.combodoktorBrans.BackColor = System.Drawing.Color.Transparent;
            this.combodoktorBrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combodoktorBrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combodoktorBrans.DropDownHeight = 110;
            this.combodoktorBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodoktorBrans.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combodoktorBrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combodoktorBrans.FocusedState.FillColor = System.Drawing.Color.White;
            this.combodoktorBrans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combodoktorBrans.ForeColor = System.Drawing.Color.Black;
            this.combodoktorBrans.HoverState.FillColor = System.Drawing.Color.White;
            this.combodoktorBrans.IntegralHeight = false;
            this.combodoktorBrans.ItemHeight = 30;
            this.combodoktorBrans.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.combodoktorBrans.ItemsAppearance.SelectedBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.combodoktorBrans.Location = new System.Drawing.Point(127, 3);
            this.combodoktorBrans.MaxDropDownItems = 2;
            this.combodoktorBrans.Name = "combodoktorBrans";
            this.combodoktorBrans.Size = new System.Drawing.Size(305, 36);
            this.combodoktorBrans.StartIndex = 0;
            this.combodoktorBrans.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(315, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 34);
            this.label1.TabIndex = 36;
            this.label1.Text = " Bilgi Düzenleme Panel";
            // 
            // txtDoktorkimlik
            // 
            this.txtDoktorkimlik.Animated = true;
            this.txtDoktorkimlik.BorderRadius = 5;
            this.txtDoktorkimlik.BorderThickness = 2;
            this.txtDoktorkimlik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorkimlik.DefaultText = "";
            this.txtDoktorkimlik.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorkimlik.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorkimlik.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorkimlik.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorkimlik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorkimlik.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoktorkimlik.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorkimlik.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorkimlik.HoverState.FillColor = System.Drawing.Color.White;
            this.txtDoktorkimlik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorkimlik.Location = new System.Drawing.Point(255, 359);
            this.txtDoktorkimlik.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDoktorkimlik.Name = "txtDoktorkimlik";
            this.txtDoktorkimlik.PasswordChar = '\0';
            this.txtDoktorkimlik.PlaceholderText = "TC Kimlik No";
            this.txtDoktorkimlik.SelectedText = "";
            this.txtDoktorkimlik.Size = new System.Drawing.Size(446, 72);
            this.txtDoktorkimlik.TabIndex = 35;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Animated = true;
            this.txtDoktorSoyad.BorderRadius = 5;
            this.txtDoktorSoyad.BorderThickness = 2;
            this.txtDoktorSoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorSoyad.DefaultText = "";
            this.txtDoktorSoyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorSoyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorSoyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorSoyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorSoyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorSoyad.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDoktorSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorSoyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorSoyad.HoverState.FillColor = System.Drawing.Color.White;
            this.txtDoktorSoyad.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorSoyad.Location = new System.Drawing.Point(255, 264);
            this.txtDoktorSoyad.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.PasswordChar = '\0';
            this.txtDoktorSoyad.PlaceholderText = "Soyad";
            this.txtDoktorSoyad.SelectedText = "";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(446, 72);
            this.txtDoktorSoyad.TabIndex = 34;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Animated = true;
            this.txtDoktorAd.BorderRadius = 5;
            this.txtDoktorAd.BorderThickness = 2;
            this.txtDoktorAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorAd.DefaultText = "";
            this.txtDoktorAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDoktorAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDoktorAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDoktorAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorAd.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDoktorAd.ForeColor = System.Drawing.Color.Black;
            this.txtDoktorAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDoktorAd.HoverState.FillColor = System.Drawing.Color.White;
            this.txtDoktorAd.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDoktorAd.Location = new System.Drawing.Point(255, 180);
            this.txtDoktorAd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.PasswordChar = '\0';
            this.txtDoktorAd.PlaceholderText = "Ad";
            this.txtDoktorAd.SelectedText = "";
            this.txtDoktorAd.Size = new System.Drawing.Size(446, 72);
            this.txtDoktorAd.TabIndex = 33;
            // 
            // hastaneYonetimDbDataSet1
            // 
            this.hastaneYonetimDbDataSet1.DataSetName = "HastaneYonetimDbDataSet";
            this.hastaneYonetimDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaneYonetimDbDataSet1BindingSource
            // 
            this.hastaneYonetimDbDataSet1BindingSource.DataSource = this.hastaneYonetimDbDataSet1;
            this.hastaneYonetimDbDataSet1BindingSource.Position = 0;
            // 
            // DoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BtnBilgiduzenle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDoktorkimlik);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Name = "DoktorBilgiDuzenle";
            this.Size = new System.Drawing.Size(957, 707);
            this.Load += new System.EventHandler(this.DoktorBilgiDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SButton BtnBilgiduzenle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox combodoktorBrans;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorkimlik;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorSoyad;
        private Guna.UI2.WinForms.Guna2TextBox txtDoktorAd;
        private System.Windows.Forms.BindingSource hastaneYonetimDbDataSet1BindingSource;
        private HastaneYonetimDbDataSet hastaneYonetimDbDataSet1;
    }
}
