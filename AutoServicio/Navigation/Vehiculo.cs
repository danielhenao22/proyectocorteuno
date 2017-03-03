using Platform.Modeler.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoServicio.Navigation
{
    public partial class Vehiculo : Form
    {
        ClsVehiculo vehiculo;
        public Vehiculo()
        {
            InitializeComponent();
            vehiculo = new ClsVehiculo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            String numeroP = jNumeroP.Text;
            String color = jColor.Text;
            String valor = jValorDia.Text;
            int marca = 1;


            if (vehiculo.guardar(placa, numeroP, color, valor, marca))
            {
                //limpiar();
                MessageBox.Show("Guardado con exito");

            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String placa = jId.Text;

            LinkedList<String> temp = new LinkedList<String>();
            temp = vehiculo.buscar(placa);

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                jPlaca.Text = temp.ElementAt(0);
                jNumeroP.Text = temp.ElementAt(1);
                jColor.Text = temp.ElementAt(2);
                jValorDia.Text = temp.ElementAt(3);
                jCMarca.Text = temp.ElementAt(4);
              
            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String placa = jPlaca.Text;
            String numeroP = jNumeroP.Text;
            String color = jColor.Text;
            String valor = jValorDia.Text;
            int marca = 1;

            if (vehiculo.modificar(placa, numeroP, color, valor, marca))
            {
                //limpiar();
                MessageBox.Show("Modicado con exito");
                jPlaca.Enabled = true;
                //listar();

            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String codigo = jId.Text;
            if (vehiculo.eliminar(codigo))
            {
                //Limpiar
                MessageBox.Show("Eliminado con exito");
                //Listar
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            int numeroP = Convert.ToInt32((!jNumeroP.Text.Equals("")) ? jNumeroP.Text : "0");
            String color = jColor.Text;
            int valor = Convert.ToInt32((!jValorDia.Text.Equals("")) ? jValorDia.Text : "0");
            int marca = 1;


            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            int numeroP = Convert.ToInt32((!jNumeroP.Text.Equals("")) ? jNumeroP.Text : "0");
            String color = jColor.Text;
            int valor = Convert.ToInt32((!jValorDia.Text.Equals("")) ? jValorDia.Text : "0");
            int marca = 1;

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String placa = jId.Text;

            LinkedList<String> temp = new LinkedList<String>();
            

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                jPlaca.Text = temp.ElementAt(0);
                jNumeroP.Text = temp.ElementAt(1);
                jColor.Text = temp.ElementAt(2);
                jValorDia.Text = temp.ElementAt(3);
                jCMarca.Text = temp.ElementAt(4);

            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String codigo = jId.Text;
            
        }
    }
}
