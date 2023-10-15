using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceteZ.Models
{
    [Table("Receteler")]
    public class Recete:BaseModel
    {
        public int DoktorId { get; set; }
        public string? ReceteTuru { get; set; }
        public string? EreceteNo { get; set; }
        public string? Aciklama { get; set; }
        public string HastaAdi { get; set; }
        public string HastaTCKN { get; set; }

        public virtual Doktor Doktor { get; set; }
        public virtual ICollection<ReceteIlac>ReceteIlaclari { get; set; }= new List<ReceteIlac>();
        public virtual ICollection<Tani> Tanilar { get; set; } = new List<Tani>();
    }
}
