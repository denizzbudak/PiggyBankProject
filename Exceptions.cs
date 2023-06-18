using System;

namespace KumbaraUygulamasi
{
    public class KumbaraKapandiException : Exception
    {
        public KumbaraKapandiException() : base("Kumbara kırıldıktan sonra tekrar kullanılamaz.") { }
    }

    public class KumbaraHacmiDolduException : Exception
    {
        public KumbaraHacmiDolduException() : base("Kumbara dolduğu için para atamazsınız.") { }
    }

    public class KumbaraKirildiException : Exception
    {
        public KumbaraKirildiException() : base("Kumbara zaten kırılmış durumda.") { }
    }

    public class ParaSecilmediException : Exception
    {
        public ParaSecilmediException() : base("Lütfen para seçiniz.") { }
    }
}
