using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Firma:BaseEntity
    {
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Alan { get; set; }    
        [Column(TypeName = "char")]
        [MaxLength(11),MinLength(11)]
        public string Tel { get; set; }
        [Required]       
        public string Mail { get; set; }       
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Sorumlu { get; set; }  

    }
}
