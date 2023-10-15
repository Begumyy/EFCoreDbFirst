using ReceteSB.Data;
using ReceteSB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteSB.Controllers
{
    public class ReceteController
    {
        public static Recete Olustur(Recete recete)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                context.Receteler.Add(recete);
                context.SaveChanges();
                return recete;
            }
            catch(Exception ex)
            {
                return new Recete();
            }
        }
    }
}
