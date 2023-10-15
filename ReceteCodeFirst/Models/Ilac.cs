using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    [Table("Ilaclar")]
    public class Ilac:BaseModel
    {
        public string IlacTuru { get; set; }

        public virtual ICollection<Recete> Receteler { get; set; } = new List<Recete>();
    }
}
