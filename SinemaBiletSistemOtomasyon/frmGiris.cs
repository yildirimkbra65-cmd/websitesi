using System;
using System.Windows.Forms;

namespace SinemaBiletSistemOtomasyon
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

      
        private void FilmSec(string ad, string yol)
        {
            frmBiletSatis satisFormu = new frmBiletSatis();
            satisFormu.secilenFilmAdi = ad;
            satisFormu.secilenFilmAfisi = yol;
            satisFormu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e) { FilmSec("Siccin 8", @"C:\SinemaResimleri\Siccin.jpg"); }
        private void button2_Click(object sender, EventArgs e) { FilmSec("Oppenheimer", @"C:\SinemaResimleri\Oppenheimer.jpg"); }
        private void button3_Click(object sender, EventArgs e) { FilmSec("Hoplayanlar", @"C:\SinemaResimleri\hoplayanlar.jpeg"); }
        private void button4_Click(object sender, EventArgs e) { FilmSec("Dune", @"C:\SinemaResimleri\Dune.jpg"); }
        private void button5_Click(object sender, EventArgs e) { FilmSec("Momo: Büyük Takip", @"C:\SinemaResimleri\Momo.jpg"); }
        private void button6_Click(object sender, EventArgs e) { FilmSec("Thor", @"C:\SinemaResimleri\Thor.jpg"); }
        private void button7_Click(object sender, EventArgs e) { FilmSec("Sihirli Annem: Periler Okulu", @"C:\SinemaResimleri\SihirliAnnem.jpg"); }
        private void button8_Click(object sender, EventArgs e) { FilmSec("Yan Yana", @"C:\SinemaResimleri\YanYana.jpg"); }
        private void button9_Click_1(object sender, EventArgs e) { FilmSec("Kardeşler Araştırma", @"C:\SinemaResimleri\kardesler-arastirma-1772079512_225x336.jpg"); }
        private void button10_Click(object sender, EventArgs e) { FilmSec("Çatlı", @"C:\Users\ustu\Desktop\catli-202631012327ba58568c1af541fa810422e.jpg"); }

        
        private void frmGiris_Load(object sender, EventArgs e) { }
        private void button1_MouseEnter(object sender, EventArgs e) { }
        private void button1_MouseLeave(object sender, EventArgs e) { }
        private void button6_MouseEnter(object sender, EventArgs e) { }
        private void button6_MouseLeave(object sender, EventArgs e) { }
        private void pctDune_Click(object sender, EventArgs e) { }
        private void pctDune_MouseEnter(object sender, EventArgs e) { }
        private void pctDune_MouseLeave(object sender, EventArgs e) { }
        private void pctHoplayanlar_Click(object sender, EventArgs e) { }
        private void pctHoplayanlar_MouseEnter(object sender, EventArgs e) { }
        private void pctHoplayanlar_MouseLeave(object sender, EventArgs e) { }
        private void pctKardeslerAraştırma_MouseEnter(object sender, EventArgs e) { }
        private void pctKardeslerAraştırma_MouseLeave(object sender, EventArgs e) { }
        private void pctSihirliAnnem_Click(object sender, EventArgs e) { }
        private void pctSihirliAnnem_MouseEnter(object sender, EventArgs e) { }
        private void pctSihirliAnnem_MouseLeave(object sender, EventArgs e) { }
        private void pctThor_Click(object sender, EventArgs e) 
        {

        }
        private void pctThor_MouseEnter(object sender, EventArgs e) { }
        private void pctThor_MouseLeave(object sender, EventArgs e) { }
        private void pctMomo_Click(object sender, EventArgs e) { }
        private void pctCatli_Click(object sender, EventArgs e) { }
        private void pctCatli_MouseEnter(object sender, EventArgs e) { }
        private void pctCatli_MouseLeave(object sender, EventArgs e) { }
        private void pctOppenheimer_Click(object sender, EventArgs e) { }
        private void pctOppenheimer_MouseEnter(object sender, EventArgs e) { }
        private void pctOppenheimer_MouseLeave(object sender, EventArgs e) { }
        private void pctSiccin_Click(object sender, EventArgs e) { }
        private void pctSiccin_MouseEnter(object sender, EventArgs e) { }
        private void pctSiccin_MouseLeave(object sender, EventArgs e) { }
        private void pctYanyana_Click(object sender, EventArgs e) { }
        private void pctYanyana_MouseEnter(object sender, EventArgs e) { }
        private void pctYanyana_MouseLeave(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button9_Click(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void timer1_Tick(object sender, EventArgs e) { }
    }
}