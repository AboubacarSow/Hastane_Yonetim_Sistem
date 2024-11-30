using HastanYonetim_RandevuSistem.Models;
using System;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.Forms
{
    public partial class HastaKayitForm : Form
    {
             
     
        private SqlCommand command;
        private int result;
        public HastaKayitForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                string columns = "(PatientName,PatientLastName,Patient_TC,PhoneNumber,Sifre,Gendre)";
                string query = $"insert into Patients {columns} values(@name,@lastname,@tc,@telefon,@sifre,@cinsiyet)";
              
                command = new SqlCommand(query, SqlConnecteur.GetConnection());
                command.Parameters.AddWithValue("@name",txtHastaAd.Text);
                command.Parameters.AddWithValue("@lastname",txtHastaSoyad.Text);
                command.Parameters.AddWithValue("@tc",txtHastakimlik.Text);
                command.Parameters.AddWithValue("@telefon",txtHastaTelefon.Text);
                command.Parameters.AddWithValue("@sifre",txtHastasifre.Text);
                command.Parameters.AddWithValue("@cinsiyet",comboCinsiyet.SelectedItem.ToString());
                string text=comboCinsiyet.Text;
                result= command.ExecuteNonQuery();
            }
            catch(SqlTypeException ex)
            { 
                 MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 MessageBox.Show("Bir hata oluşmuştur.Lütfen Bilgileriniz kontrol ve tekrar deneyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            catch(Exception ex)
            {
                 MessageBox.Show(ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                 MessageBox.Show("Bir hata oluşmuştur.Lütfen Bilgileriniz kontrol ve tekrar deneyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            finally
            { 
               SqlConnecteur.GetConnection().Close();   
                RedirectToHasta(result);
            }              
     


        }
        public void RedirectToHasta( int result)
        {

             if(result == 1)
             {
                MessageBox.Show("Kaydınız Başarıyla Gerçekleştirilmiştir","[Bilgilendirme]",MessageBoxButtons.OK, MessageBoxIcon.Information);  
                MessageBox.Show($"Giriş Paneline Geri dönüş yapınız. \n\n\t Şifrenizi:{txtHastasifre.Text}","[Bilgilendirme]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
             }
        }
    }
}
