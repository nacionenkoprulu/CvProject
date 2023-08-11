using System;
using System.Collections.Generic;

namespace CvProject.Entities;

public partial class Is
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string? Aciklamasi { get; set; }

    public double? HaftalikCalismaSaati { get; set; }

    public List<KisiIs> KisiIsler { get; set; } = new List<KisiIs>();
}
