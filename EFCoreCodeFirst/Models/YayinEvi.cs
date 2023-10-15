using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    [Table("YayinEvleri")]
    public class YayinEvi:BaseModel
    {
        public string Adres { get; set; }
        public virtual ICollection<Yazar> Yazarlar { get; set; } = new List<Yazar>();
        public virtual ICollection<Kitap> Kitaplar { get; set; }= new List<Kitap>();
    }
}
