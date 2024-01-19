using InsuranceERP_EF_Razor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace InsuranceERP_EF_Razor.DAL
{
    public class InsuranceDbContext : DbContext
    {
        public InsuranceDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Policy> Policies { get; set; }
    }
}
