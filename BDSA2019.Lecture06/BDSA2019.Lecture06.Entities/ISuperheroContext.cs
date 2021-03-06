using Microsoft.EntityFrameworkCore;

namespace BDSA2019.Lecture06.Entities
{
    public interface ISuperheroContext
    {
        DbSet<Superhero> Superheroes { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Power> Powers { get; set; }
        DbSet<SuperheroPower> SuperheroPowers { get; set; }
        DbSet<AuditInfo> AuditInfo { get; set; }
        int SaveChanges();
    }
}
