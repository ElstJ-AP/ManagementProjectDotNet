using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StatusTranslation
    {
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Translation { get; set; }
        
    }
}
