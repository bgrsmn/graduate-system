using System.ComponentModel.DataAnnotations;

namespace MezunSistemi.Data.Model
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
