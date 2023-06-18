

namespace KumbaraUygulamasi
{
    public class Coin : Para
    {
        private const double PI_SABITI = 3.14159; // Pi sayısı sabiti

        public Coin(string adi, decimal deger, ParaTuru paraTuru, double cap, double kalinlik) : base(adi, deger, paraTuru, cap, cap, kalinlik)
        {
            En = cap;
            HesaplaHacim();
        }

        protected override double HesaplaHacimInternal()
        {
           return PI_SABITI * (En / 2) * (En / 2) * Yukseklik;
        }

    }
}