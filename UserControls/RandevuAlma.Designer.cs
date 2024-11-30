namespace HastanYonetim_RandevuSistem.UserControls
{
    partial class RandevuAlma
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRandevuAl = new Sipaa.Framework.SButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ComboBrans = new Guna.UI2.WinForms.Guna2ComboBox();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hastaneYonetimDbDataSet = new HastanYonetim_RandevuSistem.HastaneYonetimDbDataSet();
            this.ComboDoktor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.richTxtSikayet = new System.Windows.Forms.RichTextBox();
            this.branchesTableAdapter = new HastanYonetim_RandevuSistem.HastaneYonetimDbDataSetTableAdapters.BranchesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(408, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Randevu Alınma";
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnRandevuAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRandevuAl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRandevuAl.BorderRadius = 8;
            this.BtnRandevuAl.BorderSize = 0;
            this.BtnRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRandevuAl.FlatAppearance.BorderSize = 0;
            this.BtnRandevuAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRandevuAl.ForeColor = System.Drawing.Color.White;
            this.BtnRandevuAl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRandevuAl.Location = new System.Drawing.Point(361, 563);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(311, 67);
            this.BtnRandevuAl.TabIndex = 8;
            this.BtnRandevuAl.Text = "Randevu Alın";
            this.BtnRandevuAl.UseVisualStyleBackColor = false;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HastanYonetim_RandevuSistem.Properties.Resources.calendar;
            this.pictureBox1.Location = new System.Drawing.Point(457, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ComboBrans
            // 
            this.ComboBrans.BackColor = System.Drawing.Color.RosyBrown;
            this.ComboBrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBrans.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBrans.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBrans.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComboBrans.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.ComboBrans.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBrans.ItemHeight = 30;
            this.ComboBrans.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ComboBrans.Location = new System.Drawing.Point(287, 164);
            this.ComboBrans.Name = "ComboBrans";
            this.ComboBrans.Size = new System.Drawing.Size(467, 36);
            this.ComboBrans.TabIndex = 1;
            this.ComboBrans.SelectedIndexChanged += new System.EventHandler(this.ComboBrans_SelectedIndexChanged);
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.hastaneYonetimDbDataSet;
            // 
            // hastaneYonetimDbDataSet
            // 
            this.hastaneYonetimDbDataSet.DataSetName = "HastaneYonetimDbDataSet";
            this.hastaneYonetimDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboDoktor
            // 
            this.ComboDoktor.BackColor = System.Drawing.Color.Transparent;
            this.ComboDoktor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDoktor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDoktor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboDoktor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboDoktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboDoktor.ItemHeight = 30;
            this.ComboDoktor.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ComboDoktor.Location = new System.Drawing.Point(287, 238);
            this.ComboDoktor.Name = "ComboDoktor";
            this.ComboDoktor.Size = new System.Drawing.Size(467, 36);
            this.ComboDoktor.TabIndex = 2;
            // 
            // richTxtSikayet
            // 
            this.richTxtSikayet.Location = new System.Drawing.Point(287, 320);
            this.richTxtSikayet.Name = "richTxtSikayet";
            this.richTxtSikayet.Size = new System.Drawing.Size(461, 202);
            this.richTxtSikayet.TabIndex = 3;
            this.richTxtSikayet.Text = "";
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = " Branş  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = " Doktor  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Şikayetiniz :";
            // 
            // RandevuAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtSikayet);
            this.Controls.Add(this.ComboDoktor);
            this.Controls.Add(this.ComboBrans);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnRandevuAl);
            this.Controls.Add(this.label2);
            this.Name = "RandevuAlma";
            this.Size = new System.Drawing.Size(1036, 642);
            this.Load += new System.EventHandler(this.RandevuAlma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaneYonetimDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Sipaa.Framework.SButton BtnRandevuAl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBrans;
        private Guna.UI2.WinForms.Guna2ComboBox ComboDoktor;
        private System.Windows.Forms.RichTextBox richTxtSikayet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private HastaneYonetimDbDataSet hastaneYonetimDbDataSet;
        private HastaneYonetimDbDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
