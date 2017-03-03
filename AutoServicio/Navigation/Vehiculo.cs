using Platform.Modeler.DAO;
using Platform.Modeler.Entity;
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
        ClsCombos combos;
        public Vehiculo()
        {
            InitializeComponent();
            combo = new ClsCombos();
            vehiculo = new ClsVehiculo();
            cargarLista();
        }

        public void cargarLista()
        {
            LinkedList<EntidadVeh> tipoDocumentos = new LinkedList<EntidadVeh>();
            tipoDocumentos = combo.condicionalselect();

            dataGridView1.Rows.Clear();
            BindingList<Item> tipo = new BindingList<Item>();

          

            foreach (EntidadVeh v in tipoDocumentos)
            {
                dataGridView1.Rows.Add(v.placa);
                dataGridView1.Rows.Add(v.npuertas);
                dataGridView1.Rows.Add(v.color);
                dataGridView1.Rows.Add(v.valor);
                dataGridView1.Rows.Add(v.marcaId);
            }


         
        }


            jCMarca.DisplayMember = "Name";
            jCMarca.ValueMember = "Value";
            jCMarca.DataSource = ma;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            String numeroP = jNumeroP.Text;
            String color = jColor.Text;
            String valor = jValorDia.Text;
            int marca = jCMarca.SelectedIndex;


            if (vehiculo.guardar(placa, numeroP, color, valor, marca))
            {
                MessageBox.Show("Guardado con exito");
            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            LinkedList<String> temp = new LinkedList<String>();
            temp = vehiculo.buscar(placa);
            if (temp.Count > 0)
            {
                jNumeroP.Text = temp.ElementAt(0);
                jColor.Text = temp.ElementAt(1);
                jValorDia.Text = temp.ElementAt(2);
                jCMarca.SelectedIndex = Convert.ToInt32(temp.ElementAt(3));              
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
            int marca = jCMarca.SelectedIndex;

            if (vehiculo.modificar(placa, numeroP, color, valor, marca))
            {
                MessageBox.Show("Modicado con exito");
            }
            else
            {
                MessageBox.Show("Error al modificar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String codigo = jPlaca.Text;
            if (vehiculo.eliminar(codigo))
            {
                MessageBox.Show("Eliminado con exito");
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
            int marca = jCMarca.SelectedIndex;


            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;
            int numeroP = Convert.ToInt32((!jNumeroP.Text.Equals("")) ? jNumeroP.Text : "0");
            String color = jColor.Text;
            int valor = Convert.ToInt32((!jValorDia.Text.Equals("")) ? jValorDia.Text : "0");
            int marca = jCMarca.SelectedIndex;

           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String placa = jPlaca.Text;

            LinkedList<String> temp = new LinkedList<String>();
            

            if (temp.Count > 0)
            {
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
            String codigo = jPlaca.Text;
            
        }
    }
}
