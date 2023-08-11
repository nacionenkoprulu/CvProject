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
    public partial class KisiGuncelle : Form
    {
        int _mevcutId;
        CvliteDbContext _db = new CvliteDbContext();
        KisiService _kisiService = new KisiService();
        public KisiGuncelle(int id)
        {
            InitializeComponent();
            _mevcutId = id;
        }

        private void KisiGuncelle_Load(object sender, EventArgs e)
        {
            CinsiyetListesiniDoldur();
            UlkeDoldur();

            KişiDetayGetir();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            KisiDTO _guncellenecekKisi = KisiOlustur();

            if (_guncellenecekKisi == null)
            {
                MessageBox.Show("Kişi güncellenemedi!");
                return;
            }
            Guncelle(_guncellenecekKisi);
            MessageBox.Show("Kişi başarıyla güncellendi!");
        }

        public KisiDTO KisiOlustur()
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

            return new KisiDTO
            {
                Id = _mevcutId,
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


        private void KişiDetayGetir()
        {
            KisiDTO _mevcutKisi = _kisiService.Sorgula().SingleOrDefault(k => k.Id == _mevcutId);

            if (_mevcutKisi == null)
            {
                MessageBox.Show("Kişi bulunamadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            tbAd.Text = _mevcutKisi.Adi;
            tbSoyad.Text = _mevcutKisi.Soyadi;
            tbKimlikNo.Text = _mevcutKisi.KimlikNo;
            ddlCinsiyet.SelectedIndex = _mevcutKisi.Cinsiyeti == (int)Cinsiyet.Kadın ? 1 : 0;
            dtpDogumTarihi.Value = _mevcutKisi.DogumTarihi;

            ddlUlke.SelectedValue = _mevcutKisi.UlkeId is null ? -1 : _mevcutKisi.UlkeId;

            if (_mevcutKisi.UlkeId.HasValue)
                SehirDoldur(_mevcutKisi.UlkeId.Value);
            else
                SehirDoldur();

            ddlSehir.SelectedValue = _mevcutKisi.SehirId is null ? -1 : _mevcutKisi.SehirId;
            rtbBiyografi.Text = _mevcutKisi?.Biyografi;
        }

        private void Guncelle(KisiDTO kisi)
        {
            _kisiService.Guncelle(kisi);
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




    }
}

