using System;
using System.Collections.Generic;

namespace deneme.Entity;

public partial class Fatura
{
    public int Id { get; set; }

    public string? FaturaKodu { get; set; }

    public string? CariTuru { get; set; }

    public string? CariKodu { get; set; }

    public string? CariAdi { get; set; }

    public DateOnly? Tarih { get; set; }

    public decimal? IskontoOrani { get; set; }

    public decimal? IskontoTutari { get; set; }

    public decimal? ToplamTutar { get; set; }

    public string? Aciklama { get; set; }
}
