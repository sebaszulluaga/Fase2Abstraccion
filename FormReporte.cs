using System;
using System.Windows.Forms;

namespace JhonZuluagaAPP
{
    public partial class FormReporte : Form
    {
        // Definición de etiquetas y botones
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelGenero;
        private Label labelInstrumento;
        private Button button1;

        public FormReporte()
        {
            InitializeComponent();
        }

        // Método para establecer el reporte y los datos del estudiante
        public void SetReporte(GestionEstudiantes estudiante, double costoTotal)
        {
            // Asignar los valores a los controles del formulario
            label2.Text = estudiante.Nombre;  // Nombre
            label3.Text = estudiante.Id;      // ID
            labelGenero.Text = estudiante.Genero;  // Género
            labelInstrumento.Text = estudiante.Instrumento;  // Instrumento
            label6.Text = estudiante.NumeroClases.ToString();  // Número de clases
            label7.Text = estudiante.CostoClase.ToString("C");  // Costo por clase
            label8.Text = costoTotal.ToString("C");  // Costo total
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelInstrumento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Género";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ha sido matriculado con el instrumento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "el cual cursará en un lapso de:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "días, con un costo de clase de";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Para un total de matrícula por:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(100, 171);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(63, 20);
            this.labelGenero.TabIndex = 9;
            this.labelGenero.Text = "Género";
            this.labelGenero.Click += new System.EventHandler(this.labelGenero_Click);
            // 
            // labelInstrumento
            // 
            this.labelInstrumento.AutoSize = true;
            this.labelInstrumento.Location = new System.Drawing.Point(270, 171);
            this.labelInstrumento.Name = "labelInstrumento";
            this.labelInstrumento.Size = new System.Drawing.Size(95, 20);
            this.labelInstrumento.TabIndex = 10;
            this.labelInstrumento.Text = "Instrumento";
            // 
            // FormReporte
            // 
            this.ClientSize = new System.Drawing.Size(648, 437);
            this.Controls.Add(this.labelInstrumento);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte";
            this.Text = "Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelGenero_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
