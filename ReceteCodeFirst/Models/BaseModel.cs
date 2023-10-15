using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public Guid Guid { get; set; } = Guid.NewGuid();
        public string IlacAdi { get; set; }
        public string DoktorAdSoyad { get; set; }
        public DateTime ReceteHazirlanisTarihi { get; set; }= DateTime.Now;
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
    }
}
