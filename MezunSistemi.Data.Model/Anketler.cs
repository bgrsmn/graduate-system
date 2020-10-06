using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Anketler:BaseEntity
    {
        [Required]
        public string AnketIcerıgı { get; set; }
        public Mezun Mezun { get; set; }
    }
}
