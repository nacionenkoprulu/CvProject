using System;
using System.Collections.Generic;

namespace CvProject.Entities;

public partial class Sehir
{
    public int Id { get; set; }

    public int UlkeId { get; set; }

    public string Adi { get; set; } = null!;

    public List<Kisi> Kisiler { get; set; } = new List<Kisi>();

    public Ulke Ulke { get; set; } = null!;
}
