
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
        SqlConnection cnn = new SqlConnection (@"Server=(local); database=master; integrated security=yes");

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


                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");
                System.Console.WriteLine ("Creando Usuarios");
                UsuarioCEN usuario1 = new UsuarioCEN ();
                string email1 = usuario1.CrearUsuario ("deb8192@gmail.com", "Debora", "Galdeano Gonzalez", new DateTime (1992, 1, 8), "53244933w", "foto", "contrasenya", false);

                UsuarioCEN usuario2 = new UsuarioCEN ();
                string email2 = usuario2.CrearUsuario ("mmssll@gmail.com", "Manolo", "Stinson Lopez", new DateTime (2003, 5, 4), "26874219S", "foto2", "soillutuber", false);

                UsuarioCEN usuario3 = new UsuarioCEN ();
                string email3 = usuario3.CrearUsuario ("jorge1887@alu.ua.es", "Jorge", "Francisco Gomez", new DateTime (1985, 2, 28), "41567955L", "foto3", "1234", false);

                UsuarioCEN usuario4 = new UsuarioCEN ();
                string email4 = usuario4.CrearUsuario ("cunyado17@gmail.com", "Arturo", "Perez-Reverte", new DateTime (1951, 11, 25), "11111111A", "foto4", "VivaEspanya", false);

                System.Console.WriteLine ("Creando Administrador");
                AdministradorCEN administrador1 = new AdministradorCEN ();
                string administradorID1 = administrador1.New_ ("administrapag@gmail.com", "Eva", "Valenciano", new DateTime (1996, 1, 1), "1111111s", "rutafoto", "contrasenya", false, "1", "1");

                ModeradorCEN moderador1 = new ModeradorCEN ();
                string moderadorID1 = moderador1.New_ ("email@gmail.com", "Moderador1", "Apellido", new DateTime (1996, 1, 1), "1111211V", "rutafoto", "contasenya", false, "permiso1");

                ModeradorCEN moderador2 = new ModeradorCEN ();
                string moderadorID2 = moderador2.New_ ("jmld4@alu.ua.es", "Jose Manuel", "Ladron de Guevara", new DateTime (1997, 7, 10), "48720478S", "foto", "contrasena1234", false, "permiso");

                ModeradorCEN moderador3 = new ModeradorCEN ();
                string moderadorID3 = moderador3.New_ ("algv@yahoo.com", "Alberto", "Lopez-Garcia Vigo", new DateTime (1991, 1, 31), "45487454K", "foto", "contrasena654321", false, "permiso");

                System.Console.WriteLine ("Creando contenidos");
                ContenidoCEN contenido1 = new ContenidoCEN ();
                int contenidoID1 = contenido1.SubirContenido ("Fotografia", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.Sin_licencia, email1, "autor", false, "../Archivos/foto1.jpg;", DateTime.Now);

                ContenidoCEN contenido2 = new ContenidoCEN ();
                int contenidoID2 = contenido2.SubirContenido ("Mohana", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.CC_BY, email2, "autor", false, "../Archivos/foto2.jpg;", DateTime.Now);

                ContenidoCEN contenido3 = new ContenidoCEN ();
                int contenidoID3 = contenido2.SubirContenido ("Emoji", TipoArchivoEnum.imagen, "contenidoimagen", TipoLicenciaEnum.CC_BY_NC, email3, "autor", false, "../Archivos/foto3.jpg;", DateTime.Now);

                ContenidoCEN contenido4 = new ContenidoCEN ();
                int contenidoID4 = contenido2.SubirContenido ("Libro Gordo", TipoArchivoEnum.texto, "contenidotexto", TipoLicenciaEnum.CC_BY_NC_ND, email4, "Peres-Reverte", false, "../Archivos/Perez-Reverte, Arturo - Alatriste 1 - El capit�n Alatriste.pdf", DateTime.Now);

                ContenidoCEN contenido5 = new ContenidoCEN ();
                int contenidoID5 = contenido5.SubirContenido ("Pues una foto", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.imagen, "es una foto", TipoLicenciaEnum.CC_BY_NC_SA, email1, "fotografo", false, "../Archivos/foto4.jpg;", DateTime.Now);

                ContenidoCEN contenido6 = new ContenidoCEN ();
                int contenidoID6 = contenido6.SubirContenido ("Libro Gordo", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.video, "contenidovideo", TipoLicenciaEnum.CC_BY_ND, email1, "Muse", false, "https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now);

                ContenidoCEN contenido7 = new ContenidoCEN ();
                int contenidoID7 = contenido7.SubirContenido ("Song 84", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.audio, "contenidoaudio", TipoLicenciaEnum.Sin_licencia, email3, "Blor", true, "https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now);

                System.Console.WriteLine ("Creando video");
                VideoCEN videoCEN = new VideoCEN ();
                int videoID1 = videoCEN.New_ ("Titulo", YoureOnGenNHibernate.Enumerated.YoureOn.TipoArchivoEnum.video, "Descripcion", TipoLicenciaEnum.Sin_licencia, email4, "Conde Mor", false, "https://www.youtube.com/watch?v=3dm_5qWWDV8", DateTime.Now, 200, 1080, YoureOnGenNHibernate.Enumerated.YoureOn.FormatoVideoEnum.avi);

                System.Console.WriteLine ("Creando comentarios");
                ComentarioCEN comentario1 = new ComentarioCEN ();
                int comentarioID1 = comentario1.New_ ("Ola q ase", new DateTime (2017, 1, 8), email1, contenidoID1);

                ComentarioCEN comentario2 = new ComentarioCEN ();
                int comentarioID2 = comentario2.New_ ("Primero en comentar", new DateTime (2015, 5, 31), email1, contenidoID3);

                ComentarioCEN comentario3 = new ComentarioCEN ();
                int comentarioID3 = comentario3.New_ ("Pues a mi me parece un buen contenido porque...", new DateTime (2016, 2, 20), email2, contenidoID1);

                ComentarioCEN comentario4 = new ComentarioCEN ();
                int comentarioID4 = comentario4.New_ ("sub x sub", new DateTime (2017, 7, 10), email3, contenidoID4);

                System.Console.WriteLine ("Creando notificaiones");
                NotificacionesCEN notificacion1 = new NotificacionesCEN ();
                notificacion1.New_ (email1, "Alerta mensaje", moderadorID1);


                System.Console.WriteLine ("Creando reportes");
                ReporteCEN reporte1 = new ReporteCEN ();
                reporte1.New_ (DateTime.Today);

                //ValoracionCEN valoracion1 = new ValoracionCEN ();
                //valoracion1.New_ (null, 3);


                System.Console.WriteLine ("Creando bibliotecas");
                BibliotecaCEN biblioteca1 = new BibliotecaCEN ();
                biblioteca1.New_ (email1);

                BibliotecaCEN biblioteca2 = new BibliotecaCEN ();
                biblioteca2.New_ (email3);


                FooterCEN footer1 = new FooterCEN ();
                footer1.New_ ("enlace", "Contacto");

                System.Console.WriteLine ("Creando idiomas");
                IdiomaCEN castellano = new IdiomaCEN ();
                castellano.New_ ("Castellano", "descripcioncastellano");

                IdiomaCEN valenciano = new IdiomaCEN ();
                valenciano.New_ ("Valenciano", "descripcionvalenciano");

                IdiomaCEN ingles = new IdiomaCEN ();
                ingles.New_ ("Ingles", "descripcioningles");

                System.Console.WriteLine ("Creando falta");
                FaltaCEN falta1 = new FaltaCEN ();
                int faltaID1 = falta1.New_ (TipoFaltaEnum.leve, email1, new DateTime (1996, 1, 8), moderadorID3);

                FaltaCEN falta2 = new FaltaCEN ();
                int faltaID2 = falta2.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email1, new DateTime (2017, 5, 20), moderadorID1);

                FaltaCEN falta3 = new FaltaCEN ();
                int faltaID3 = falta3.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email2, new DateTime (2016, 3, 14), moderadorID1);

                FaltaCEN falta4 = new FaltaCEN ();
                int faltaID4 = falta4.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.leve, email3, new DateTime (2017, 11, 10), moderadorID2);

                FaltaCEN falta5 = new FaltaCEN ();
                int faltaID5 = falta5.New_ (YoureOnGenNHibernate.Enumerated.YoureOn.TipoFaltaEnum.grave, email3, new DateTime (2017, 11, 12), moderadorID2);

                System.Console.WriteLine("Creando enlaces del footer");
                FooterCEN footerCEN = new FooterCEN ();
                footerCEN.New_ ("Enlace", "Preguntas frecuentes");
                footerCEN.New_("ENLACE A OPCIONES", "Bla bla bla descripcion de opciones.");
                footerCEN.New_("ENLACE A FAQs", "Bla bla bla descripcion de FAQs.");
                footerCEN.New_("ENLACE A AYUDA", "Bla bla bla descripcion de ayuda.");


                IdiomaCEN idiomaCEN = new IdiomaCEN ();
                idiomaCEN.New_ ("Spanish", "Descripcion");


                NotificacionesCEN notificaciones1 = new NotificacionesCEN ();
                int notificacionID1 = notificaciones1.New_ (email2, "Te estas portando mal, jummm", moderadorID1);

                NotificacionesCEN notificaciones2 = new NotificacionesCEN ();
                int notificacionID2 = notificaciones2.New_ (email3, "Cambiate el nick, no me gusta", moderadorID1);

                NotificacionesCEN notificaciones3 = new NotificacionesCEN ();
                int notificacionID3 = notificaciones3.New_ (email3, "Ya tienes muchas faltas, eh??", moderadorID1);

                NotificacionesCEN notificaciones4 = new NotificacionesCEN ();
                int notificacionID4 = notificaciones4.New_ (email4, "No te lo digo mas veces, te vamos a echar de aqui", moderadorID2);


                ReporteCEN reporteCEN1 = new ReporteCEN ();
                reporteCEN1.New_ (DateTime.Today);

                ReporteCEN reporteCEN2 = new ReporteCEN ();
                reporteCEN2.New_ (DateTime.Today);

                ReporteCEN reporteCEN3 = new ReporteCEN ();
                reporteCEN3.New_ (DateTime.Today);

                ReporteCEN reporteCEN4 = new ReporteCEN ();
                reporteCEN4.New_ (DateTime.Today);

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
