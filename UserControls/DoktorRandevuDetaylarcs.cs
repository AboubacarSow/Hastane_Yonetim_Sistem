using Guna.UI2.WinForms;
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

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class DoktorRandevuDetaylarcs : UserControl
    {
        private SqlCommand _command;
        public int DoctorID {  get; set; } 

        private List<RandevuDto> _dto = new List<RandevuDto>();
       
        public DoktorRandevuDetaylarcs()
        {
            InitializeComponent();
        }

       

        private void DoktorRandevuDetaylarcs_Load(object sender, EventArgs e)
        {
            GetDoktorRandevu();
            datagridrandevu.DataSource = _dto;

        }

        private void GetDoktorRandevu()
        {
            string query = "select * from Randevular where DoktorId=@p and HastaId is not null";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", DoctorID);
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read())
            {
                _dto.Add(new RandevuDto()
                {
                    RandevuId = (int)reader[0],
                    RandevuTarih = reader[1].ToString(),
                    RandevuSaat = reader[2].ToString(),
                    BransAdı = reader[3].ToString(),
                    DoktorAdı = reader[4].ToString(),
                    HastaAdı = reader[5].ToString(),
                    HastaSikayet = reader[6].ToString(),
                });
            }
        }

        private void datagridrandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richtxtsikyet.Text= datagridrandevu.CurrentRow.Cells[6].Value.ToString();
        }

       
    }
}
