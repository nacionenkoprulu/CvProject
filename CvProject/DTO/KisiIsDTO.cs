using CvProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvProject.DTO
{
    public class KisiIsDTO
    {     
        public int KisiId { get; set; }

        public int IsId { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime? BitisTarihi { get; set; }

        public Is Is { get; set; } = null!;

        public Kisi Kisi { get; set; } = null!;

    }
}
