using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    [Table("Kategoriler")]
    public class Kategori:BaseModel
    {
        public virtual ICollection<Kitap>Kitaplar { get; set; }=new List<Kitap>();
        
    }
}
