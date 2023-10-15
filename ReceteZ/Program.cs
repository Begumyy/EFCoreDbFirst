using ReceteZ.Controllers;
using ReceteZ.Data;
using ReceteZ.Models;

namespace ReceteZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Ilac> ilaclar = new List<Ilac>();
            //ilaclar.Add(new Ilac { Ad = "Talcid", Barkod = "123456"});
            //ilaclar.Add(new Ilac { Ad = "Minoset", Barkod = "123456" });
            //ilaclar.Add(new Ilac { Ad = "Talisca", Barkod = "123456" });
            //ilaclar.Add(new Ilac { Ad = "Apranax", Barkod = "123456" });
            //Ilac ilac = new Ilac();
            //ilac.Barkod = "123456";


            //ApplicationDbContext context = new ApplicationDbContext();
            //context.Ilaclar.AddRange(ilaclar);
            //context.SaveChanges();

            //ornegin 2 id li nesneyi bulup ismini guncelleyelim.
            //1.YÖNTEM
            //Ilac DbDenGelenIlac = context.Ilaclar.Find(2); //en hızlısı bu ve en iyisi eger primary key uzerinden arama yapacaksak bunu kullanmak en hızlısı.

            //2.YÖNTEM
            //Ilac DbDenGelenIlac = context.Ilaclar.FirstOrDefault(i=>i.Id==2);

            //3.YÖNTEM
            //Ilac DbDenGelenIlac = context.Ilaclar.Where(i => i.Id == 2).First();

            //Ilac DbDenGelenIlac = context.Ilaclar.Find(2);
            //DbDenGelenIlac.Ad = "Emre";
            //context.Ilaclar.Update(DbDenGelenIlac);
            //context.SaveChanges();

            //List<Tani> tanilar = new List<Tani>();
            //while (true)
            //{
            //    Tani tani = new Tani();

            //    Console.WriteLine("Lütfen tanı adı giriniz: ");
            //    tani.Ad = Console.ReadLine();
            //    Console.WriteLine("Lütfen tanı kodu giriniz: ");
            //    tani.Kod = Console.ReadLine();

            //    tanilar.Add(tani);
            //    Console.WriteLine("Yeni bir kayıt daha ekleme ister misiniz?: E/H");

            //    string cevap = Console.ReadLine();

            //    if (cevap.ToUpper()=="H")
            //    {
            //        break;
            //    }
            //    Console.Clear();

            //}

            //context.Tanilar.AddRange(tanilar);
            //context.SaveChanges();
            //Console.WriteLine("Tanı Adı giriniz: ");
            //Tani tani = new Tani();
            //tani.Ad = Console.ReadLine();
            //Console.WriteLine("Tanı Kodu giriniz: ");
            //tani.Kod = Console.ReadLine();

            //List<Tani> taniListesi = new List<Tani>();
            //taniListesi.Add(new Tani { Ad="test",Kod="1235254"});
            //taniListesi.Add(new Tani { Ad = "test2", Kod = "1235254" });
            //taniListesi.Add(new Tani { Ad = "test3", Kod = "1235254" });
            //taniListesi.Add(new Tani { Ad = "test4", Kod = "1235254" });

            //taniListesi=TaniController.CokluEkle(taniListesi);


            //if (TaniController.Ekle(tani))

            //    Console.WriteLine("İşlem başarılı :)");

            //else
            //    Console.WriteLine("İşlem başarısız :(");


            //Eklemiş oldugunuz tanı xxx id'si ile veritabanına başarıyla eklenmiştir desin.
            //int id= TaniController.Ekle(tani);
            //Console.WriteLine($"Eklemiş olduğunuz tanı {id} si ile eklenmiştir.");


            //Console.WriteLine("Lütfen aramak istediğiniz tanının birkaç harfini yazınız: ");
            //List<Tani> aramaSonucu = TaniController.IsmeGoreAra(Console.ReadLine());

            //if (aramaSonucu.Count != 0)
            //{
            //    Console.WriteLine("Bulunan tanı sayısı : " + aramaSonucu.Count);
            //    foreach (Tani item in aramaSonucu)
            //    {
            //        Console.WriteLine(item.Ad);
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("Herhangi bir tanı bulunamadı");
            //}

            ApplicationDbContext context = new ApplicationDbContext();
            Tani tani = null;
            List<Tani> tanilar = new List<Tani>();
            while (tani == null)
            {
                Console.WriteLine("Lütfen tanı kodu giriniz: ");
                tani = context.Tanilar.FirstOrDefault(t => t.Kod == Console.ReadLine());
                if (tani==null)
                    Console.WriteLine("Aradığınız tanı veritabanında bulunamadı.");
                else
                    tanilar.Add(tani);
            }

            Doktor yenidoktor = new Doktor
            {
                Ad = "Begüm Yünkül",
                PINKodu = "12547",
                TCKN = "2154788877"

            };
            List<ReceteIlac> ilaclar = new List<ReceteIlac>();
            Ilac yeniIlac = context.Ilaclar.FirstOrDefault(i => i.Barkod == "1234556");
            ilaclar.Add(new ReceteIlac
            {
                Adet = 5,
                Doz = 2,
                Periyot = 1,
                KullanimSekli = new KullanimSekli { Ad = "Ağızdan" },
                Ilac = context.Ilaclar.FirstOrDefault(i => i.Barkod == "1234556")
            });

            Recete recete = new Recete
            {
                Ad = "Test",
                Aciklama = "Test",
                ReceteTuru = "Normal",
                Doktor = yenidoktor,
                Tanilar= tanilar,  
            };



        }
    }
}