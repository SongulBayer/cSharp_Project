using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_3
{
    class Urun
    {
        protected string ad; // TÜM ÜRÜNLERDE ORTAK OLAN ÖZELLİKLERİ BARINDIRAN SINIF.
        protected string marka;
        protected string model;
        public string ozellık;
        public int stokAdedi;
        public double hamFiyat;
        public int secılenAdet;
        public double KDVliFiyat;

        protected static Random RastgeleSayi = new Random(); // STOK ADEDİNİ RASTGELE BELİRLENMESİ İÇİN LUŞTURULDU.STATİC OLMASININ SEBEBİ HER DEFASINDA FARKLI BİR DEĞER ÜRETİLMESİNİN SAĞLANMASIDIR.

       
    }
    
    class BuzDolabı : Urun //URUN SINIFINDAN BUZDOLABI SINIFINA KALITIM İLE URUN SINIFINDAKİ ÖZELLİKLERİN TÜMÜNÜ ALDIK.
    {

        public String IcHacim;
        public string EnerjıSinif;
        public BuzDolabı(string AD, string MARKA, String MODEL, string OZELLIK, int HAMFİYAT, string ICHACIM, string ENERJISINIFI)//KURUCU FONKSİYONUMUZU OLUŞTURDUK.
        {
            this.IcHacim = ICHACIM;
            this.EnerjıSinif = ENERJISINIFI;
            this.ad = AD;
            this.marka = MARKA;
            this.model = MODEL;
            this.ozellık = OZELLIK;
            this.hamFiyat = HAMFİYAT;

            stokAdedi = RastgeleSayi.Next(1, 101);//BUZDOLABI STOK ADEDİNİ RASTGELE BELİRLEDİK.

            

        }
        public void KDVUYGULA()//BUZDOLABINA KDV UYGULADIK.
        {
             KDVliFiyat = hamFiyat * 1.2;//HER URUN İÇİN FARKLI KDV ORANLARI BELİRLENDİ.

        }

        //KALAN TÜM SINIFLAR İÇİN YUKARIDA ANLATILANLARIN AYNISI UYGULANDI.
    }
    class ledTV : Urun
    {
        public string EkranBoyutu;
        public string EkranCozunurlugu;
        public ledTV(string EKRANBOYUTU, string EKRANCOZUNURLUGU, string AD, string MARKA, string MODEL, string OZELLIK, int HAMFIYAT)
        {
            this.EkranBoyutu = EKRANBOYUTU;
            this.EkranCozunurlugu = EKRANCOZUNURLUGU;
            this.ad = AD;
            this.marka = MARKA;
            this.model = MODEL;
            this.ozellık = OZELLIK;
            this.hamFiyat = HAMFIYAT;

            stokAdedi = RastgeleSayi.Next(1, 101);
        }
        public void KDVUYGULA()
        {
            KDVliFiyat = hamFiyat * 1.5;

        }

    }
    class CepTel : Urun
    {
        public string DahiliHafıza;
        public String RamKapasitesi;
        public CepTel(string DAHILIHAFIZA, string RAMKAPASITESİ, string AD, string MARKA, string MODEL, string OZELLIK, double HAMFIYAT)

        {
            this.ad = AD;
            this.marka = MARKA;
            this.model = MODEL;
            this.ozellık = OZELLIK;
            this.hamFiyat = HAMFIYAT;
            this.DahiliHafıza = DAHILIHAFIZA;
            this.RamKapasitesi = RAMKAPASITESİ;

            stokAdedi = RastgeleSayi.Next(1, 101);
        }
        public void KDVUYGULA()
        {

            KDVliFiyat = hamFiyat * 1.20 ;
        }
    }
    class Laptop : Urun
    {

        string Ekranboyutu;
        string Ekrancozunurluk;
        string Dahilihafıza;
        string Ramkapasitesi;
        string Pilgucu;

        public Laptop(string EkranBoyutu, string EkranCozunurluk, string DahiliHafıza, string RamKapasitesi, string PilGucu, string AD, string MODEL, string MARKA, string OZELLIK,
            int HAMFIYAT)
        {
            this.Ekranboyutu = EkranBoyutu;
            this.Ekrancozunurluk = EkranCozunurluk;
            this.Dahilihafıza = DahiliHafıza;
            this.Ramkapasitesi = RamKapasitesi;
            this.Pilgucu = PilGucu;
            this.ad = AD;
            this.model = MODEL;
            this.marka = MARKA;
            this.ozellık = OZELLIK;
            this.hamFiyat = HAMFIYAT;

            stokAdedi = RastgeleSayi.Next(1, 101);

       
        }
        public void KDVUYGULA()
        {
            KDVliFiyat=hamFiyat*1.18 ;
        }

    }
    
  
}
