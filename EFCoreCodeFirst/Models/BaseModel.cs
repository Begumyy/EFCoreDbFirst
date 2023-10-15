using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class BaseModel
    {
        [Key]//her yazdıgımız key sadece bir altındakini etkiler!!
        public int Id { get; set; }
        public Guid Guid { get; set; }= Guid.NewGuid();
        public string Ad { get; set; }
        public bool SilindiMi { get; set; }= false;
        public bool AktifMi { get; set; } = true;
        public DateTime OlusturulmaTarihi { get; private set; }=DateTime.Now;
        public DateTime GuncellenmeTarihi { get; set; }=DateTime.Now;
    }
}
