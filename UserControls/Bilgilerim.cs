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
using HastanYonetim_RandevuSistem.Forms;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class Bilgilerim : UserControl
    {
        private SqlCommand _command;
        public  string AdSoyad { get; set; }
        public Bilgilerim()
        {
            InitializeComponent();
        }

        private void Bilgilerim_Load(object sender, EventArgs e)
        {
            var pid=String.Empty;   
            string columns = "PatientId,PatientName,PatientLastName,Patient_TC,PhoneNumber,Gendre";
            string query = $"Select {columns} from Patients where Patient_TC=@tc";
            _command=new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@tc", Hasta.TCfromGiris);
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read()) 
            {
                pid = reader[0].ToString();
                lblAd.Text = reader[1].ToString();
                lblSoyad.Text = reader[2].ToString();
                lblTCNo.Text = reader[3].ToString();
                lblTelefon.Text = reader[4].ToString();
                lblCisiyet.Text = reader[5].ToString(); 
                AdSoyad = lblAd.Text + " " + lblSoyad.Text;
                

            }
            SetValues(pid);
            SqlConnecteur.GetConnection().Close();
        }
        private void SetValues(string id)
        {
            HastaDto.HastaId =Convert.ToInt32(id);        
            HastaDto.HastaAd=lblAd.Text;
            HastaDto.HastaSoyad=lblSoyad.Text;
            HastaDto.HastaTcKimlik =lblTCNo.Text;
            HastaDto.HastaTelefon =lblTelefon.Text;
            HastaDto.HastaGendre=lblCisiyet.Text;
        }
    }
}
