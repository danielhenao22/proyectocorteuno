using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AutoServicio.Navigation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirVentanaA));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirVentanaV));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirVentanaU));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void AbrirVentanaA()
        {
            Alquiler vista2 = new Alquiler();
            vista2.ShowDialog();
        }

        private void AbrirVentanaU()
        {
            Usuario vista2 = new Usuario();
            vista2.ShowDialog();
        }

        private void AbrirVentanaV()
        {
            Vehiculo vista2 = new Vehiculo();
            vista2.ShowDialog();
        }
    }
}
