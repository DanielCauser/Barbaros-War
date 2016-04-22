using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using BARBAROS.REPOSITORIO.Context;
using BARBAROS.REPOSITORIO.Inicializador;
using BARBAROS.REPOSITORIO;

namespace BARBAROS.MVC.Models
{
    public class ApplicationUser : IdentityUser
    {
    }
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

    public class BarbarosInicializadorDB : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        public BarbarosInicializadorDB(ApplicationDbContext context)
        {
            this.Seed(context);
        }
        protected override void Seed(ApplicationDbContext context)
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