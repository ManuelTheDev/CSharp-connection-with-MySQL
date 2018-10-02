using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Alumno
    {
        private string nombre;
        private int edad;
        private float craest;

        public Alumno()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public float Craest { get => craest; set => craest = value; }
    }
}
