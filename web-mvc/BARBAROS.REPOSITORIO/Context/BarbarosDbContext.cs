using BARBAROS.REPOSITORIO.Inicializador;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.REPOSITORIO.Context
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class BarbarosDbContext : DbContext
    {
        public BarbarosDbContext() : base("Desenv")
        {
            Database.SetInitializer<BarbarosDbContext>(new BarbarosInicializadorDB(this));
        }

        public DbSet<MembroModel> Membro { get; set; }
    }
}
