using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RoleTranslation
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Translation { get; set; }
        
    }
}
