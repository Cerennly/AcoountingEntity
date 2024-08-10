using System;
using System.Collections.Generic;

namespace deneme.Entity;

public partial class StokH
{
    public int Id { get; set; }

    public string? FaturaKodu { get; set; }

    public string? Hareket { get; set; }

    public string? StokKodu { get; set; }

    public string? StokAdi { get; set; }

    public string? Birimi { get; set; }

    public decimal? Miktari { get; set; }

    public int? Kdv { get; set; }

    public decimal? IndirimOrani { get; set; }

    public decimal? IndirimTutari { get; set; }

    public decimal? ToplamTutari { get; set; }

    public string? Aciklama { get; set; }
}
