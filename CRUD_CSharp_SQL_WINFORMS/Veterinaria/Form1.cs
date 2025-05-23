using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

        }

        private void btAgregarMascota_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            dataGridView1.DataSource = MascotaDAL.MostrarMascotas();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.nombre = tbNombre.Text;
            mascota.edad = Convert.ToInt32(tbEdad.Text);
            mascota.tipo = tbTipo.Text;
            mascota.color = tbColor.Text;
            tbNombre.Clear();
            tbEdad.Clear();
            tbTipo.Clear();
            tbColor.Clear();

            int respuesta = MascotaDAL.AgregarMascota(mascota);

            if (respuesta == 1)
            {
                MessageBox.Show("Operacion exitosa");
            }
            else
            {
                MessageBox.Show("Operacion exitosa");
            }
        }

        private void btnCancelarAgregarMascota_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbEdad.Clear();
            tbTipo.Clear();
            tbColor.Clear();
        }
    }

}
