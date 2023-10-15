using ReceteZ.Data;
using ReceteZ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Controllers
{
    public class ReceteController
    {
        public static void Ekle(Recete recete)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Attach(recete.ReceteIlaclari.First());
            context.Attach(recete.Tanilar.First());
            context.Receteler.Add(recete);
            context.SaveChanges();
        }
    }
}
