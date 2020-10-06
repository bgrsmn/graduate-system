using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Mezun : BaseEntity
    {
        [Required]
        public string OgrencıNo { get; set; }

        [Required]
        [Column(TypeName="varchar")]
        [MaxLength(50)]
        public string Ad { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Soyad { get; set; }
        [Column(TypeName = "char")]
        [MaxLength(11),MinLength(11)]
        public string Tel { get; set; }
        [Column(TypeName = "nvarchar")]
        [MaxLength(100)]
        public string Eposta { get; set;}      
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        public string YabancıDil { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Pozisyon Pozısyon { get; set; }
        public virtual ÇalışmaAlanları CalısmaAlanları { get; set; }
        

       



         


    }
}
