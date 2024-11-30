using HastanYonetim_RandevuSistem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.Forms
{
    public partial class SekreterGiris : Form
    {
        private SqlCommand command;
        public SekreterGiris()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Form form = new Form();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string query = "select * from Secretaries where Secretary_TC= @tc and Sifre=@sifre";
            command = new SqlCommand(query, SqlConnecteur.GetConnection());
            command.Parameters.AddWithValue("@tc", txtSekreterTckimlik.Text);
            command.Parameters.AddWithValue("@sifre", txtSekretersifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Sekreter sekreter = new Sekreter();
                sekreter.TCfromSGiris = txtSekreterTckimlik.Text;
                sekreter.AdSoyad = reader["FullName"].ToString();
                sekreter.Show();
                this.Close();
                SqlConnecteur.GetConnection().Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik veya Şifre.\n\n Lütfen Bilgilerinizi kontrol edin ve Tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show(); 
            this.Close();   
        }
    }
}
