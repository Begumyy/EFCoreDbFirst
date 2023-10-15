using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteCodeFirst.Models
{
    [Table("Tanilar")]
    public class Tani:BaseModel
    {
    
        public string Aciklama { get; set; }
        public bool TedavisiVarMi { get; set; }=false;
        public bool TeshisKonulduMu { get; set; }=false;
        public bool TestlerYapildiMi { get; set; }=false;

        public virtual ICollection<Recete> Receteler { get; set; } = new List<Recete>();
    }
}
