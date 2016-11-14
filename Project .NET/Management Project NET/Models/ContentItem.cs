using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ContentItem
    {
        public long Id { get; set; }
        [ForeignKey("type")]
        public int typeId { get; set; }
        [Required]
        public virtual ContentItemType type { get; set; }
        [Required, Index(IsUnique = true)]
        public int replicationkey { get; set; }
        public string itemname { get; set; }
    }
}
