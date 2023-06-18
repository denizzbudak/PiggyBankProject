namespace KumbaraUygulamasi
{
    public class Banknote : Para
    {
  
        public Banknote(string adi, decimal deger, ParaTuru paraTuru, double en, double boy, double yukseklik) : base(adi, deger, paraTuru, en, boy, yukseklik)
        {
            En = en;
            Boy = boy;
            Yukseklik = yukseklik;

        }

        protected override double HesaplaHacimInternal()
        {
           return Hacim = En * Boy * Yukseklik;
        }

        public void Katlan()
        {
            Boy /= 4;
            Yukseklik *= 4;
            HesaplaHacim();
        }
    }
}
