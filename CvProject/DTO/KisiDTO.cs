using CvProject.Entities;
using CvProject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvProject.DTO
{
    public class KisiDTO
    {
        #region ENTITYDEN GELENLER

        [DisplayName("ID")]
        public int Id { get; set; }

        [Browsable(false)]
        public int? UlkeId { get; set; }

        [Browsable(false)]
        public int? SehirId { get; set; }

        [Browsable(false)]
        public string Adi { get; set; } = null!;

        [Browsable(false)]
        public string Soyadi { get; set; } = null!;

        [Browsable(false)]
        public DateTime DogumTarihi { get; set; }

        [Browsable(false)]
        public int Cinsiyeti { get; set; }

        [DisplayName("Kimlik No")]
        public string KimlikNo { get; set; } = null!;

        [Browsable(false)]
        public string? Biyografi { get; set; }

        [Browsable(false)]
        public List<KisiIs> KisiIsler { get; set; } = new List<KisiIs>();

        [Browsable(false)]
        public Sehir? Sehir { get; set; }

        [Browsable(false)]
        public Ulke? Ulke { get; set; }

        #endregion

        #region İHTİYAÇ OLANLAR

        [DisplayName("Ad Soyad")]
        public string AdSoyadGosterim { get; set; }

        [DisplayName("Konum-Lokasyon")]
        public string UlkeSehirGosterim { get; set; }

        [DisplayName("Doğum Tarihi")]
        public string DogumTarihiGosterim { get; set; }

        [DisplayName("Cinsiyet")]
        public Cinsiyet CinsiyetGosterim { get; set; }
        
        #endregion



    }
}
