using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class SertifikaBilgileri : BaseEntity
    {
       
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }        
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Acıklama { get; set;}
        [Required]       
        public DateTime Tarıh { get; set; }
        [Required]       
        public DateTime GecerlılıkSuresı { get; set; }
        public Mezun Mezun { get; set; }

    }
}
