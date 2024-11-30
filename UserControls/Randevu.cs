using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem.UserControls
{
    public partial class Randevu : UserControl
    {
        public Randevu()
        {
            InitializeComponent();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAlma randevuAlma = new RandevuAlma();
            panelContainerListRandevu.Controls.Clear();
            panelContainerListRandevu.Controls.Add(randevuAlma);
            randevuAlma.Dock = DockStyle.Fill;  
           
        }

        private void BtnRandevuAl0_Click(object sender, EventArgs e) => BtnRandevuAl_Click((object)sender, e);

        private void BtnGecmisRandevu_Click(object sender, EventArgs e)
        {
            GesmisRandevu randevuGesmis = new GesmisRandevu();
            panelContainerListRandevu.Controls.Clear();
            panelContainerListRandevu.Controls.Add(randevuGesmis);
            randevuGesmis.Dock = DockStyle.Fill;


        }

        private void BtnGecmisRandevu0_Click(object sender, EventArgs e)=> BtnGecmisRandevu_Click((object)sender, e);

        private void BtnAktifRandevu_Click(object sender, EventArgs e)
        {
            AktifRandevu randevuaktif = new AktifRandevu();
            panelContainerListRandevu.Controls.Clear();
            panelContainerListRandevu.Controls.Add(randevuaktif);
            randevuaktif.Dock = DockStyle.Fill;
        }

        private void BtnAktifRandevu0_Click(object sender, EventArgs e)=>BtnAktifRandevu_Click((object)sender, e);

     
    }
}
