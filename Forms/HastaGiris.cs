using HastanYonetim_RandevuSistem.Models;
using System;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.Forms
{
    public partial class HastaGirisPaneli : Form
    {
        private SqlCommand command;
        public HastaGirisPaneli()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(); 
            this.Close();
            form.Show();
        }

        private void linkkayitol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayitForm form = new HastaKayitForm(); 
            form.ShowDialog();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string query = "select * from Patients where Patient_TC= @tc and Sifre=@sifre";
            command= new SqlCommand(query, SqlConnecteur.GetConnection());
            command.Parameters.AddWithValue("@tc", txtHastaTckimlik.Text);
            command.Parameters.AddWithValue("@sifre", txtHastasifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Hasta hasta = new Hasta();
                Hasta.TCfromGiris = txtHastaTckimlik.Text;
                hasta.Show();
                this.Close();
                SqlConnecteur.GetConnection().Close();      
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik veya Şifre.\n\n Lütfen Bilgilerinizi kontrol edin ve Tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Essai
        }

        private void linkSifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //To After

        }
    }
}
