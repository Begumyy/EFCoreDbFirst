using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    [Table("Yazarlar")] //date annotations
    public class Yazar: BaseModel
    {
        public string Ozgecmis { get; set; }
        public virtual ICollection<Kitap> Kitaplar { get; set; } = new List<Kitap>();
        public virtual ICollection<YayinEvi> YayinEvleri { get; set; }= new List<YayinEvi>();
  
    }
}
