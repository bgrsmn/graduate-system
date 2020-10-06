using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Yorumlar:BaseEntity
    {      
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Yorum { get; set; }
        [Required]
        public string Onay { get; set; }
        public Mezun Mezun { get; set; }
        public İlanlar Ilanlar { get; set; }
    }
}
