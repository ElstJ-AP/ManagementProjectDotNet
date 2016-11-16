using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Tenants
    {
        public long Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(255), Required]
        public string Name { get; set; }
    }
}
