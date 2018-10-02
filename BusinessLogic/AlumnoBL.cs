using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DataAccess;
using System.ComponentModel;

namespace BusinessLogic
{
    public class AlumnoBL
    {

        public AlumnoBL() { }

        public void startDB()
        {
            AlumnoDA alumnoDA = new AlumnoDA();
            alumnoDA.InitializeDB();
        }

        public BindingList<Alumno> cargatodo()
        {
            AlumnoDA alumnoDA = new AlumnoDA();
            return alumnoDA.GetAlumnos();
        }

        public void insertar(String nombre, String edad, String craest)
        {
            AlumnoDA alumnoDA = new AlumnoDA();
            alumnoDA.Insert(nombre, edad, craest);
        }

        public void actualizar(String nombre, String edad, String craest)
        {
            AlumnoDA alumnoDA = new AlumnoDA();
            alumnoDA.Update(nombre, edad, craest);
        }
    }
}
