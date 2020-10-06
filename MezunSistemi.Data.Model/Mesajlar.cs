using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Mesajlar:BaseEntity
    {    
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Icerık { get; set; }
        [Required]
        public DateTime Tarıh { get; set; }
        [Required]
        public int Saat { get; set; }
        public Mezun Mezun { get; set; }
    }
}
