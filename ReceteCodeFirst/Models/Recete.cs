using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    [Table("Receteler")]
    public class Recete:BaseModel
    {
        public int Tutar { get; set;}

        public virtual Doktor Doktor { get; set; }
        public virtual ReceteIlaci ReceteIlaci { get; set; }
        public virtual ICollection<Tani> Tanilar { get; set; }= new List<Tani>();
        public virtual ICollection<Ilac> Ilaclar { get; set; } = new List<Ilac>();
    }
}
