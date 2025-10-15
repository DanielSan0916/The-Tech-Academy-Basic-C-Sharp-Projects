using System.Data.Entity;

namespace CarInsurance.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext()
            : base("name=InsuranceDb") // matches Web.config connection string name
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}