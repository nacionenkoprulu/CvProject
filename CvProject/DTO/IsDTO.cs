using System.ComponentModel;

namespace CvProject.DTO
{
    public class IsDTO
    {

        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Adı")]
        public string Adi { get; set; }

        [DisplayName("Haftalık Çalışma Saati")]
        public string HaftalikCalismaSaati { get; set; }

        [DisplayName("Açıklaması")]
        public string Aciklamasi { get; set; }



    }
}
