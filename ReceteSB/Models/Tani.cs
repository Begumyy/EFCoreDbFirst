using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteSB.Models
{
    [Table("Tanilar")]
    public class Tani:BaseModel
    {
        public string Kod { get; set; }

        public virtual ICollection<Recete> Receteler { get; set; } = new List<Recete>();
    }
}
