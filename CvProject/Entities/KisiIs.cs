using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvProject.Entities;

public class KisiIs
{
    [Key]
    [Column(Order = 0)]
    public int KisiId { get; set; }

    [Key]
    [Column(Order = 1)]
    public int IsId { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public Is Is { get; set; } = null!;

    public Kisi Kisi { get; set; } = null!;
}
