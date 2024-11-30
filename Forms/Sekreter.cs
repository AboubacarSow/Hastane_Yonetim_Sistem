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
    public partial class Sekreter : Form
    {
        public  string TCfromSGiris {  get; set; }  
        public string AdSoyad {  get; set; }   
        private int doktorId = 0;
     
        private SqlCommand _command;
        public Sekreter()
        {
            InitializeComponent();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Bu pencereden çıkmayı emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                SekreterGiris sekreterGiris = new SekreterGiris();
                sekreterGiris.Show();   
                this.Close();
            }
            
        }

        private void Sekreter_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TCfromSGiris;
            lblAdSoyad.Text = AdSoyad;  
            // TODO: This line of code loads data into the 'hastaneYonetimDbDataSet6.Duyurular' table. You can move, or remove it, as needed.
            this.duyurularTableAdapter.Fill(this.hastaneYonetimDbDataSet6.Duyurular);
            // TODO: This line of code loads data into the 'hastaneYonetimDbDataSet4.Randevular' table. You can move, or remove it, as needed.
            this.randevularTableAdapter.Fill(this.hastaneYonetimDbDataSet4.Randevular);
            // TODO: This line of code loads data into the 'hastaneYonetimDbDataSet3.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this.hastaneYonetimDbDataSet3.Branches);
            // TODO: This line of code loads data into the 'hastaneYonetimDbDataSet2.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.hastaneYonetimDbDataSet2.Doctors);

        }
        #region Duyuru Oluşturma
        private void BtnDuyuruolustur_Click(object sender, EventArgs e)
        {
            string query = "insert into Duyurular (Duyuru) values (@text)";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@text", rTxtDuyuru.Text); 
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();

        }
        #endregion

        #region Doktor Paneli

        private void BtnDoktorEkle_Click(object sender, EventArgs e)
        {
            string query = "insert into Doctors (DoctorName,DoctorLastName,BranchId,Doctor_TC,Sifre) values (@p1,@-2,@p3,@p4,@p5)";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p1", txtDoktorAd.Text);
            _command.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
            _command.Parameters.AddWithValue("@p3", GetSelectedBransId());
            _command.Parameters.AddWithValue("@p4", txtDoktorkimlik);
            _command.Parameters.AddWithValue("@p5", txtDoktorSifre);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }

        private int GetSelectedBransId()
        {
            return this.hastaneYonetimDbDataSet3.Branches.Where(c => c.BranchName == comborandevuBrans.Text).Select(i => i.BrachId).FirstOrDefault();
        }
        private int GetSelectedDoktorId()
        {
            return this.hastaneYonetimDbDataSet2.Doctors.Where(d => d.DoctorId == (int)DatagridDoktorlar.CurrentRow.Cells[0].Value).Select(i=>i.DoctorId).FirstOrDefault();
        }
        private void BtnDoktorBilgiGuncelle_Click(object sender, EventArgs e)
        {
            string query = "update Doctors set DoctorName=@p1, DoctorLastName=@p2,BranchId=@p3,Doctor_TC=@p4,Sifre=@p5 where DoctorId=@p0";
            _command = new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p0", doktorId);
            _command.Parameters.AddWithValue("@p1", txtDoktorAd.Text);
            _command.Parameters.AddWithValue("@p2", txtDoktorSoyad.Text);
            _command.Parameters.AddWithValue("@p3", GetSelectedBransId());
            _command.Parameters.AddWithValue("@p4", txtDoktorkimlik.Text);
            _command.Parameters.AddWithValue("@p5", txtDoktorSifre.Text);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();  
        }
        private void DatagridDoktorliste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var doctor = this.hastaneYonetimDbDataSet2.Doctors.Where(d => d.DoctorId == (int)DatagridDoktorlar.CurrentRow.Cells[0].Value).ToList();
            doktorId = Convert.ToInt32(doctor[0]);
            txtDoktorAd.Text = doctor[1].ToString();
            txtDoktorSoyad.Text = doctor[2].ToString();
            comborandevuBrans.Text = doctor[3].ToString();
            txtDoktorkimlik.Text = doctor[4].ToString();
            txtDoktorSifre.Text = doctor[5].ToString();
        }
        

        private void BtnDoktorSilme_Click(object sender, EventArgs e)
        {

            string query = "delete from Doctors where DoctorId=@p";
            _command = new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", GetSelectedDoktorId());
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();  
        }
        #endregion

        #region Branş Paneli
        private void BtnBransEkle_Click(object sender, EventArgs e)
        {
            string query = "insert into Branches (BranchName) values (@text)";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@text", txtBransAdı.Text);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }

        private void BtnBransGuncel_Click(object sender, EventArgs e)
        {
            string query = "update Branches set BranchName=@p1 where BranchId=@p0";
            _command = new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p0",Convert.ToInt32(txtBranchId.Text));
            _command.Parameters.AddWithValue("@p1", txtBransAdı.Text);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }


        private void BtnbransSil_Click(object sender, EventArgs e)
        {
            string query = "delete from Branches where BrachId=@p";
            _command = new SqlCommand(query, SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", DataGridBranch.SelectedCells[0].RowIndex);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }
        private void DataGridBranch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBranchId.Text= DataGridBranch.SelectedCells[0].RowIndex.ToString();
            txtBransAdı.Text= DataGridBranch.Rows[DataGridBranch.SelectedCells[0].RowIndex].Cells[1].ToString();
        }



        #endregion

        #region Randevu Paneli
        private string tarih;
        private string saat;
        private int randevuId;
        private void BtnRandevuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = GetDateTime();
                string columns = "RandevuTarih,RandevuSaat, BranchId, DoktorId";
                string query = $"insert into Randevular ({columns}) values (@p1,@p2,@p3,@p4)";
                _command = new SqlCommand(query, SqlConnecteur.GetConnection());
                _command.Parameters.AddWithValue("@p1", date.Date);
                _command.Parameters.AddWithValue("@p2", saat);
                _command.Parameters.AddWithValue("@p3", GetSelectedBransId());
                _command.Parameters.AddWithValue("@p4", GetSelectedDoktorId());
                _command.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı.Kayıt alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnecteur.GetConnection().Close();    
            }

            
        }

        private DateTime GetDateTime()
        {
            tarih = txtrandevuTarih.Text;
            int day = Convert.ToInt32(tarih.Substring(0, 2));
            int month = Convert.ToInt32(tarih.Substring(2, 2));
            int year = Convert.ToInt32(tarih.Substring(4, 4));
            saat = txtrandevusaat.Text.Substring(0, 2) + ":" + txtrandevusaat.Text.Substring(3, 2);
            var date = new DateTime(year, month, day);
            return date;
        }

        private void DataGridRandevu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             randevuId=(int) DataGridRandevu.SelectedCells[0].Value;
            txtrandevuid.Text = randevuId.ToString();
            txtrandevuTarih.Text = DataGridRandevu.Rows[randevuId].Cells[1].Value.ToString() ;
            txtrandevusaat.Text = DataGridRandevu.Rows[randevuId].Cells[2].Value.ToString() ;
            comborandevuBrans.Text = DataGridRandevu.Rows[randevuId].Cells[3].Value.ToString() ;
            comborandevuDoktor.Text = DataGridRandevu.Rows[randevuId].Cells[4].Value.ToString() ;
            checkrandevudurum.Checked =(bool) DataGridRandevu.Rows[randevuId].Cells[5].Value;
            
        }
     

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "update Randevular set RandevuTarih=@p1,RandevuSaat=@p2,BranchId=@p3,DoctorId=@p4,RandevuDurum=@p5 where RandevuId=@p0";
                DateTime date = GetDateTime();
                _command = new SqlCommand(query, SqlConnecteur.GetConnection());
                _command.Parameters.AddWithValue("@p0", randevuId);
                _command.Parameters.AddWithValue("@p1", date.Date);
                _command.Parameters.AddWithValue("@p2", saat);
                _command.Parameters.AddWithValue("@p3", GetSelectedBransId());
                _command.Parameters.AddWithValue("@p4", GetSelectedDoktorId());
                _command.Parameters.AddWithValue("@p5", checkrandevudurum.CheckedState.ToString());
                _command.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı. Bilgileri Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnecteur.GetConnection().Close();
            }

        }

        private void BtnRandevuSil_Click(object sender, EventArgs e)
        {
            var id =(int) DataGridRandevu.SelectedCells[0].Value;
            string query = "delete from Randevular where RandevuId=@p";
            _command= new SqlCommand(query,SqlConnecteur.GetConnection());
            _command.Parameters.AddWithValue("@p", id);
            _command.ExecuteNonQuery();
            SqlConnecteur.GetConnection().Close();
        }
        #endregion

        
    }
}
