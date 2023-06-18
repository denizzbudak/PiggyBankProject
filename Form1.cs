using System;
using System.Globalization;
using System.Windows.Forms;

namespace KumbaraUygulamasi
{
    public partial class MainForm : Form
    {
        private Kumbara kumbara;

        public MainForm()
        {
            InitializeComponent();
            kumbara = new Kumbara();
            FillParaTuruComboBox();
            UpdateKumbaraStatus();
            UpdateKumbaraHacimStatus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateKumbaraStatus();
            UpdateKumbaraHacimStatus();
        }

        private void UpdateKumbaraStatus()
        {
            kumbaraStatusLabel.Text = $"{kumbara.Bakiye.ToString("C", CultureInfo.GetCultureInfo("tr-TR"))}";
        }

        private void UpdateKumbaraHacimStatus()
        {
            sonHacim.Text = $"Kalan Hacim: {(10000-kumbara.sonHacim).ToString("N3")} mm³";
        }


        private void FillParaTuruComboBox()
        {
            paraTuruComboBox.Items.Clear();
            foreach (ParaTuru paraTuru in Enum.GetValues(typeof(ParaTuru)))
            {
                paraTuruComboBox.Items.Add(paraTuru);
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (kumbara.IsKumbaraKapandi())
                {
                    throw new KumbaraKapandiException();
                }

                Para para;
                if (paraTuruComboBox.SelectedItem == null)
                {
                    throw new ParaSecilmediException();
                }
                ParaTuru paraTuru = (ParaTuru)paraTuruComboBox.SelectedItem;
                decimal paraDegeri = ParaTuruBilgileri.GetDeger(paraTuru);
                double en = ParaTuruBilgileri.Boyutlar[paraTuru].en;
                double boy = ParaTuruBilgileri.Boyutlar[paraTuru].boy;
                double yukseklik = ParaTuruBilgileri.Boyutlar[paraTuru].yukseklik;

                if (ParaTuruBilgileri.Boyutlar[paraTuru].katlanabilirMi)
                {
                    para = new Banknote(paraTuruComboBox.SelectedItem.ToString(), paraDegeri, paraTuru, en, boy, yukseklik);
                    ((Banknote)para).Katlan();
                }
                else
                {
                    double cap = ParaTuruBilgileri.Boyutlar[paraTuru].en;
                    double kalinlik = ParaTuruBilgileri.Boyutlar[paraTuru].yukseklik;
                    para = new Coin(paraTuruComboBox.SelectedItem.ToString(), paraDegeri, paraTuru, cap, kalinlik);
                }

                kumbara.ParaEkle(para);
                UpdateKumbaraStatus();
                UpdateKumbaraHacimStatus();
                MessageBox.Show("Para kumbaraya eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (KumbaraKapandiException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!kumbara.IsKumbaraKapandi())
            {
                MessageBox.Show($"Kumbara kırıldı. {kumbara.Bakiye.ToString()} Liran var.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kumbara.KumbaraKir();
                UpdateKumbaraStatus();
                UpdateKumbaraHacimStatus();

            }
            else
            {
                MessageBox.Show("Kumbara zaten kırılmış durumda.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
