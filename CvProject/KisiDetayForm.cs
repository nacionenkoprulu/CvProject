using CvProject.Contexts;
using CvProject.DTO;
using CvProject.Entities;
using CvProject.Enums;
using CvProject.Service;

namespace CvProject
{
    public partial class KisiDetayForm : Form
    {
        int _mevcutId;

        KisiService _kisiService = new KisiService();
        CvliteDbContext _db = new CvliteDbContext();
        public KisiDetayForm(int id)
        {
            InitializeComponent();

            _mevcutId = id;
        }

        private void KisiDetayForm_Load(object sender, EventArgs e)
        {
            UlkeDoldur();
            SehirDoldur();
            CinsiyetListesiniDoldur();
            KişiDetayGetir();

        }

        private void KişiDetayGetir()
        {
            KisiDTO _mevcutKisi = _kisiService.Sorgula().SingleOrDefault(k => k.Id == _mevcutId);

            if (_mevcutKisi == null)
            {
                MessageBox.Show("Kişi bulunamadı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            tbIsim.Text = _mevcutKisi.AdSoyadGosterim;
            tbKimlikNo.Text = _mevcutKisi.KimlikNo;
            ddlCinsiyet.SelectedIndex = _mevcutKisi.Cinsiyeti == (int)Cinsiyet.Kadın ? 0 : 1;
            ddlUlke.SelectedValue = _mevcutKisi.UlkeId is null ? -1 : _mevcutKisi.UlkeId;
            dtpDogumTarihi.Value = _mevcutKisi.DogumTarihi;
            ddlSehir.SelectedValue = _mevcutKisi.SehirId is null ? -1 : _mevcutKisi.SehirId;
            rtbBiyografi.Text = _mevcutKisi?.Biyografi;


            List<IsDTO> isList = _mevcutKisi.KisiIsler.Select(kis => new IsDTO
            {
                Id = kis.IsId,
                Adi = kis.Is.Adi + " (" + kis.BaslangicTarihi.ToString("dd.MM.yyyy") + " - " +
                    (kis.BitisTarihi.HasValue ? kis.BitisTarihi.Value.ToString("dd.MM.yyyy") : "...") + ")"
            }).ToList();

            if (isList != null && isList.Count > 0)
            {
                foreach (var item in isList)
                {
                    lbKisiIs.Items.Add(item);
                }
            }
        }

        void CinsiyetListesiniDoldur()
        {
            ddlCinsiyet.Items.Add(Cinsiyet.Kadın.ToString());
            ddlCinsiyet.Items.Add(Cinsiyet.Erkek.ToString());
            ddlCinsiyet.SelectedIndex = 0;
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
    }
}
