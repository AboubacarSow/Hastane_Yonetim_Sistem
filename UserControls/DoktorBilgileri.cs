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
using HastanYonetim_RandevuSistem.Models;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class DoktorBilgileri : UserControl
    {
        private SqlCommand _command;
        private SqlDataReader _reader;
        public  string DoktorbransFromBilgiUserControl { get; set; }
        public DoktorBilgileri()
        {
            InitializeComponent();
        }
        private void DoktorBilgileri_Load(object sender, EventArgs e)
        {
            GetDoktorBilgi(Doktor.TCfromGiris);
            lblTCNo.Text = Doktor.TCfromGiris;
            lblAd.Text=DoktorDto.DoktorName;
            lblSoyad.Text = DoktorDto.DoktorLastName;
            lblBrans.Text=DoktorDto.BransName;
        }

        private void GetDoktorBilgi(string tc)
        {
            
            string query = "select * from Doctors where Doctor_TC=@p";
            _command = new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", tc);
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                DoktorDto.DoktorName = _reader[1].ToString();
                DoktorDto.DoktorLastName = _reader[2].ToString();
                DoktorDto.BransName = GetDoktorBrans(_reader[3].ToString());
            }
            SqlConnecteur.GetConnection().Close();
 
          

        }
        private string GetDoktorBrans(string bransid)
        {
            string bransName=String.Empty;
            string query = "select BranchName from Branches where BrachId=@id";
            _command= new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@id",bransid);
            _reader = _command.ExecuteReader();
            while (_reader.Read())
            {
                bransName = _reader[0].ToString();
            }

            return bransName;

        }
    }
}
