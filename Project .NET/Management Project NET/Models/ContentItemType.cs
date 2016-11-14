using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContentItemType
    {
        public int Id { get; set; }
        [Index(IsUnique =true), MaxLength(255), Required]
        public string Name { get; set; }
    }
}
