using System;
using System.Collections.Generic;

namespace CvProject.Entities;

public partial class Kisi
{
    public int Id { get; set; }

    public int? UlkeId { get; set; }

    public int? SehirId { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadi { get; set; } = null!;

    public DateTime DogumTarihi { get; set; }

    public int Cinsiyeti { get; set; }

    public string KimlikNo { get; set; } = null!;

    public string? Biyografi { get; set; }

    public List<KisiIs> KisiIsler { get; set; } = new List<KisiIs>();

    public Sehir? Sehir { get; set; }

    public Ulke? Ulke { get; set; }
}
