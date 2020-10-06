using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class ÇalışmaAlanları:BaseEntity
    {
       
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required]
        public string Etiket { get; set; }       
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Acıklama { get; set; }
    }
}
