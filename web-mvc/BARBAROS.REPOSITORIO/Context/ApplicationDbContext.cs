using BARBAROS.REPOSITORIO.Inicializador;
using BARBAROS.REPOSITORIO.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BARBAROS.REPOSITORIO.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("Desenv", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new BarbarosInicializadorDB(this));
        }

        public static ApplicationDbContext Create()
        {

            return new ApplicationDbContext();
        }

        public DbSet<MembroModel> Membro { get; set; }

    }
}
