using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezunSistemi.Data.Model
{
    public class Takıp:BaseEntity
    {
      
        public Mezun Mezun { get; set; }
    }
}
