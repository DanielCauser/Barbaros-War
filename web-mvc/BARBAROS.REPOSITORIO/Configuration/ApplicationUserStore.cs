using BARBAROS.REPOSITORIO.Context;
using BARBAROS.REPOSITORIO.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BARBAROS.REPOSITORIO.Configuration
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
