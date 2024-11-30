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
using HastanYonetim_RandevuSistem.Models;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class GesmisRandevu : UserControl
    {
        private SqlCommand _command;
        List<RandevuDto> randevular = new List<RandevuDto>(); 
        public GesmisRandevu()
        {
            InitializeComponent();
        }

        private void GesmisRandevu_Load(object sender, EventArgs e)
        {
            string columns = "RandevuId,RandevuTarih,RandevuSaat,BranchId,DoktorId,RandevuDurum";
            string query = $"Select {columns} from Randevular where HastaId={HastaDto.HastaId}";
            _command = new SqlCommand(query,SqlConnecteur.GetConnection());
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read())
            {
                var randevu=new RandevuDto()
                {
                    RandevuId = Convert.ToInt32(reader[0]),
                    RandevuTarih= reader[1].ToString(),
                    RandevuSaat=reader[2].ToString(),   
                    BransAdı= GetBransName(Convert.ToInt32(reader[3])),
                    DoktorAdı= GetDoktorName(Convert.ToInt32(reader[4])),
                    Durum=(reader[5].ToString()=="true") ? "Katılmış" : "Katılmamış",
                    HastaAdı= HastaDto.HastaAd  
                };
                randevular.Add(randevu);  
            }
            DataGridGesmisRandevu.DataSource = randevular;
           
        }

        private string GetDoktorName(int id)
        {
            string query = $"Select DoctorName from Branches where DoctorId={id}";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            SqlDataReader reader = _command.ExecuteReader();
            string doctorName = String.Empty;
            while (reader.Read())
            {
                doctorName = reader[0].ToString();
            }
            SqlConnecteur.GetConnection().Close();
            return doctorName;
        }

        private string GetBransName(int id)
        {
            string query = $"Select BranchName from Branches where BrachId={id}";
            _command=new SqlCommand(query, SqlConnecteur.GetConnection());
            SqlDataReader reader = _command.ExecuteReader();
            string branchName=String.Empty;
            while (reader.Read())
            {
                 branchName=reader[0].ToString();
            }
            SqlConnecteur.GetConnection().Close();
            return branchName;

        }
    }
}
