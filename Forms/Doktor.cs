using HastanYonetim_RandevuSistem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.Forms
{
    public partial class Doktor : Form
    {
        public static string TCfromGiris { get; internal set; }
        public string AdSoyad {  get; internal set; }
        private DoktorBilgiDuzenle bilgiDuzenle;

        private DoktorBilgileri doktorbilgi;

        private DoktorRandevuDetaylarcs randevudetay;
        public Doktor()
        {
            InitializeComponent();
        }
        private void Doktor_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TCfromGiris;
            lblAdSoyad.Text = AdSoyad;
        }
       

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DoktorGiris doktor = new DoktorGiris();
            doktor.Show();
            this.Close();
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
             bilgiDuzenle = new DoktorBilgiDuzenle();
            panelLayout.Controls.Clear();
            panelLayout.Controls.Add(bilgiDuzenle);
            bilgiDuzenle.Dock = DockStyle.Fill;
        }
        private void BtnDuzenle_Click(object sender, EventArgs e) => BtnBilgiDuzenle_Click(sender, e);

        private void BtnBilgi_Click(object sender, EventArgs e)
        {
             doktorbilgi= new DoktorBilgileri();
             panelLayout.Controls.Clear();
             panelLayout.Controls.Add(doktorbilgi);
             doktorbilgi.Dock = DockStyle.Fill;  
        }
        private void BtnBilgilerim_Click(object sender, EventArgs e) => BtnDuzenle_Click(sender,e);

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            DoktorDuyurular duyurular = new DoktorDuyurular();
            panelLayout.Controls.Clear();
            panelLayout.Controls.Add(duyurular);
            duyurular.Dock = DockStyle.Fill;
        }

        private void BtnDuyuru_Click(object sender, EventArgs e) => BtnDuyurular_Click((object)sender, e);

        private void BtnRandevuDetail_Click(object sender, EventArgs e)
        {
             randevudetay = new DoktorRandevuDetaylarcs();
             panelLayout.Controls.Clear();
             panelLayout.Controls.Add(randevudetay);
             randevudetay.Dock = DockStyle.Fill;
        }
        private void BtnRandevu_Click(object sender, EventArgs e) => BtnRandevuDetail_Click((object)sender, e);

    }
}
