using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Modelo;

namespace Vista
{
    public partial class Form1 : Form
    {
        private Alumno alumno;
        public Form1()
        {
            InitializeComponent();
            AlumnoBL alumnoBL = new AlumnoBL();
            alumnoBL.startDB();
        }

        private void LoadAll()
        {
            AlumnoBL alumnoBL = new AlumnoBL();
            BindingList<Alumno> alumnos = new BindingList<Alumno>();
            alumnos = alumnoBL.cargatodo();
            dgvAlumnos.DataSource = alumnos;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlumnoBL alumnoBL = new AlumnoBL();
            alumnoBL.startDB();
            LoadAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String edad = txtEdad.Text;
            String craest = txtCraest.Text;

            if(String.IsNullOrEmpty(nombre) || String.IsNullOrEmpty(edad) || String.IsNullOrEmpty(craest))
            {
                MessageBox.Show("Its empty");
                return;
            }
            AlumnoBL alumnoBL = new AlumnoBL();
            alumnoBL.insertar(nombre, edad, craest);
            LoadAll();
        }
    }
}
