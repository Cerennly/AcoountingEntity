using System;
using System.Collections.Generic;

namespace deneme.Entity;

public partial class Cari
{
    public string? Id { get; set; }

    public bool? Durum { get; set; }

    public string? CariTuru { get; set; }

    public string? CariKodu { get; set; }

    public string? CariAdi { get; set; }

    public string? FaturaUnvani { get; set; }

    public string? Adres { get; set; }

    public decimal? IskontoOrani { get; set; }

    public string? VergiNo { get; set; }

    public string? AlisOzelFiyati { get; set; }

    public string? SatisOzelFiyati { get; set; }

    public string? Aciklama { get; set; }
}
