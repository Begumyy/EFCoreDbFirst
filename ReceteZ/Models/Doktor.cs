using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Models
{
    [Table("Doktorlar")]
    public class Doktor:BaseModel
    {
        [MaxLength(11)]
        public string TCKN { get; set; }
        public string PINKodu { get; set; }
    }
}
