using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string? Ad { get; set; }
        public bool SilindiMi { get; set; } = false;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}
