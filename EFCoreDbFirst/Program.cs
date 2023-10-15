using EFCoreDbFirst.Models;

namespace EFCoreDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             NorthwindContext context = new NorthwindContext();

            var result = context.Products.Select(p => new
            {
                UrunAdi=p.ProductName,
                KategoriAdi=p.Category.CategoryName,
                Tedarikci=p.Supplier.CompanyName
            });

            foreach (var item in result)
            {
                Console.WriteLine(item.UrunAdi + " - " + item.KategoriAdi + " - " + item.Tedarikci);
            }
        }
    }
}