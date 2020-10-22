
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI:3.ödev
**				ÖĞRENCİ ADI:SONGÜL BAYER
**				ÖĞRENCİ NUMARASI:B191210065
**              DERSİN ALINDIĞI GRUP:1-C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //KURUCU FONKSİYONLARDAN ALDIĞIMIZ ÖZELLİKLERE DEĞERLERİ ATADIK.
            BuzDolabı BD = new BuzDolabı("SAMSUNG RT46K6000S8", "SAMSUNG", "ÇİFT KAPILI", "NO FROST", 4000, "600L", "A++");
            ledTV LTV = new ledTV("50 inç", "1280*720 piksel", "PHLİPS RTKL12255", "PHİLİPS", "SMART 4K", "AKILLI EKRAN", 5000);
            CepTel TLFN = new CepTel("64 GB", "8 GB RAM", "HUAWEİ MATE 20", "HUAWEİ", "MATE 20 LİTE", "DOKUNMATIK EKRAN", 2500);
            Laptop PC = new Laptop("15 inç", "1040*1500", "64 GB", "8 GB", "12 SAAT", "LENOVO DİZÜSTÜ", "LENOVO E580", "LENOVO", "PARMAK İZİ OKUMA", 7000);
            //STOK ADEDİ İÇİN AYRILMIŞ LABELLERE RASTGELE BELİRLENEN STOK ADETLERİNİ YAZDIRDIK.
            label14.Text = Convert.ToString(LTV.stokAdedi);
            label15.Text = Convert.ToString(BD.stokAdedi);
            label18.Text = Convert.ToString(PC.stokAdedi);
            label20.Text = Convert.ToString(TLFN.stokAdedi);
            // NUMERİCUPDOWN VASITASI İLE KULLANICININ SEÇTİĞİ ÜRÜN ADETLERİNİ URUNLERİN SECİLEN ADETLERİ OLARAK ATADIK.
           PC.secılenAdet = Convert.ToInt32(numericUpDown3.Value);
           BD.secılenAdet = Convert.ToInt32(numericUpDown2.Value);
           LTV.secılenAdet = Convert.ToInt32(numericUpDown1.Value);
           TLFN.secılenAdet = Convert.ToInt32(numericUpDown4.Value);


        }
        public class Sepet
        {
            BuzDolabı BD = new BuzDolabı("SAMSUNG RT46K6000S8", "SAMSUNG", "ÇİFT KAPILI", "NO FROST", 4000, "600L", "A++");
            ledTV LTV = new ledTV("50 inç", "1280*720 piksel", "PHLİPS RTKL12255", "PHİLİPS", "SMART 4K", "AKILLI EKRAN", 5000);
            CepTel TLFN = new CepTel("64 GB", "8 GB RAM", "HUAWEİ MATE 20", "HUAWEİ", "MATE 20 LİTE", "DOKUNMATIK EKRAN", 2500);
            Laptop PC = new Laptop("15 inç", "1040*1500", "64 GB", "8 GB", "12 SAAT", "LENOVO DİZÜSTÜ", "LENOVO E580", "LENOVO", "PARMAK İZİ OKUMA", 7000);
            void  SepeteUrunEkle(Urun urun) //SEPETEURUNEKLE FONKSİYONU İLE URUNLERE KDV UYGULAMA İŞLEMİ YAPILDI.
            {
                BD.KDVUYGULA();
                LTV.KDVUYGULA();
                TLFN.KDVUYGULA();
                PC.KDVUYGULA();
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lisbox1.Items.Clear();//SEPETE AYNI ÜRÜNEN TEKRAR EKLENİNCE LİSTBOXLARA YENİ DEĞERLER YAZDIRMADIK OLAN DEĞERLERİN (FİYAT VE ADET) EKLEME YAPTIK
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label25.Text = String.Empty;

         //AŞAĞIDA ÜRÜNLERİ SEPETE EKLE BUTONUNA BASILDIĞI TAKDİRDE OLUŞACAK OLAYLAR İÇİN YAZILMIŞ KODLAR BULUNMAKTADIR.  
            BuzDolabı BD = new BuzDolabı("SAMSUNG RT46K6000S8", "SAMSUNG", "ÇİFT KAPILI", "NO FROST", 4000, "600L", "A++");
            ledTV LTV = new ledTV("50 inç", "1280*720 piksel", "PHLİPS RTKL12255", "PHİLİPS", "SMART 4K", "AKILLI EKRAN", 5000);
            CepTel TLFN = new CepTel("64 GB", "8 GB RAM", "HUAWEİ MATE 20", "HUAWEİ", "MATE 20 LİTE", "DOKUNMATIK EKRAN", 2500);
            Laptop PC = new Laptop("15 inç", "1040*1500", "64 GB", "8 GB", "12 SAAT", "LENOVO DİZÜSTÜ", "LENOVO E580", "LENOVO", "PARMAK İZİ OKUMA", 7000);
            //KDVUYGULA() METODUNU ÇAĞIRARAK TÜM ÜRÜNLERE KDV UYGULADIK.
            BD.KDVUYGULA(); 
            LTV.KDVUYGULA();
            TLFN.KDVUYGULA();
            PC.KDVUYGULA();
            //STOK ADETLERİ İLE İŞLEM YAPABİLMEK İÇİN DEĞER ATAMASI YAPTIK.
            int deger =Convert.ToInt32(label14.Text);
            int deger1 = Convert.ToInt32(label15.Text);
            int deger2 = Convert.ToInt32(label18.Text);
            int deger3 = Convert.ToInt32(label20.Text);

          
            if (numericUpDown1.Value != 0)//KULLANICININ ÜRÜN ADEDİ SEÇTİĞİ TAKDİRDE YAPILMASI GEREKENLER İÇİN BİR DÖNGÜ OLUŞTURDUK.
            {
                int sayi = Convert.ToInt32(numericUpDown1.Value);//SEÇİLEN ÜRÜN ADEDİNİ "sayi" OLARAK ATADIMKİ İŞLEM YAPABİLEYİM.
                listBox3.Items.Add(LTV.KDVliFiyat*sayi);//SEÇİLEN ADEDİ ÜRÜNÜN KDVLİ FİYATI İLE ÇARPIP LİSTBOXA EKLEDİM.
                lisbox1.Items.Add(numericUpDown1.Value);//SEÇİLEN ADET SAYISINI LİSTBOXA EKLEDİM.
                listBox2.Items.Add("TELEVIZYON");//SEÇİLEN ÜRÜNÜN ADINI LİSTBOXA EKLEDİM.
                //AŞŞAĞIDA SEÇİLEN ADETİ STOK ADEDİNDEN DÜŞÜRDÜM.VE KALAN STOK ADEDİNİ GÜNCELLEDİM.
                deger -= sayi; 
                label14.Text = Convert.ToString(deger);
                
            }
            if (numericUpDown2.Value != 0)
            {
                int sayi1 = Convert.ToInt32(numericUpDown2.Value);
                listBox3.Items.Add(BD.KDVliFiyat*sayi1);
                lisbox1.Items.Add(numericUpDown2.Value);
                listBox2.Items.Add("BUZDOLABI");
                deger1 -= sayi1;
                label15.Text = Convert.ToString(deger1);
            }
            if (numericUpDown3.Value != 0)
            {
                int sayi2 = Convert.ToInt32(numericUpDown3.Value);
                listBox3.Items.Add(PC.KDVliFiyat*sayi2);
                lisbox1.Items.Add(numericUpDown3.Value);
                listBox2.Items.Add("BİLGİSAYAR");
                deger2 -= sayi2;
                label18.Text = Convert.ToString(deger2);
            }
            if (numericUpDown4.Value != 0)
            {
                int sayi3 = Convert.ToInt32(numericUpDown4.Value);
                listBox3.Items.Add(TLFN.KDVliFiyat*sayi3);
                lisbox1.Items.Add(numericUpDown4.Value);
                listBox2.Items.Add("TELEFON");
                deger3 -= sayi3;
                label20.Text = Convert.ToString(deger3);
            }
            
            //SEÇİLEN ÜRÜNLERİN KDVLİ TOPLAM FİYATLARINI LABELE YAZDIRDIK
            double toplam = 0;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                toplam += Convert.ToDouble(listBox3.Items[i]);
            }
            label25.Text =Convert.ToString(toplam);


        }
    
        

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AŞAĞIDA SEPETİ TEMİZLE BUTONUNA BASILDIĞI TAKDİRDE OLUŞACAK OLAYLAR İÇİN YAZILMIŞ KODLAR BULUNMAKTA.
            //STOK ADETLERİNİ KULLANARK İŞLEM YAPABİLMEK İÇİN DEĞER ATAMASI YAPTIK.
            int deger = Convert.ToInt32(label14.Text);
            int deger1 = Convert.ToInt32(label15.Text);
            int deger2 = Convert.ToInt32(label18.Text);
            int deger3 = Convert.ToInt32(label20.Text);
            //AŞAĞIDA SEÇİLEN ÜRÜN ADEDİNİ TEKRARDAN STOK ADEDİNE EKLEYEN KODLAR YAZILDI.
            int sayi = Convert.ToInt32(numericUpDown1.Value);
            deger += sayi;
            label14.Text = Convert.ToString(deger);

            int sayi1 = Convert.ToInt32(numericUpDown2.Value);
            deger1 += sayi1;
            label15.Text = Convert.ToString(deger1);

            int sayi2 = Convert.ToInt32(numericUpDown3.Value);
            deger2 += sayi2;
            label18.Text = Convert.ToString(deger2);

            int sayi3 = Convert.ToInt32(numericUpDown3.Value);
            deger3 += sayi3;
            label20.Text = Convert.ToString(deger3);
            //AŞAĞIDA SEPETİN VE TOPLAM FİYATIN SİLİNMESİ YAPILDI.
            lisbox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            label25.Text=String.Empty;
        }
    }
}
