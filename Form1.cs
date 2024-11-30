using HastanYonetim_RandevuSistem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastanYonetim_RandevuSistem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            HastaGirisPaneli hastaGirisPaneli = new HastaGirisPaneli();
            this.Hide();
            hastaGirisPaneli.ShowDialog();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorgirispanel=new DoktorGiris(); 
            this.Hide();    
            doktorgirispanel.Show();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            SekreterGiris sekreter=new SekreterGiris();
            this.Hide();
            sekreter.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
