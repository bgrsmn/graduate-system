using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class İlanlar:BaseEntity
    {

     
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Baslık { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Acıklama { get; set; }
        [Required]
        public DateTime IlanTarıhı { get; set; }
        [Required]
        public DateTime GecerlılıkSuresı { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Tür { get; set; }
        [Required]
        public DateTime Sure { get; set; }
        [Required]
        public string Donem { get; set; }
        public Mezun Mezun { get; set; }
        public Firma Fırma { get; set; }
        public Pozisyon Pozsıyon { get; set; }
        public ÇalışmaAlanları CalısmaAlanları { get; set; }


    }
}
