using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using YoureOnBootsTrap.Models;
using System.Collections.Generic;
using System;

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
            string usuarios = "Usuario";

            string adminMail = "admin@gmail.com";
            string adminPass = "Admin94*";

            List<string> listaMailsModeradores = new List<string>();
            List<string> listaPassModeradores = new List<string>();
            List<string> listaMailsUsu = new List<string>();
            List<string> listaPassUsu = new List<string>();

            listaMailsModeradores.Add("email@gmail.com");
            listaMailsModeradores.Add("jmld4@alu.ua.es");
            listaMailsModeradores.Add("algv@yahoo.com");

            listaPassModeradores.Add("contrasenya");
            listaPassModeradores.Add("contrasena1234");
            listaPassModeradores.Add("123456");

            listaMailsUsu.Add("deb8192@gmail.com");
            listaMailsUsu.Add("mmssll@gmail.com");
            listaMailsUsu.Add("jorge1887@alu.ua.es");
            listaMailsUsu.Add("cunyado17@gmail.com");
            listaMailsUsu.Add("marines@gmail.com");
            listaMailsUsu.Add("eva@gmail.com");

            listaPassUsu.Add("contrasenya");
            listaPassUsu.Add("soillutuber");
            listaPassUsu.Add("123456");
            listaPassUsu.Add("VivaEspanya");
            listaPassUsu.Add("123456");
            listaPassUsu.Add("contrasenya");


            ApplicationDbContext db = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // Comprobamos si no existe el rol previamente para crearlo
            if (!roleManager.RoleExists(admin))
            {
                roleManager.Create(new IdentityRole(admin));
                CrearUsuarioConRol(userManager, adminMail, adminPass, admin);
            }

            // Creamos el rol de moderador
            if (!roleManager.RoleExists(moderador))
            {
                roleManager.Create(new IdentityRole(moderador));
                for (int i=0; i<listaMailsModeradores.Count; i++)
                {
                    CrearUsuarioConRol(userManager, listaMailsModeradores[i], listaPassModeradores[i], moderador);
                }
            }

            // Creamos el rol de usuario
            if (!roleManager.RoleExists(usuarios))
            {
                roleManager.Create(new IdentityRole(usuarios));
                for (int j=0; j < listaMailsUsu.Count; j++)
                {
                    CrearUsuarioConRol(userManager, listaMailsUsu[j], listaPassUsu[j], usuarios);
                }
            }
        }

        private void CrearUsuarioConRol(UserManager<ApplicationUser> userManager, string email, string pass, string rol)
        {
            var user = new ApplicationUser();
            user.UserName = email;
            user.Email = email;
            
            var chkUser = userManager.Create(user, pass);

            // Le asignamos el rol
            if (chkUser.Succeeded)
            {
                userManager.AddToRole(user.Id, rol);
            }
        }
    }
}
