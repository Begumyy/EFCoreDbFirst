using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    [Table("Kitaplar")]
    public class Kitap:BaseModel
    {
       public int SayfaSayisi { get; set; }
       public string Isbn { get; set; }
       public int KategoriId { get; set; }
       public virtual Kategori Kategori { get; set; }
       public virtual ICollection<Yazar> Yazarlar { get; set; }= new List<Yazar>();
        public virtual ICollection<YayinEvi> YayinEvleri { get; set; } = new List<YayinEvi>();
    }
}
