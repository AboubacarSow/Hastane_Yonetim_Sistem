using HastanYonetim_RandevuSistem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class BilgiDuzenle : UserControl
    {
        private SqlCommand _command;
        public BilgiDuzenle()
        {
            InitializeComponent();
        }

        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtHastaAd.Text=HastaDto.HastaAd;
            txtHastaSoyad.Text=HastaDto.HastaSoyad;
            txtHastakimlik.Text = HastaDto.HastaTcKimlik;
            txtHastaTelefon.Text=HastaDto.HastaTelefon;
            combocinsiyet.Text = HastaDto.HastaGendre;
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"update Patients set PatientName=@p1,PatientLastName=@p2,Patient_TC=@p3,PhoneNumber=@p4,Gendre=@p5 where PatientId={HastaDto.HastaId}";
                _command = new SqlCommand(query,SqlConnecteur.GetConnection());
                _command.Parameters.AddWithValue("@p1",txtHastaAd);
                _command.Parameters.AddWithValue("@p2",txtHastaSoyad);
                _command.Parameters.AddWithValue("@p3",txtHastakimlik);
                _command.Parameters.AddWithValue("@p4",txtHastaTelefon);
                _command.Parameters.AddWithValue("@p5",combocinsiyet.Text);
                _command.ExecuteNonQuery();
                MessageBox.Show("\tBilgilerinizi Başarıyla Güncellenmiştir!", "[Bilgilendirme]", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlTypeException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Bir hata oluşmuştur.Lütfen Bilgileriniz kontrol ve tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Bir hata oluşmuştur.Lütfen Bilgileriniz kontrol ve tekrar deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               SqlConnecteur.GetConnection().Close();
            }
        }

    }
}
