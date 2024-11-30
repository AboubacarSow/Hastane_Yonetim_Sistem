using HastanYonetim_RandevuSistem.UserControls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HastanYonetim_RandevuSistem.Forms
{
    public partial class Hasta : Form
    {
        public static string TCfromGiris {  get; set; }
        private Bilgilerim bilgilerim { get; set; }
        private Randevu randevu { get; set; }   
        private BilgiDuzenle bilgiDuzenle {  get; set; }    
        public Hasta()
        {
            InitializeComponent();
        }
        private void Hasta_Load_1(object sender, EventArgs e)
        {
            lblTCNo.Text= TCfromGiris;
            Bilgilerim bilgilerim = new Bilgilerim();
            panelContainerLayout.Controls.Clear();
            panelContainerLayout.Controls.Add(bilgilerim);
            lblAdSoyad.Text = bilgilerim.AdSoyad.ToUpper();
            bilgilerim.Dock = DockStyle.Fill;
        }
       

        private void BtnBilgi_Click(object sender, EventArgs e)
        {
            bilgilerim = new Bilgilerim();
            panelContainerLayout.Controls.Clear();
            panelContainerLayout.Controls.Add(bilgilerim);
            bilgilerim.Dock= DockStyle.Fill;
        }

        private void BtnBilgi0_Click(object sender, EventArgs e)=> BtnBilgi_Click((object)sender, e);

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            randevu = new Randevu();
            panelContainerLayout.Controls.Clear();  
            panelContainerLayout.Controls.Add(randevu);
            randevu.Dock= DockStyle.Fill;   
        }

        private void BtnRandevu0_Click(object sender, EventArgs e)=>BtnRandevu_Click((object)sender, e);

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            HastaGirisPaneli girisPaneli = new HastaGirisPaneli();
            this.Hide();
            girisPaneli.Show();
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            bilgiDuzenle = new BilgiDuzenle();
            panelContainerLayout.Controls.Clear();
            panelContainerLayout.Controls.Add(bilgiDuzenle);
            bilgiDuzenle.Dock = DockStyle.Fill;
        }
    }
}
