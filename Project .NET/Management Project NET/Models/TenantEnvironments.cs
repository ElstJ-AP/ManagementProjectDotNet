using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TenantEnvironments
    {
        public long Id { get; set; }
        [Index(IsUnique = true)]
        public long TenantId { get; set; }
        [Index(IsUnique = true)]
        public int EnvironmentId { get; set; }
        public Tenants Tenant { get; set; }
        public Environments Environment { get; set; }
    }
}
