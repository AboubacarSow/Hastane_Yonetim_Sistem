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
    public partial class RandevuAlma : UserControl
    {
        private SqlCommand _command;
        List<string> _listBransad = new List<string>();
        List<BransDto> _branslar=new List<BransDto>();  
        List<string> _listDoktorad = new List<string>();
        public RandevuAlma()
        {
            InitializeComponent();
        }

        private int GetBransId()
        {
            BransDto brans = _branslar.Where(br => br.Name==ComboBrans.Text).First();
            return brans.Id;
        }

        private void RandevuAlma_Load(object sender, EventArgs e)
        {
            GetBranslar();
            GetlistBransad();
            ComboBrans.DataSource = _listBransad;     
        }
        private void GetlistBransad()
        {
            foreach (var brans in _branslar)
            {
                _listBransad.Add(brans.Name);
            }
        }
        private void GetBranslar()
        {
         
            string query = "Select * from Branches";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read())
            {
                _branslar.Add(new BransDto()
                {
                    Id = Convert.ToInt32(reader[0].ToString()),
                    Name = reader[1].ToString(),
                }); 
            }
        }
        private void GetDoktorlar(int id)
        {
            string query = $"Select (DoctorName + ' ' + DoctorLastName) from Doctors where BranchId={id}";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            SqlDataReader reader = _command.ExecuteReader();
            while (reader.Read())
            {
                _listDoktorad.Add(reader.GetString(0));
            }
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            //Current Step
        }

        private void ComboBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboDoktor.Items.Clear();
            GetDoktorlar(GetBransId());

            ComboDoktor.DataSource = _listDoktorad;
        }
    }
}
