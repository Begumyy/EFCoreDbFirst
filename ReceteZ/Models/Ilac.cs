using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Models
{
    [Table("Ilaclar")]
    public class Ilac:BaseModel
    {
        public string Barkod { get; set; }

        public virtual ICollection<ReceteIlac> ReceteIlaclari { get; set; } = new List<ReceteIlac>();

    }
}
