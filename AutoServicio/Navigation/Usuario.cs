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
            combos = new ClsCombos();
            cargarCombos();
            
        }

        private void cargarCombos()
        {
            LinkedList<EntidadGen> tipoDocumentos = new LinkedList<EntidadGen>();
            tipoDocumentos = combos.buscarTodosTipoDoc();

            BindingList<Item> tipo = new BindingList<Item>();
            tipo.Add(new Item("Tipo Doc", 0));

            for (int i = 0; i < tipoDocumentos.Count; i++)
            {
                tipo.Add(new Item((tipoDocumentos.ElementAt(i).nombre), Convert.ToInt32(tipoDocumentos.ElementAt(i).id)));
            }


            jCTipoDoc.DisplayMember = "Name";
            jCTipoDoc.ValueMember = "Value";
            jCTipoDoc.DataSource = tipo;

            LinkedList<EntidadGen> genero = new LinkedList<EntidadGen>();
            genero = combos.buscarTodosGenero();

            BindingList<Item> gen = new BindingList<Item>();
            gen.Add(new Item("Genero", 0));

            for (int i = 0; i < genero.Count; i++)
            {
                gen.Add(new Item((genero.ElementAt(i).nombre), Convert.ToInt32(genero.ElementAt(i).id)));
            }


            jCGenero.DisplayMember = "Name";
            jCGenero.ValueMember = "Value";
            jCGenero.DataSource = gen;

            LinkedList<EntidadGen> ciudad = new LinkedList<EntidadGen>();
            ciudad = combos.buscarTodosCiudad();

            BindingList<Item> cit = new BindingList<Item>();
            cit.Add(new Item("Seleccione Ciudad", 0));

            for (int i = 0; i < ciudad.Count; i++)
            {
                cit.Add(new Item((ciudad.ElementAt(i).nombre), Convert.ToInt32(ciudad.ElementAt(i).id)));
            }


            jCCuidad.DisplayMember = "Name";
            jCCuidad.ValueMember = "Value";
            jCCuidad.DataSource = cit;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            int documento = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
            String nombre = jNombre.Text;
            String apellido = jApellido.Text;
            int edad = Convert.ToInt32((!jEdad.Text.Equals("")) ? jEdad.Text : "0");
            int genero = jCGenero.SelectedIndex;
            int tipoDoc = jCTipoDoc.SelectedIndex;
            int ciu = jCCuidad.SelectedIndex;
            


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

            int Id = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");

            LinkedList<String> temp = new LinkedList<String>();
            temp = usuario.buscar(Id);

            if (temp.Count > 0)
            {                
                jDocumento.Text = temp.ElementAt(0);
                jNombre.Text = temp.ElementAt(1);
                jApellido.Text = temp.ElementAt(2);
                jEdad.Text = temp.ElementAt(3);
                jCGenero.SelectedIndex = Convert.ToInt32(temp.ElementAt(4));
                jCTipoDoc.SelectedIndex = Convert.ToInt32(temp.ElementAt(5));
                jCCuidad.SelectedIndex = Convert.ToInt32(temp.ElementAt(6));
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
            int genero = jCGenero.SelectedIndex;
            int tipoDoc = jCTipoDoc.SelectedIndex;
            int ciu = jCCuidad.SelectedIndex;



            if (usuario.modificar(documento, nombre, apellido, edad, genero, tipoDoc, ciu))
            {
                //limpiar();
                MessageBox.Show("modificado con exito");

            }
            else
            {
                MessageBox.Show("Error al modificar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
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
            int Id = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");

            LinkedList<String> temp = new LinkedList<String>();
           

            if (temp.Count > 0)
            {
                
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
            int codigo = Convert.ToInt32((!jDocumento.Text.Equals("")) ? jDocumento.Text : "0");
           
        }
    }
}
