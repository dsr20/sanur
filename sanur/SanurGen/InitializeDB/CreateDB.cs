
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CEN.Sanur;
using SanurGenNHibernate.CAD.Sanur;

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
        SqlConnection cnn = new SqlConnection (@"Server=(local)\SQLEXPRESS; database=master; integrated security=yes");

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
                MedicoCEN medico = new MedicoCEN ();
                medico.New_ ("pepe", "gacel", false, "gacel", "ivorra", SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum.traumatologia);

                MedicoCEN medicoCEN = new MedicoCEN ();
                medicoCEN.New_ ("Pablo", "pablo", true, "a@a.com", "Carmona", SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum.ginecologia);

                PacienteCEN pcen = new PacienteCEN ();
                pcen.New_ ("Gacel", "Ivorra", new DateTime (1991, 1, 9), "600255555", "Doctor Jimenez", "Espa�a", 1232345, 48672144, "H", "g@g.com", "Alicante", "B+", "03005", "San Juan", "Alicante");

                MedicoCEN mcen = new MedicoCEN ();
                mcen.New_ ("Sergio", "sergio", false, "s@s.com", "apellido1 apellido2", SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum.ginecologia);

                AdministrativoCEN acen = new AdministrativoCEN ();
                acen.New_ ("Andrea", "administrativo", false, "administrativo", "Rodriguez");

                AdministradorCEN admincen = new AdministradorCEN();
                admincen.New_("admin", "1234", true, "admin@com", "admin");
                EpisodioCEN epcen = new EpisodioCEN ();
                epcen.New_ (1, new DateTime (2000, 10, 20), "Dolor en el torax", 4, SanurGenNHibernate.Enumerated.Sanur.EstadoEnum.triaje, false, false);

                TriageCEN triaje = new TriageCEN ();
                triaje.New_ (1, SanurGenNHibernate.Enumerated.Sanur.PrioridadEnum.normal, "Dolor de cabeza", SanurGenNHibernate.Enumerated.Sanur.EspecialidadEnum.traumatologia, "Esta muy nervioso");

                epcen.AsignarTriage (1, 1);
                /*List<SanurGenNHibernate.EN.Mediaplayer.MusicTrackEN> musicTracks = new List<SanurGenNHibernate.EN.Mediaplayer.MusicTrackEN>();
                 * SanurGenNHibernate.EN.Mediaplayer.UserEN userEN = new SanurGenNHibernate.EN.Mediaplayer.UserEN();
                 *
                 * SanurGenNHibernate.EN.Mediaplayer.ArtistEN artistEN = new SanurGenNHibernate.EN.Mediaplayer.ArtistEN();
                 * SanurGenNHibernate.EN.Mediaplayer.MusicTrackEN musicTrackEN = new SanurGenNHibernate.EN.Mediaplayer.MusicTrackEN();
                 * SanurGenNHibernate.CEN.Mediaplayer.ArtistCEN artistCEN = new SanurGenNHibernate.CEN.Mediaplayer.ArtistCEN();
                 * SanurGenNHibernate.CEN.Mediaplayer.UserCEN userCEN = new SanurGenNHibernate.CEN.Mediaplayer.UserCEN();
                 * SanurGenNHibernate.CEN.Mediaplayer.MusicTrackCEN musicTrackCEN = new SanurGenNHibernate.CEN.Mediaplayer.MusicTrackCEN();
                 * SanurGenNHibernate.CEN.Mediaplayer.PlayListCEN playListCEN = new SanurGenNHibernate.CEN.Mediaplayer.PlayListCEN();
                 *
                 *              //Add Users
                 * userEN.Email = "user@user.com";
                 * userEN.Name = "user";
                 * userEN.Surname = "userSurname";
                 * userEN.Password = "user";
                 * userCEN.New_(userEN.Name, userEN.Surname, userEN.Email, userEN.Password);
                 *
                 * //Add Music Track1
                 * musicTrackEN.Id = "http://www2.b3ta.com/mp3/Beer Beer Beer (YOB mix).mp3";
                 * musicTrackEN.Format = "mp3";
                 * musicTrackEN.Lyrics = "Beer Beer Beer Beer Beer Beer ..";
                 * musicTrackEN.Name = "Beer Beer Beer";
                 * musicTrackEN.Company = "Company";
                 * musicTrackEN.Cover = "http://www.tomasabraham.com.ar/cajadig/2007/images/nro18-2/beer1.jpg";
                 * musicTrackEN.Price = 20;
                 * musicTrackEN.Rating = 5;
                 * musicTrackEN.CommunityRating = 5;
                 * musicTrackEN.Duration = 200;
                 * musicTrackCEN.New_(musicTrackEN.Id, musicTrackEN.Format, musicTrackEN.Lyrics, musicTrackEN.Name,
                 *  musicTrackEN.Company, musicTrackEN.Cover, musicTrackEN.CommunityRating, musicTrackEN.Rating,
                 *  musicTrackEN.Price, musicTrackEN.Duration);
                 * musicTracks.Add(musicTrackEN);
                 * musicTrackCEN.AsignUser(musicTrackEN.Id,userEN.Email);
                 *
                 * //Define Album
                 * //SanurGenNHibernate.CEN.Mediaplayer.AlbumCEN albumCEN = new SanurGenNHibernate.CEN.Mediaplayer.AlbumCEN();
                 * //albumCEN.New_("Album 1", "This is a Album 1", artists, musicTracks);*/
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
