namespace KumbaraUygulamasi
{
    public abstract class Para
    {
        public string Adi { get; }
        public decimal Deger { get; }
        public ParaTuru ParaTuru { get; }
        public double En { get; protected set; }
        public double Boy { get; protected set; }
        public double Yukseklik { get; protected set; }
        public double Hacim { get; set; }

        public Para(string adi, decimal deger, ParaTuru paraTuru, double en, double boy, double yukseklik)
        {
            Adi = adi;
            Deger = deger;
            ParaTuru = paraTuru;
            En = en;
            Boy = boy;
            Yukseklik = yukseklik;
            HesaplaHacim();
        }

        public double HesaplaHacim()
        {
            Hacim = HesaplaHacimInternal();
            System.Console.WriteLine(Hacim);
            return Hacim;
        }

        protected abstract double HesaplaHacimInternal();
    }
}
