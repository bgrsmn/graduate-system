using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class ÇalışmaBilgileri:BaseEntity
    {     
        [Required]      
        public DateTime BaslangıcTarıhı { get; set; }
        [Required]       
        public DateTime? CıkısTarıhı { get; set; }
        public Mezun Mezun { get; set; }
        public Firma Fırma { get; set; }
        public Pozisyon Pozısyon { get; set; }
        public ÇalışmaAlanları CalısmaAlanları { get; set; }
    }
}
