using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using YoureOnBootsTrap.Models;

[assembly: OwinStartupAttribute(typeof(YoureOnBootsTrap.Startup))]
namespace YoureOnBootsTrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CrearRoles();
        }

        private void CrearRoles()
        {
            string admin = "Administrador";
            string moderador = "Moderador";

            ApplicationDbContext db = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // Comprobamos si no existe el rol previamente para crearlo
            if (!roleManager.RoleExists(admin))
            {
                roleManager.Create(new IdentityRole(admin));

                var user = new ApplicationUser();
                user.UserName = "admin";
                user.Email = "admin@gmail.com";

                string userPWD = "Admin94*";
                var chkUser = userManager.Create(user, userPWD);

                // Le asignamos el rol de Administrador
                if (chkUser.Succeeded)
                {
                    userManager.AddToRole(user.Id, admin);
                }
            }

            // Creamos el rol de moderador
            if (!roleManager.RoleExists(moderador))
            {
                roleManager.Create(new IdentityRole(moderador));
            }
                
        }
    }
}
