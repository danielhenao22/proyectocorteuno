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
    public partial class Usuario : Form
    {
        ClsUsuario usuario;
        ClsCombos combos;
        LinkedList<String> ciudades;
        LinkedList<String> generos;
        LinkedList<String> tiposDoc;
        public Usuario()
        {
            InitializeComponent();
            usuario = new ClsUsuario();
            combos = new ClsCombos();
            ciudades = new LinkedList<string>();
            generos = new LinkedList<string>();
            tiposDoc = new LinkedList<string>();
            llenarCombos();
        }

        public void llenarCombos()
        {
            ciudades = combos.buscarTodosCiudad();
            generos = combos.buscarTodosGenero();
            tiposDoc = combos.buscarTodosTipoDoc();            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int documento = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
            String nombre = jNombre.Text;
            String apellido = jApellido.Text;
            int edad = Convert.ToInt32((!jEdad.Text.Equals("")) ? jEdad.Text : "0");
            int genero= Convert.ToInt32((!jCGenero.Text.Equals("")) ? jEdad.Text : "0");
            int tipoDoc = Convert.ToInt32((!jCTipoDoc.Text.Equals("")) ? jEdad.Text : "0");
            int ciu = Convert.ToInt32((!jCCuidad.Text.Equals("")) ? jCCuidad.Text : "0");
            


            if (usuario.guardar(documento,nombre,apellido,edad,genero,tipoDoc, ciu))
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

            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");

            LinkedList<String> temp = new LinkedList<String>();
            temp = usuario.buscar(Id);

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                jDocumento.Text = temp.ElementAt(0);
                jNombre.Text = temp.ElementAt(1);
                jApellido.Text = temp.ElementAt(2);
                jEdad.Text = temp.ElementAt(3);
                jCGenero.Text = temp.ElementAt(4);
                jCTipoDoc.Text = temp.ElementAt(5);
                jCCuidad.Text = temp.ElementAt(6);
            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int documento = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
            String nombre = jNombre.Text;
            String apellido = jApellido.Text;
            int edad = Convert.ToInt32((!jEdad.Text.Equals("")) ? jEdad.Text : "0");
            int genero = Convert.ToInt32((!jCGenero.Text.Equals("")) ? jEdad.Text : "0");
            int tipoDoc = Convert.ToInt32((!jCTipoDoc.Text.Equals("")) ? jEdad.Text : "0");
            int ciu = Convert.ToInt32((!jCCuidad.Text.Equals("")) ? jCCuidad.Text : "0");

            if (usuario.modificar(documento, nombre, apellido, edad, genero, tipoDoc, ciu))
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
            
            int codigo = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
            if (usuario.eliminar(codigo))
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
            int documento = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
            String nombre = jNombre.Text;
            String apellido = jApellido.Text;
            int edad = Convert.ToInt32((!jEdad.Text.Equals("")) ? jEdad.Text : "0");
            int genero = Convert.ToInt32((!jCGenero.Text.Equals("")) ? jEdad.Text : "0");
            int tipoDoc = Convert.ToInt32((!jCTipoDoc.Text.Equals("")) ? jEdad.Text : "0");
            int ciu = Convert.ToInt32((!jCCuidad.Text.Equals("")) ? jCCuidad.Text : "0");



           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");

            LinkedList<String> temp = new LinkedList<String>();
           

            if (temp.Count > 0)
            {
                jId.Enabled = false;
                //botonModificar enalble true
                //BotonEliminar enable true
                jDocumento.Text = temp.ElementAt(0);
                jNombre.Text = temp.ElementAt(1);
                jApellido.Text = temp.ElementAt(2);
                jEdad.Text = temp.ElementAt(3);
                jCGenero.Text = temp.ElementAt(4);
                jCTipoDoc.Text = temp.ElementAt(5);
                jCCuidad.Text = temp.ElementAt(6);
            }
            else
            {
                MessageBox.Show("No se encuentra el registro");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int documento = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
            String nombre = jNombre.Text;
            String apellido = jApellido.Text;
            int edad = Convert.ToInt32((!jEdad.Text.Equals("")) ? jEdad.Text : "0");
            int genero = Convert.ToInt32((!jCGenero.Text.Equals("")) ? jEdad.Text : "0");
            int tipoDoc = Convert.ToInt32((!jCTipoDoc.Text.Equals("")) ? jEdad.Text : "0");
            int ciu = Convert.ToInt32((!jCCuidad.Text.Equals("")) ? jCCuidad.Text : "0");

           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32((!jId.Text.Equals("")) ? jId.Text : "0");
           
        }
    }
}
