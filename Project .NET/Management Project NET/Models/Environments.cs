using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Environments
    {
        public int Id { get; set; }
        [MaxLength(5), Required]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        [MaxLength(255), Required]
        public string Name { get; set; }
    }
}
