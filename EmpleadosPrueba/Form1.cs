using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EmpleadosPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexion cn = new Conexion();

        void insertarEmpleado()
        {
            string cadena = "INSERT INTO empleados (nombre_completo, puesto, departamento) " +
                    "VALUES ('" + Txt_nombre.Text + "', '" + Txt_puesto.Text + "', '" + Txt_depto.Text + "')";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            insertarEmpleado();
           Txt_depto.Text = "";
           Txt_nombre.Text = "";
           Txt_puesto.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulta frmConsulta = new Consulta(); 
            frmConsulta.Show(); 
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
