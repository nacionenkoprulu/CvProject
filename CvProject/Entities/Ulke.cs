using System;
using System.Collections.Generic;

namespace CvProject.Entities;

public partial class Ulke
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public List<Kisi> Kisiler { get; set; } = new List<Kisi>();

    public List<Sehir> Sehirler { get; set; } = new List<Sehir>();
}
