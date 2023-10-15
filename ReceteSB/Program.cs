using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Identity.Client;
using ReceteSB.Controllers;
using ReceteSB.Data;
using ReceteSB.Models;
using System.Linq;

namespace ReceteSB
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TEK EKLEMEK İSTEDİGİMİZDE;
            //Tani tani = new Tani();
            //Console.WriteLine("Tanı adı giriniz: ");
            //tani.Ad = Console.ReadLine();
            //Console.WriteLine("Tanı kodu giriniz: ");
            //tani.Kod = Console.ReadLine();
            //TaniController.Ekle(tani);

            ////int id=TaniController.Ekle(tani);
            //Console.WriteLine($"Eklemiş olduğunuz {tani.Id} id'li tanı eklenmiştir.");

            //LIST OLARAK EKLEMEK İSTEDİGİMİZDE;
            //List<Tani>taniListesi= new List<Tani>();
            //taniListesi.Add(new Tani {Ad="Kulak çınlaması",Kod="654654"});
            //taniListesi.Add(new Tani { Ad = "Boğaz iltihabı", Kod = "985478" });
            //taniListesi.Add(new Tani { Ad = "Kalp ağrısı", Kod = "1533656" });
            //taniListesi.Add(new Tani { Ad = "Kedi ısırması", Kod = "2365892" });
            //taniListesi.Add(new Tani { Ad = "Diken batması", Kod = "215789" });
            //taniListesi.Add(new Tani { Ad = "Göz ağrısı", Kod = "454878" });

            //taniListesi = TaniController.CokluEkle(taniListesi);

            //ApplicationDbContext context = new ApplicationDbContext();
            //Tani Sil = context.Tanilar.Find(2);
            //TaniController.Sil(Sil);

            //ApplicationDbContext context = new ApplicationDbContext();
            //Tani GercekSil = context.Tanilar.Find(2);
            //TaniController.GercekSil(GercekSil);

            //Console.WriteLine("Lütfen aramak istediğiniz bir kaç harfi yazınız: ");
            //List<Tani> arananKelime = TaniController.IsmeGoreAra(Console.ReadLine());
            //if (arananKelime.Count!=0)
            //{
            //    Console.WriteLine(arananKelime.Count + " : Bulunan sonuç: ");
            //    foreach (Tani item in arananKelime)
            //    {

            //            Console.WriteLine("Sonuç: " + item.Ad);

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen harf giriniz!!");
            //}


            Recete recete = new Recete();
            Doktor doktor = new Doktor();
            Tani tani = new Tani();
            ReceteIlac receteIlac = new ReceteIlac();
          
            
            //receteIlac.Id = 2;
            //receteIlac.Ad = "Prozac";
            //receteIlac.Adet = 2;
            //receteIlac.AktifMi = true;
            //receteIlac.SilindiMi = false;
            //receteIlac.ReceteId = 2;
            try
            {
                recete.ReceteIlaclari.Add(new ReceteIlac
                {
                    Ilac = new Ilac
                    {
                        Ad = "Parol",
                        Barkod = "1244"
                        
                    },
                    Doz = 1,
                    Periyot = 1,
                    Adet = 1,
                    KullanimSekli= new KullanimSekli
                    {
                        Ad="Ağızdan"
                    }
                }); 
             }
            catch(Exception ex)
            {
                throw;
            }
            
            //List<Tani> taniListesi = new List<Tani>();
            //recete.Tanilar = taniListesi;
            recete.Tanilar.Add(new Tani
            {
                Ad = "Üşütme",
                Kod = "111"

            });
            recete.Doktor = doktor;
            recete.Doktor.Ad = "Begüm Yünkül";
            recete.Doktor.TCKN = "12345678901";
            recete.Doktor.PINKodu = "13547";
            recete.Aciklama = "Soğuk algınlığı";


            ReceteController.Olustur(recete);
            
            
            
        }   
    }
}