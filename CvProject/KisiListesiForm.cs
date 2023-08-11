using CvProject.DTO;
using CvProject.Service;
using System.Windows.Forms;

namespace CvProject
{
    public partial class KisiListesiForm : Form
    {

        KisiService _kisiService = new KisiService();


        public KisiListesiForm()
        {
            InitializeComponent();
        }


        private void KisiListesiForm_Load(object sender, EventArgs e)
        {
            KisileriDoldur();
            SutunlariDuzenle();
        }

        public void KisileriDoldur()
        {
            List<KisiDTO> kisiler = _kisiService.Sorgula().ToList();

            dgvKisiler.DataSource = kisiler;

        }

        public void SutunlariDuzenle()
        {
            dgvKisiler.Columns["Id"].Width = 50;
            dgvKisiler.Columns["DogumTarihiGosterim"].Width = 125;
            dgvKisiler.Columns["AdSoyadGosterim"].Width = 175;
            dgvKisiler.Columns["DogumTarihiGosterim"].Width = 125;
            dgvKisiler.Columns["UlkeSehirGosterim"].Width = 175;
            dgvKisiler.Columns["CinsiyetGosterim"].Width = 73;
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            dgvKisiler.DataSource = null;
            KisileriDoldur();
            SutunlariDuzenle();
        }


        private void dgvKisiler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvKisiler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen kiþi seçiniz!");
                return;
            }
            int id = Convert.ToInt32(dgvKisiler.SelectedRows[0].Cells["Id"].Value);

            KisiDetayForm form = new KisiDetayForm(id);

            form.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvKisiler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen kiþi seçiniz!");
                return;
            }
            int id = Convert.ToInt32(dgvKisiler.SelectedRows[0].Cells["Id"].Value);

            KisiGuncelle form = new KisiGuncelle(id);

            form.Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            KisiEkleForm form = new KisiEkleForm();

            form.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt32(dgvKisiler.SelectedRows[0].Cells["Id"].Value);

            _kisiService.Sil(secilenID);

            MessageBox.Show("Kiþi baþarýyla Silindi!");
        }
    }
}