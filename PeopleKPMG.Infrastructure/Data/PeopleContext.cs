using PeopleKPMG.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace PeopleKPMG.Infrastructure.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
    }
}
