using Microsoft.EntityFrameworkCore;
using Models._12626_1_Termin_ASP_Net;

namespace _12626_1_Termin_ASP_Net.DAL.Contexts
{
    public class AwariaContext : DbContext
    {
        public AwariaContext(DbContextOptions<AwariaContext> options) : base(options)
        {

        }
        public DbSet<Awaria> Awaria { get; set; }
    }
}
