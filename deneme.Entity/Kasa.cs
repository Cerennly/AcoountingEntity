using System;
using System.Collections.Generic;

namespace deneme.Entity;

public partial class Kasa
{
    public int? Id { get; set; }

    public string? FaturaKodu { get; set; }

    public string? Hareket { get; set; }

    public string? OdemeTuruKodu { get; set; }

    public string? CariKodu { get; set; }

    public string? CariAdi { get; set; }

    public DateOnly? Tarih { get; set; }

    public decimal? Tutar { get; set; }

    public string? Aciklama { get; set; }
}
