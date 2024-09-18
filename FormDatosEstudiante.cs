using System;
using System.Windows.Forms;

namespace JhonZuluagaAPP
{

    public partial class FormDatosEstudiante : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;

        public FormDatosEstudiante()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Instrumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "costoClase";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "NumeroClases";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(188, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 26);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(188, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 26);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(187, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(190, 336);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 28);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Genero";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 35);
            this.button2.TabIndex = 13;
            this.button2.Text = "Calcular/mostrar reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(530, 430);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormDatosEstudiante
            // 
            this.AccessibleName = "Tabla";
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 486);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "FormDatosEstudiante";
            this.Load += new System.EventHandler(this.FormDatosEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de GestionEstudiantes con los datos del formulario
            GestionEstudiantes estudiante = new GestionEstudiantes
            {
                Id = textBox1.Text,
                Nombre = textBox2.Text,
                Instrumento = comboBox1.SelectedItem.ToString(),
                CostoClase = double.Parse(textBox3.Text),
                NumeroClases = int.Parse(textBox4.Text)
            };

            // Calcular el costo total
            double costoTotal = estudiante.CalcularCostoTotal();

            // Crear y mostrar el formulario de reporte
            FormReporte reporte = new FormReporte();
            reporte.SetReporte(estudiante, costoTotal);
            reporte.Show();



        }

        private void FormDatosEstudiante_Load(object sender, EventArgs e)
        {
            // Agrega los géneros al comboBox
            comboBox2.Items.Add("Masculino");
            comboBox2.Items.Add("Femenino");

            // Agregar instrumentos al comboBox1
            comboBox1.Items.Add("Piano");
            comboBox1.Items.Add("Guitarra");
            comboBox1.Items.Add("Violín");
            comboBox1.Items.Add("Batería");
            comboBox1.Items.Add("Canto");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el instrumento seleccionado
            string instrumentoSeleccionado = comboBox1.SelectedItem.ToString();

            // Declara una variable para el costo de la clase
            double costoClase;

            // Asigna un costo basado en el instrumento seleccionado
            switch (instrumentoSeleccionado)
            {
                case "Piano":
                    costoClase = 50.0;
                    break;
                case "Guitarra":
                    costoClase = 40.0;
                    break;
                case "Violín":
                    costoClase = 45.0;
                    break;
                case "Batería":
                    costoClase = 55.0;
                    break;
                case "Canto":
                    costoClase = 30.0;
                    break;
                default:
                    costoClase = 0.0;
                    break;
            }

            // Actualiza el TextBox con el costo de la clase
            textBox3.Text = costoClase.ToString();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el género seleccionado
            string generoSeleccionado = comboBox2.SelectedItem.ToString();

            // Actualiza el texto del Label con el género seleccionado
            label6.Text = "Género: " + generoSeleccionado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia de GestionEstudiantes
            GestionEstudiantes estudiante = new GestionEstudiantes();

            // Asignar valores a los atributos de GestionEstudiantes
            estudiante.Id = textBox1.Text;
            estudiante.Nombre = textBox2.Text;
            estudiante.Instrumento = comboBox1.SelectedItem.ToString();
            estudiante.Genero = comboBox2.SelectedItem.ToString();

            // Validar y asignar el costo de clase basado en el instrumento seleccionado
            switch (estudiante.Instrumento)
            {
                case "Piano":
                    estudiante.CostoClase = 50.0;
                    break;
                case "Guitarra":
                    estudiante.CostoClase = 40.0;
                    break;
                case "Violín":
                    estudiante.CostoClase = 45.0;
                    break;
                case "Batería":
                    estudiante.CostoClase = 55.0;
                    break;
                case "Canto":
                    estudiante.CostoClase = 30.0;
                    break;
                default:
                    estudiante.CostoClase = 0.0;
                    break;
            }

            // Validar el número de clases ingresadas
            if (int.TryParse(textBox4.Text, out int numeroClases))
            {
                estudiante.NumeroClases = numeroClases;
            }
            else
            {
                MessageBox.Show("Número de clases inválido. Por favor ingrese un valor numérico.");
                return;
            }

            // Guardar los datos del estudiante (puedes usar una estructura de datos global o base de datos)
            // Aquí solo lo estamos guardando en una variable temporal
            // En una aplicación real, deberías guardar estos datos en una estructura de datos o base de datos

            MessageBox.Show("Registro guardado exitosamente.");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}