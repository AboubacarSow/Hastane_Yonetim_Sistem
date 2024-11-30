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
    public partial class DoktorGiris : Form
    {
        private SqlCommand _command;
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void linkSifreunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Reset the password
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string query = "select * from Doctors where Doctor_TC= @tc and Sifre=@sifre";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@tc", txtdoktorTckimlik.Text);
            _command.Parameters.AddWithValue("@sifre", txtdoktorasifre.Text);
            SqlDataReader reader = _command.ExecuteReader();
            if (reader.Read())
            {
                Doktor doktor = new  Doktor();
                Doktor.TCfromGiris = txtdoktorTckimlik.Text;
                doktor.AdSoyad = reader[1]+" " + reader[2];
                doktor.Show();
                this.Close();
                SqlConnecteur.GetConnection().Close();
            }
            else
            {
                MessageBox.Show("Hatalı TC Kimlik veya Şifre.\n\n Lütfen Bilgilerinizi kontrol edin ve Tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Doktor doktor = new Doktor();   
            //doktor.Show();
            //this.Close();   
        }
    }
}
