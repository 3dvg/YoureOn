
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using YoureOnGenNHibernate.EN.YoureOn;
using YoureOnGenNHibernate.CEN.YoureOn;
using YoureOnGenNHibernate.CAD.YoureOn;
using YoureOnGenNHibernate.Enumerated.YoureOn;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes
                System.Console.WriteLine ("Creando Usuarios");
                UsuarioCEN usuario = new UsuarioCEN ();
                string email1 = usuario.CrearUsuario ("deb8192@gmail.com", "Debora", "Galdeano Gonzalez", new DateTime (1992, 1, 8), "53244933W", "foto1.jpg", "contrasenya", false);
                string email2 = usuario.CrearUsuario ("mmssll@gmail.com", "Manolo", "Stinson Lopez", new DateTime (2003, 5, 4), "26874219S", "foto2.jpg", "soillutuber", false);
                string email3 = usuario.CrearUsuario ("jorge1887@alu.ua.es", "Jorge", "Francisco Gomez", new DateTime (1985, 2, 28), "41567955L", "foto3.jpg", "123456", false);
                string email4 = usuario.CrearUsuario ("cunyado17@gmail.com", "Arturo", "Perez-Reverte", new DateTime (1951, 11, 25), "11111111A", "foto4.jpg", "VivaEspanya", false);
                string email5 = usuario.CrearUsuario ("marines@gmail.com", "Marines", "Anton", new DateTime (1994, 11, 25), "12378945A", "foto5.jpg", "123456", false);
                string email6 = usuario.CrearUsuario ("eva@gmail.com", "Eva", "Valenciano", new DateTime (1996, 11, 25), "11111111S", "foto6.jpg", "contrasenya", false);

                System.Console.WriteLine ("Creando Administrador");
                AdministradorCEN administrador1 = new AdministradorCEN ();
                administrador1.New_ ("admin@gmail.com", "Admin", "Admin", new DateTime (1994, 1, 1), "12345678A", "foto_perfil.jpg", "Admin94*", false, "1", "1");

                System.Console.WriteLine ("Creando Moderadores");
                ModeradorCEN moderador = new ModeradorCEN ();
                string moderadorID1 = moderador.New_ ("email@gmail.com", "Moderador1", "Apellido", new DateTime (1996, 1, 1), "1111211V", "foto_perfil.jpg", "contrasenya", false, "permiso1");
                string moderadorID2 = moderador.New_ ("jmld4@alu.ua.es", "Jose Manuel", "Ladron de Guevara", new DateTime (1997, 7, 10), "48720478S", "foto7.jpg", "contrasena1234", false, "permiso");
                string moderadorID3 = moderador.New_ ("algv@yahoo.com", "Alberto", "Lopez-Garcia Vigo", new DateTime (1991, 1, 31), "45487454K", "foto1.jpg", "123456", false, "permiso");

                System.Console.WriteLine ("Creando contenidos");
                ContenidoCEN contenido = new ContenidoCEN ();
                int contenidoID1 = contenido.SubirContenido ("Fotografia", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.Sin_licencia, email1, "autor", false, @"/Archivos/foto1.jpg", DateTime.Now);
                int contenidoID2 = contenido.SubirContenido ("Mohana", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.CC_BY, email2, "autor", false, @"/Archivos/foto2.jpg", DateTime.Now);
                int contenidoID3 = contenido.SubirContenido ("Emoji", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.CC_BY_NC, email3, "autor", false, @"/Archivos/foto3.jpg", DateTime.Now);
                int contenidoID4 = contenido.SubirContenido ("Pues una foto", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.imagen, "es una foto", TipoLicenciaEnum.CC_BY_NC_SA, email1, "fotografo", false, @"/Archivos/foto4.jpg", DateTime.Now);
                int contenidoID5 = contenido.SubirContenido ("Libro Gordo", TipoArchivoEnum.texto, "contenidotexto", TipoLicenciaEnum.CC_BY_NC_ND, email4, "Peres-Reverte", false, @"/Archivos/Perez-Reverte, Arturo - Alatriste 1 - El capitan Alatriste.pdf", DateTime.Now);
                int contenidoID6 = contenido.SubirContenido ("Libro Gordo", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.video, "contenidovideo", TipoLicenciaEnum.CC_BY_ND, email1, "Muse", false, @"https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now);
                int contenidoID7 = contenido.SubirContenido ("Song 84", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.audio, "contenidoaudio", TipoLicenciaEnum.Sin_licencia, email3, "Blor", true, @"https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now);

                System.Console.WriteLine ("Creando video");
                VideoCEN videoCEN = new VideoCEN ();
                int videoID1 = videoCEN.New_ ("Titulo", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.video, "Descripcion", TipoLicenciaEnum.Sin_licencia, email4, "Conde Mor", false, @"https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now, 200, 1080, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum.avi);

                System.Console.WriteLine ("Creando comentarios");
                ComentarioCEN comentario = new ComentarioCEN ();
                int comentarioID1 = comentario.New_ ("Ola q ase", new DateTime (2017, 1, 8), email1, contenidoID1);
                int comentarioID2 = comentario.New_ ("Primero en comentar", new DateTime (2015, 5, 31), email1, contenidoID3);
                int comentarioID3 = comentario.New_ ("Pues a mi me parece un buen contenido porque...", new DateTime (2016, 2, 20), email2, contenidoID1);
                int comentarioID4 = comentario.New_ ("sub x sub", new DateTime (2017, 7, 10), email3, contenidoID4);



                System.Console.WriteLine ("Creando notificaciones");
                NotificacionesCEN notificacion1 = new NotificacionesCEN ();
                notificacion1.New_ (email1, "Alerta mensaje", moderadorID1);

                System.Console.WriteLine ("Creando reportes");
                ReporteCEN reporte1 = new ReporteCEN ();
                reporte1.New_ (DateTime.Today);

                System.Console.WriteLine ("Creando bibliotecas");
                BibliotecaCEN biblioteca = new BibliotecaCEN ();
                int bibliotecaID1 = biblioteca.New_ (email1);
                int bibliotecaID2 = biblioteca.New_ (email3);
                //biblioteca.Anyadir_a_biblioteca(bibliotecaID1,contenido.CargarContenido(contenidoID1));
                //biblioteca.Anyadir_a_biblioteca(bibliotecaID1, contenido.CargarContenido(contenidoID4));

                System.Console.WriteLine ("Creando idiomas");
                IdiomaCEN idioma = new IdiomaCEN ();
                idioma.New_ ("Castellano", "descripcioncastellano");
                idioma.New_ ("Valenciano", "descripcionvalenciano");
                idioma.New_ ("Ingles", "descripcioningles");

                System.Console.WriteLine ("Creando falta");
                FaltaCEN falta = new FaltaCEN ();
                int faltaID1 = falta.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email1, new DateTime (1996, 1, 8), moderadorID3);
                int faltaID2 = falta.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email1, new DateTime (2017, 5, 20), moderadorID1);
                int faltaID3 = falta.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email2, new DateTime (2016, 3, 14), moderadorID1);
                int faltaID4 = falta.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email3, new DateTime (2017, 11, 10), moderadorID2);
                int faltaID5 = falta.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.grave, email3, new DateTime (2017, 11, 12), moderadorID2);

                /*System.Console.WriteLine ("Creando enlaces del footer");
                 * FooterCEN footerCEN = new FooterCEN ();
                 * footerCEN.New_ ("Enlace", "Preguntas frecuentes");
                 * footerCEN.New_ ("ENLACE A OPCIONES", "Bla bla bla descripcion de opciones.");
                 * footerCEN.New_ ("ENLACE A FAQs", "Bla bla bla descripcion de FAQs.");
                 * footerCEN.New_ ("ENLACE A AYUDA", "Bla bla bla descripcion de ayuda.");*/

                NotificacionesCEN notificaciones = new NotificacionesCEN ();
                int notificacionID1 = notificaciones.New_ (email2, "Te estas portando mal, jummm", moderadorID1);
                int notificacionID2 = notificaciones.New_ (email3, "Cambiate el nick, no me gusta", moderadorID1);
                int notificacionID3 = notificaciones.New_ (email3, "Ya tienes muchas faltas, eh??", moderadorID1);
                int notificacionID4 = notificaciones.New_ (email4, "No te lo digo mas veces, te vamos a echar de aqui", moderadorID2);

                ReporteCEN reporteCEN = new ReporteCEN ();
                reporteCEN.New_ (DateTime.Today);
                reporteCEN.New_ (DateTime.Today);
                reporteCEN.New_ (DateTime.Today);
                reporteCEN.New_ (DateTime.Today);

                ValoracionComentarioCEN valoracioncomCEN1 = new ValoracionComentarioCEN ();
                int valoracioncomID1 = valoracioncomCEN1.New_ (new DateTime (2017, 1, 21), 5, comentarioID4);

                ValoracionComentarioCEN valoracioncomCEN2 = new ValoracionComentarioCEN ();
                int valoracioncomID2 = valoracioncomCEN2.New_ (new DateTime (2017, 2, 21), 1, comentarioID1);

                ValoracionComentarioCEN valoracioncomCEN3 = new ValoracionComentarioCEN ();
                int valoracioncomID3 = valoracioncomCEN3.New_ (new DateTime (2017, 3, 21), 0, comentarioID1);

                ValoracionComentarioCEN valoracioncomCEN4 = new ValoracionComentarioCEN ();
                int valoracioncomID4 = valoracioncomCEN3.New_ (new DateTime (2017, 4, 21), 2, comentarioID3);

                ValoracionContenidoCEN valoracionconCEN1 = new ValoracionContenidoCEN ();
                int valoracionconID1 = valoracionconCEN1.New_ (new DateTime (2017, 1, 21), 5, contenidoID1);

                ValoracionContenidoCEN valoracionconCEN2 = new ValoracionContenidoCEN ();
                int valoracionconID2 = valoracionconCEN2.New_ (new DateTime (2017, 2, 21), 1, contenidoID2);

                ValoracionContenidoCEN valoracionconCEN3 = new ValoracionContenidoCEN ();
                int valoracionconID3 = valoracionconCEN3.New_ (new DateTime (2017, 3, 21), 0, contenidoID2);

                ValoracionContenidoCEN valoracionconCEN4 = new ValoracionContenidoCEN ();
                int valoracionconID4 = valoracionconCEN4.New_ (new DateTime (2017, 4, 21), 2, contenidoID4);

                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
