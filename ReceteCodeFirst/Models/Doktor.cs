using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    [Table("Doktorlar")]
    public class Doktor:BaseModel
    {
        public string Brans { get; set; }
        public int DahiliNumara { get; set; }

        public virtual ICollection<Recete> Receteler { get; set; }=new List<Recete>();
    }
}
