using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Pozisyon:BaseEntity
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Etıket { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Acıklama { get; set; }
    }
}
