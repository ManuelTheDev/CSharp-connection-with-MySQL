using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public class AlumnoDA
    {

        public AlumnoDA() { }
        //I erased the connection info for security purposes
        //I can find them at my laptop or at my phone
        private const String SERVER = "";
        private const String DATABASE = "";
        private const String UID = "";
        private const String PASSWORD = "";
        private const String SSLM = "none";
        private const String PORT = "3306";
        private string connectionString;
        private static MySqlConnection dbConn;

        public void InitializeDB()
        {

            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", SERVER, PORT, UID, PASSWORD, DATABASE, SSLM);

            dbConn = new MySqlConnection(connectionString);
        }

        public BindingList<Alumno> GetAlumnos()
        {
            BindingList<Alumno> alumnos = new BindingList<Alumno>();

            String query = "select * from lp2.ALUMNO";

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String nombre = reader.GetString("Nombre");
                int edad = int.Parse(reader.GetString("Edad"));
                float craest = float.Parse(reader.GetString("Craest"));
                Alumno a = new Alumno();
                a.Nombre = nombre;
                a.Edad = edad;
                a.Craest = craest;
                alumnos.Add(a);
            }

            dbConn.Close();

            return alumnos;
        }

        public void Insert(String nombre, String edad, String craest)
        {
            String query = String.Format("insert into lp2.ALUMNO(NOMBRE, EDAD, CRAEST) VALUES ('{0}', '{1}', '{2}')", nombre, edad, craest);
            
            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public void Update(String nombre, String edad, String craest)
        {
            String query = String.Format("UPDATE lp2.ALUMNO SET nombre='{0}', edad = '{1}', craest = '{2}' where ID='51'", nombre, edad, craest);

            MySqlCommand cmd = new MySqlCommand(query, dbConn);

            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        public void Delete()
        {

        }

    }
}
