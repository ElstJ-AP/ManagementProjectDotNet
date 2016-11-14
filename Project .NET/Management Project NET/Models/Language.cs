using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
    }
}
