using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JhonZuluagaAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Configura el TextBox para que use un carácter de máscara
            textBox1.PasswordChar = '*';  // Puedes usar '*' o cualquier otro carácter de tu elección
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si la contraseña es correcta
            if (textBox1.Text == "123")
            {
                // Crea una instancia del segundo formulario
                FormDatosEstudiante formDatosEstudiante = new FormDatosEstudiante();

                // Muestra el segundo formulario
                formDatosEstudiante.Show();

                // Opcionalmente, puedes ocultar el primer formulario si ya no es necesario
                this.Hide();
            }
            else
            {
                // Muestra un mensaje de error si la contraseña es incorrecta
                MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiar el TextBox de contraseña
                textBox1.Clear();
            }
        }

    }
}