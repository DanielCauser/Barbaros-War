using BARBAROS.REPOSITORIO.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARBAROS.REPOSITORIO.Inicializador
{
    public class BarbarosInicializadorDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<BarbarosDbContext>
    {
        public BarbarosInicializadorDB(BarbarosDbContext context)
        {
            this.Seed(context);
        }
        protected override void Seed(BarbarosDbContext context)
        {
            var membros = new List<MembroModel>
            {
                new MembroModel
                {
                    MembroId = Guid.NewGuid(),
                    Email = "barbaroswarsite@gmail.com",
                    Password = "juliajael",
                    RememberMe = true
                }
            };

            membros.ForEach(s =>
            context.Membro.Add(s));
            context.SaveChanges();
            context.Database.Initialize(true);
        }
    }
}
