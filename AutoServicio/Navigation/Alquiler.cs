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
            LinkedList<String> tipoDocumentos = new LinkedList<String>();
            tipoDocumentos = combo.buscarTodosTipoDoc();

            BindingList<Item> tipo = new BindingList<Item>();
            tipo.Add(new Item("Tipo de Documento", 0));

            for (int i = 0; i < tipoDocumentos.Count; i++)
            {                
                tipo.Add(new Item((tipoDocumentos.ElementAt(i)), Convert.ToInt32(tipoDocumentos.ElementAt(i))));
            }
            

            jCUsuario.DisplayMember = "Name";
            jCUsuario.ValueMember = "Value";
            jCUsuario.DataSource = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(jCodigo.Text);
            int usuar = Convert.ToInt32(jCUsuario.Text);
            String veh = Convert.ToString((!jCVehiculo.Text.Equals("")) ? jCVehiculo.Text : "0");
            DateTime dia = jDFecha.Value.Date;

            alquiler.guardar(usuar, veh,dia);

           
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
                jCodigo.Text = temp.ElementAt(0);
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
            int codigo = Convert.ToInt32((!jCodigo.Text.Equals("")) ? jCodigo.Text : "0");
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
                jCodigo.Text = temp.ElementAt(0);
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
    }

   
}
