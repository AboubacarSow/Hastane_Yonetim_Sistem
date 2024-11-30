using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using HastanYonetim_RandevuSistem.Forms;
using HastanYonetim_RandevuSistem.Models;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class DoktorBilgiDuzenle : UserControl
    {
        private SqlCommand _command;
        
        public DoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        private void DoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtDoktorAd.Text = DoktorDto.DoktorName;
            txtDoktorSoyad.Text = DoktorDto.DoktorLastName;
            txtDoktorkimlik.Text= Doktor.TCfromGiris;
            combodoktorBrans.SelectedText=DoktorDto.BransName;
        }

        private void BtnBilgiduzenle_Click(object sender, EventArgs e)
        {
            string query = "update Doctors set DoctorName=@p1, DoctorLastName=@p2,BranchId=@p3,Doctor_TC=@p4, where DoctorId=@p0";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p0", txtDoktorAd.Text);
            _command.Parameters.AddWithValue("@p1", txtDoktorAd.Text);
            _command.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
            _command.Parameters.AddWithValue("@p3", GetSelectedBransId());
            _command.Parameters.AddWithValue("@p4", txtDoktorkimlik.Text);
         
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }
        private int GetSelectedBransId()
        {
            var id = 0;
            _command = new SqlCommand("select BrachId from Branches where BranchName=@p",SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", combodoktorBrans.Text);
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read())
            {
                id= Convert.ToInt32(reader["BrachId"]);
            }
            SqlConnecteur.GetConnection().Close();
            return id;
        }
    }
}
