using System;
using System.Collections.Generic;

namespace Second.Models;

public partial class Lop
{
    public int Id { get; set; }

    public string LoaiLop { get; set; } = null!;

    public int SoGhe { get; set; }

    public int SoBan { get; set; }
}
