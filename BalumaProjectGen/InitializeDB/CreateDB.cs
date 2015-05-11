
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BalumaProjectGenNHibernate.EN.BalumaProject;
using BalumaProjectGenNHibernate.CEN.BalumaProject;
using BalumaProjectGenNHibernate.CAD.BalumaProject;

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
            var admin = new AdministradorCEN();
            //admin.CrearAdministrador("admin", "admin", "admin", "admin", "admin");

            var usuario = new UsuarioCEN();
            //usuario.CrearUsuario("usuario1", "usuario1", "usuario1", "usuario1", "usuario1");
            //usuario.CrearUsuario("usuario2", "usuario2", "usuario2", "usuario2", "usuario2");
            //usuario.CrearUsuario("usuario3", "usuario3", "usuario3", "usuario3", "usuario3");
            //usuario.CrearUsuario("usuario4", "usuario4", "usuario4", "usuario4", "usuario4");
            //usuario.CrearUsuario("usuario5", "usuario5", "usuario5", "usuario5", "usuario5");
            //usuario.CrearUsuario("usuario6", "usuario6", "usuario6", "usuario6", "usuario6");
            //usuario.CrearUsuario("usuario7", "usuario7", "usuario7", "usuario7", "usuario7");

            var cliente = new ClienteCEN();
            //cliente.CrearCliente("cliente1", "cliente1", "cliente1",
              //  "cliente1", "cliente1", "cliente1", "cliente1", "cliente1",
            //  "cliente1", "cliente1", "cliente1");
            //cliente.CrearCliente("cliente2", "cliente2", "cliente2",
              //  "cliente2", "cliente2", "cliente2", "cliente2", "cliente2",
            //"cliente2", "cliente2", "cliente2");
            //cliente.CrearCliente("cliente3", "cliente3", "cliente3",
              //  "cliente3", "cliente3", "cliente3", "cliente3", "cliente3",
            //"cliente3", "cliente3", "cliente3");
            //cliente.CrearCliente("cliente4", "cliente4", "cliente4",
              //  "cliente4", "cliente4", "cliente4", "cliente4", "cliente4",
            //"cliente4", "cliente4", "cliente4");
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
