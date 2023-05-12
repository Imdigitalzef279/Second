using System;
using System.Collections.Generic;

namespace Second.Models;

public partial class SinhVien
{
    public int Id { get; set; }

    public string HoVaTen { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public long? IdChucVu { get; set; }
}
