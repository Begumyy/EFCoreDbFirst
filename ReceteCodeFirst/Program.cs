using ReceteCodeFirst.Data;
using ReceteCodeFirst.Models;

namespace ReceteCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ilac ılac = new Ilac();
            ılac.IlacAdi = "Aspirin";


            ApplicationDbContext context = new ApplicationDbContext();
            context.Ilaclar.Add(ılac);
            context.SaveChanges();
        }
    }
}