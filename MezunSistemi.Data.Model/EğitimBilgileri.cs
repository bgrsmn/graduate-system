using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class EğitimBilgileri:BaseEntity
    {     
        [Required]
        public string Okul { get; set; }
        [Required]
        public DateTime MezunıyetTarıhı { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Bolumu { get; set; }      
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ortalama { get; set; }
        public Mezun Mezun { get; set; }


    }
}
