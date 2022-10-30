using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuestionario
{

    public partial class FormCuestionario : Form
    {
        int puntaje;
        int correctas;
        int incorrectas;
        int seleccion = 1;
        public FormCuestionario()

        {
            InitializeComponent();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            if (MessageBox.Show("Bienvenido al 1 cuestionario", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Pregunta1.Text = "¿Que es Herencia?";
                this.Opcion1.Text = "Es un entorno empresarial que proporciona un enfoque para el diseño, planificación, implementación y gobierno de una arquitectura empresarial de información. ";
                this.Opcion2.Text = "Es un componente del negocio en las empresas para las tecnologias de información.";
                this.Opcion3.Text = "Es un framework de Arquitectura Empresarial que proporciona un enfoque para el diseño, planificación, implementación y gobierno de una arquitectura empresarial de información.";
                this.Opcion4.Text = "Es un requisito para crear una empresa.";
            }
            else
            {
                Application.Exit();
            }
        }
        private void pregunta2()
        {
            this.Pregunta1.Text = "¿Que es Clase?";
            this.Opcion1.Text = "Tener un bajo costo.";
            this.Opcion2.Text = "Incluir una lista de estandares recomendados.";
            this.Opcion3.Text = "Desarrollar una estructura modelo para empresa.";
            this.Opcion4.Text = "Ninguna de las anteriores.";
            seleccion++;
        }
        private void pregunta3()
        {
            this.Pregunta1.Text = "¿Que es un Objeto?";
            this.Opcion1.Text = "Tener un bajo costo.";
            this.Opcion2.Text = "Incluir una lista de estandares recomendados.";
            this.Opcion3.Text = "Desarrollar una estructura modelo para empresa.";
            this.Opcion4.Text = "Ninguna de las anteriores.";
            seleccion++;
        }

        private void Limpiar()
        {
            this.Opcion1.Checked = true;
        }

        private void BtnVerficar1_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (Opcion1.Checked == true)
                    {
                        puntaje = puntaje + 500;
                        Puntaje.Text = puntaje.ToString();
                        correctas = correctas + 1;
                        LbCorrectas.Text = correctas.ToString();
                    }
                    else
                    {
                        incorrectas = incorrectas + 1;
                        LbIncorrectas.Text = incorrectas.ToString();

                    }
                    pregunta2();
                    Limpiar();

                    break;
                case 2:
                    if (Opcion3.Checked == true)
                    {
                        puntaje = puntaje + 500;
                        Puntaje.Text = puntaje.ToString();
                        correctas = correctas + 1;
                        LbCorrectas.Text = correctas.ToString();
                    }
                    else
                    {
                        incorrectas = incorrectas + 1;
                        LbIncorrectas.Text = incorrectas.ToString();

                    }
                    pregunta3();
                    Limpiar();
                    break;
            }
        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void opcion3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
