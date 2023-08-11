using CvProject.Contexts;
using CvProject.DTO;
using CvProject.Entities;
using CvProject.Enums;
using CvProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CvProject
{
    public partial class KisiEkleForm : Form
    {

        CvliteDbContext _db = new CvliteDbContext();
        KisiService _kisiService = new KisiService();
        public KisiEkleForm()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Ekle()
        {
            KisiDTO kisi = kisiOlustur();

            if (kisi == null)
            {
                MessageBox.Show("Kişi eklenirken bir hata oluştu!");
                return;
            }

            _kisiService.Ekle(kisi);
            MessageBox.Show("Kişi başarıyla eklendi!");
        }

        public KisiDTO kisiOlustur()
        {
            if (string.IsNullOrWhiteSpace(tbAd.Text))
            {
                MessageBox.Show("İsim boş olamaz!");
                return null;
            }

            if (string.IsNullOrWhiteSpace(tbSoyad.Text))
            {
                MessageBox.Show("Soyad boş olamaz!");
                return null;
            }


            if (string.IsNullOrWhiteSpace(tbKimlikNo.Text))
            {
                MessageBox.Show("Kimlik No boş olamaz!");
                return null;
            }
            else if (tbKimlikNo.Text.Length is > 11 or < 11)
            {
                MessageBox.Show("Kimlik No 11 haneden oluşmak zorundadır!");
                return null;
            }

            if (ddlCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Cinsiyet seçmek zorundasınız!");
                return null;
            }


            return new KisiDTO()
            {
                Adi = tbAd.Text,
                Soyadi = tbSoyad.Text,
                KimlikNo = tbKimlikNo.Text,

                Cinsiyeti = ddlCinsiyet.SelectedIndex,
                DogumTarihi = dtpDogumTarihi.Value,
                UlkeId = Convert.ToInt32(ddlUlke.SelectedValue),
                SehirId = Convert.ToInt32(ddlSehir.SelectedValue),
                Biyografi = rtbBiyografi.Text
            };

        }


        public void UlkeDoldur()
        {

            List<Ulke> ulkeler = _db.Ulkeler.ToList();

            ulkeler.Insert(0, new Ulke
            {
                Id = -1,
                Adi = "--Seçiniz--"
            });


            ddlUlke.DataSource = ulkeler;
            ddlUlke.DisplayMember = "Adi";
            ddlUlke.ValueMember = "Id";
        }


        public void SehirDoldur()
        {
            List<Sehir> sehirler = _db.Sehirler.ToList();
            sehirler.Insert(0, new Sehir
            {
                Id = -1,
                Adi = "--Seçiniz--"
            });

            ddlSehir.DataSource = sehirler;
            ddlSehir.DisplayMember = "Adi";
            ddlSehir.ValueMember = "Id";

        }

        public void SehirDoldur(int ulkeId)
        {
            List<Sehir> sehirler = _db.Sehirler.Where(s => s.UlkeId == ulkeId).ToList();
            sehirler.Insert(0, new Sehir
            {
                Id = -1,
                Adi = "--Seçiniz--"
            });

            ddlSehir.DataSource = sehirler;
            ddlSehir.DisplayMember = "Adi";
            ddlSehir.ValueMember = "Id";

        }

        void CinsiyetListesiniDoldur()
        {
            ddlCinsiyet.Items.Add(Cinsiyet.Kadın.ToString());
            ddlCinsiyet.Items.Add(Cinsiyet.Erkek.ToString());
            ddlCinsiyet.SelectedIndex = 0;
        }

        private void KisiEkleForm_Load(object sender, EventArgs e)
        {
            UlkeDoldur();
            CinsiyetListesiniDoldur();
        }

        private void ddlUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlUlke.SelectedIndex > 0)
                SehirDoldur(Convert.ToInt32(ddlUlke.SelectedValue));
            else
                SehirDoldur();
        }
    }
}
