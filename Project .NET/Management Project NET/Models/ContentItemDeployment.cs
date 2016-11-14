using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class ContentItemDeployment
    {
        [Key]
        [Column(Order = 0)]
        public long TenantEnvironmentId { get; set; }

        public TenantEnvironment TenantEnvironment { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ContentItemId { get; set; }

        public ContentItem ContentItem { get; set; }

        [Key]
        [Column(Order = 2)]
        [Display(Name = "Deployer")]
        public long UserId { get; set; }

        [Display(Name = "Deployer")]
        public User User { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DeployDate { get; set; }
    }
}
