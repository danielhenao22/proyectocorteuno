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
    public partial class Alquiler : Form
    {

        ClsAlquiler alquiler;
        ClsCombos combo;

        public Alquiler()
        {
            InitializeComponent();
            alquiler = new ClsAlquiler();
            combo = new ClsCombos();
            cargarCombos();
        }

        public void cargarCombos()
        {
            LinkedList<EntidadGen> usu = new LinkedList<EntidadGen>();
            usu = combo.buscarTodosUsuarios();

            BindingList<Item> tipo = new BindingList<Item>();
            tipo.Add(new Item("Usuario", 0));

            for (int i = 0; i < usu.Count; i++)
            {

                tipo.Add(new Item((usu.ElementAt(i).nombre), Convert.ToInt32(usu.ElementAt(i).id)));
                MessageBox.Show("nn: " + usu.ElementAt(i).nombre +" num:"+Convert.ToInt32(usu.ElementAt(i).id));
            }
            

            jCUsuario.DisplayMember = "Name";
            jCUsuario.ValueMember = "Value";
            jCUsuario.DataSource = tipo;

            LinkedList<EntidadGen> carros = new LinkedList<EntidadGen>();
            carros = combo.buscarTodosVehiculos();

            BindingList<Item> car = new BindingList<Item>();
            car.Add(new Item("Carro / valor", 0));

            for (int i = 0; i < carros.Count; i++)
            {
                car.Add(new Item((carros.ElementAt(i).nombre), Convert.ToInt32(carros.ElementAt(i).id)));
            }


            jCVehiculo.DisplayMember = "Name";
            jCVehiculo.ValueMember = "Value";
            jCVehiculo.DataSource = car;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usuar = jCUsuario.SelectedIndex;
            String veh = jCVehiculo.Text;
            DateTime dia = jDFecha.Value.Date;

            MessageBox.Show(" -" + usuar + " ," + dia+" ," + veh);
            if (alquiler.guardar(usuar, veh, dia))
            {
                MessageBox.Show("Guardo");
            }
            else
            {
                MessageBox.Show("No Guardo");
            }

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
          

            LinkedList<String> temp = new LinkedList<String>();
            temp = alquiler.buscar(Id);

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                
                jCUsuario.Text = temp.ElementAt(1);
                jCVehiculo.Text = temp.ElementAt(2);
                jDFecha.Text = temp.ElementAt(3);
               
            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
            int usuar = Convert.ToInt32((!jCUsuario.Text.Equals("")) ? jCUsuario.Text : "0");
            String veh = Convert.ToString((!jCVehiculo.Text.Equals("")) ? jCVehiculo.Text : "0");
            DateTime fecha = jDFecha.Value;

            if (alquiler.modificar(codigo, usuar, veh, fecha))
            {
                //limpiar();
                MessageBox.Show("Modicado con exito");
                jId.Enabled = true;
                //listar();

            }
            else
            {
                MessageBox.Show("Error al guardar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
            if (alquiler.eliminar(Id))
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
     
            int usuar = Convert.ToInt32((!jCUsuario.Text.Equals("")) ? jCUsuario.Text : "0");
            String veh = Convert.ToString((!jCVehiculo.Text.Equals("")) ? jCVehiculo.Text : "0");
           // DateTime dia = Convert.ToInt32((!jDFecha.Text.Equals("")) ? jDFecha.Text : "0");




            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
            int usuar = Convert.ToInt32((!jCUsuario.Text.Equals("")) ? jCUsuario.Text : "0");
            String veh = Convert.ToString((!jCVehiculo.Text.Equals("")) ? jCVehiculo.Text : "0");
            String fecha = jDFecha.Value.ToString("yyyy-MM-dd");

         //   if (alquiler.modificar(codigo, usuar, veh, fecha))
          //  {
                //limpiar();
         //       MessageBox.Show("Modicado con exito");
          //      jId.Enabled = true;
                //listar();

        //    }
         //   else
          //  {
         //       MessageBox.Show("Error al guardar.");
          //  }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");


            LinkedList<String> temp = new LinkedList<String>();
           // temp = alquiler.buscarP(Id);

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                jCUsuario.Text = temp.ElementAt(1);
                jCVehiculo.Text = temp.ElementAt(2);
                jDFecha.Text = temp.ElementAt(3);

            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
         //   if (alquiler.eliminarP(Id))
         //   {
                //Limpiar
                MessageBox.Show("Eliminado con exito");
                //Listar
       //     }
         //   else
         //   {
                MessageBox.Show("No se pudo eliminar");
           // }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void jCUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jCVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

   
}
