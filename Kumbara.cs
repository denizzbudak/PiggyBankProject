using System;
using System.Collections.Generic;

namespace KumbaraUygulamasi
{
    public class Kumbara
    {
        private const int MAX_HACIM = 10000;

        private List<Para> paralar;
        private bool kumbaraKapandi;

        public double sonHacim { get; private set; }

        public decimal Bakiye { get; private set; }

        public Kumbara()
        {
            paralar = new List<Para>();
            kumbaraKapandi = false;
        }

        public void ParaEkle(Para para)
        {
            double paraHacim = para.HesaplaHacim();
            if (sonHacim + paraHacim > MAX_HACIM)
            {
                throw new KumbaraHacmiDolduException();
            }

            paralar.Add(para);
            Bakiye += para.Deger;
            sonHacim += paraHacim;
        }

        public void KumbaraKir()
        {
            if (!kumbaraKapandi)
            {
                kumbaraKapandi = true;
                paralar.Clear();
                Bakiye = 0;
                sonHacim = 0;
            }
            else
            {
                throw new KumbaraKirildiException();
            }
        }



        public bool IsKumbaraKapandi()
        {
            return kumbaraKapandi;
        }


    }
}
