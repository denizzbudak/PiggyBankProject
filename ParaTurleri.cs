using System;
using System.Collections.Generic;

public enum ParaTuru
{
    BesKurus,
    OnKurus,
    YirmiBesKurus,
    ElliKurus,
    BirTL,
    BesTL,
    OnTL,
    YirmiTL,
    ElliTL,
    YuzTL,
    IkiYuzTL
}

public static class ParaTuruBilgileri
{
    public static readonly Dictionary<ParaTuru, (double en, double boy, double yukseklik, bool katlanabilirMi)> Boyutlar = new Dictionary<ParaTuru, (double, double, double, bool)>()
    {
        { ParaTuru.BesKurus, (18, 18, 1.45, false) },
        { ParaTuru.OnKurus, (20, 20, 1.65, false) },
        { ParaTuru.YirmiBesKurus, (22, 22, 1.85, false) },
        { ParaTuru.ElliKurus, (24, 24, 2.05, false) },
        { ParaTuru.BirTL, (26, 26, 2.25, false) },
        { ParaTuru.BesTL, (64, 130, 0.25, true) },
        { ParaTuru.OnTL, (64, 136, 0.25, true) },
        { ParaTuru.YirmiTL, (68, 142, 0.25, true) },
        { ParaTuru.ElliTL, (68, 148, 0.25, true) },
        { ParaTuru.YuzTL, (72, 154, 0.25, false) },
        { ParaTuru.IkiYuzTL, (72, 160, 0.25, false) }
    };


    public static decimal GetDeger(ParaTuru paraTuru)
        {
            switch (paraTuru)
            {
                case ParaTuru.BesKurus:
                    return 0.05m;
                case ParaTuru.OnKurus:
                    return 0.10m;
                case ParaTuru.YirmiBesKurus:
                    return 0.25m;
                case ParaTuru.ElliKurus:
                    return 0.50m;
                case ParaTuru.BirTL:
                    return 1.00m;
                case ParaTuru.BesTL:
                    return 5.00m;
                case ParaTuru.OnTL:
                    return 10.00m;
                case ParaTuru.YirmiTL:
                    return 20.00m;
                case ParaTuru.ElliTL:
                    return 50.00m;
                case ParaTuru.YuzTL:
                    return 100.00m;
                case ParaTuru.IkiYuzTL:
                    return 200.00m;
                default:
                    throw new ArgumentOutOfRangeException(nameof(paraTuru), "Para türü bulunamadı.");
            }
        }
    }
