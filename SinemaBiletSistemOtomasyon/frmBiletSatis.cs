using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace SinemaBiletSistemOtomasyon
{
    public partial class frmBiletSatis : Form

    {




        
        SqlConnection baglanti = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=SinemaDB;Integrated Security=True;TrustServerCertificate=True");

        
        public string secilenFilmAdi { get; set; }
        public string secilenFilmAfisi { get; set; }
        public static string secilenResimAdi = ""; 
        public frmBiletSatis()
        {
            InitializeComponent();
        }

        private void frmBiletSatis_Load(object sender, EventArgs e)
        {
            
            string yol = @"C:\SinemaResimleri\" + secilenResimAdi;
            if (System.IO.File.Exists(yol))
            {
                picSecilenAfis.ImageLocation = yol;
                picSecilenAfis.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            
            string sorgu = "SELECT SeansSaati FROM FilmSeanslar WHERE FilmAdi = @p1 AND SeansSaati != 'Seçilmedi'";

            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@p1", secilenFilmAdi); 

                
                if (baglanti.State == System.Data.ConnectionState.Closed)
                    baglanti.Open();

                using (SqlDataReader oku = komut.ExecuteReader())
                {
                    cmbSeanslar.Items.Clear();
                    while (oku.Read())
                    {
                        
                        if (oku["SeansSaati"] != DBNull.Value)
                        {
                            cmbSeanslar.Items.Add(oku["SeansSaati"].ToString());
                        }
                    }
                }
            }


        }


        private void btnOnaylaVeSatinAl_Click(object sender, EventArgs e)
        {
            
            frmAnaEkran koltukEkrani = new frmAnaEkran();

            
            koltukEkrani.AktarilanSeans = cmbSeanslar.Text; 

            koltukEkrani.Show();
            this.Hide();
        }


        private void btnFilmlerGeri_Click(object sender, EventArgs e)
        {
            this.Close();

            
            Form frmGirisFormu = Application.OpenForms["frmGiris"];
            if (frmGirisFormu != null)
            {
                frmGirisFormu.Show();
            }
        }

        
        private void cmbSeanslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void picSecilenAfis_Click(object sender, EventArgs e)
        {
        }

        private void lblÜcret_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOnaylaveSatınAl_Click(object sender, EventArgs e)
        {
            if (cmbSeanslar.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen önce bir seans seçiniz!");
                return;
            }

           
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Geçmiş bir tarihe bilet alamazsınız!");
                return;
            }

            
            frmAnaEkran koltukSecimFormu = new frmAnaEkran();

           
            koltukSecimFormu.AktarilanFilm = secilenFilmAdi;
            koltukSecimFormu.AktarilanSeans = cmbSeanslar.Text;

            koltukSecimFormu.Show();
            this.Hide();
        }
    }
}