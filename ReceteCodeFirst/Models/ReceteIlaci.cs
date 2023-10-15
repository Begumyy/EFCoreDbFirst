using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    [Table("ReceteIlaclari")]
    public class ReceteIlaci:BaseModel
    {
       public string Periyot { get; set; }
       public decimal Doz { get; set; }
       public int Adet { get; set; }
       public string KullanimSekli { get; set; }
    }
}
