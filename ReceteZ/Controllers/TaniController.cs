using Microsoft.Identity.Client;
using ReceteZ.Data;
using ReceteZ.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Controllers
{
    public static class TaniController
    {
        //public static bool Ekle (Tani tani)
        //{
        //    try
        //    {
        //        ApplicationDbContext context = new ApplicationDbContext();
        //        context.Tanilar.Add(tani);
        //        context.SaveChanges();

        //        return true;
        //    }
        //    catch(Exception e)
        //    {
        //        return false;
        //    }
        //}
        public static int Ekle(Tani tani)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.Tanilar.Add(tani);
                context.SaveChanges();

                return tani.Id;
            }
            catch (Exception e)
            {
                return 0;
            }
            


        }
        public static List<Tani> CokluEkle(List<Tani>taniListesi)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.Tanilar.AddRange(taniListesi);
                context.SaveChanges();

                return taniListesi;
                
            }
            catch
            {
                return new List<Tani>();
            }
        }

        public static bool Sil(Tani tani)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                tani.SilindiMi = true;
                context.Tanilar.Update(tani);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool GercekSil(Tani tani)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.Tanilar.Remove(tani);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Tani IsmeGoreGetir(string taniAdi)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                return context.Tanilar.FirstOrDefault(t => t.Ad == taniAdi);
            }
            catch
            {
                return new Tani();
            }
        }

        public static List<Tani> IsmeGoreAra(string aramaKelimesi)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                return context.Tanilar.Where(t=>t.Ad.Contains(aramaKelimesi)).ToList<Tani>();
                
            }
            catch (Exception)
            {
                return new List<Tani>();
            }
        }
    }
}
