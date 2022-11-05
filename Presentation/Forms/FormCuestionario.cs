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


        private void Form1_Load(object sender, EventArgs e)
        {
            Iniciar();
        }
        private void Iniciar()
        {
            if (MessageBox.Show("Bienvenido al 1 cuestionario", "Evaluacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Pregunta1.Text = "¿Qué es un algoritmo?";
                this.Opcion1.Text = "Es una forma de representar gráficamente un conjunto de datos o valores mediante barras.";
                this.Opcion2.Text = "Diseños geométricos que se realizan con el objetivo de representar gráficamente ideas, procesos, soluciones, mecanismos o fenómenos para facilitar su comprensión.";
                this.Opcion3.Text = "Diagrama que describe un proceso, sistema o algoritmo informático.";
                this.Opcion4.Text = "Conjunto de pasos(instrucciones) para llegar a la solución de un problema";
            }
            else
            {
                Application.Exit();
            }
        }
        private void pregunta2()
        {
            this.Pregunta1.Text = "¿Cuáles de las siguientes opciones son lenguajes de programación?";
            this.Opcion1.Text = "Angular, Meteor, Laravel.";
            this.Opcion2.Text = "Java, Python, c#, Ruby.";
            this.Opcion3.Text = "Notepad++, Sublime Text, Komodo Edit.";
            this.Opcion4.Text = "HTML y CSS";
            seleccion++;
        }
        private void pregunta3()
        {
            this.Pregunta1.Text = "¿Qué es un compilador?";
            this.Opcion1.Text = "Programa informático que traduce todo el código fuente de un proyecto de software a código máquina antes de ejecutarlo.";
            this.Opcion2.Text = "Son como colecciones de herramientas, componentes y soluciones que puedes encontrar en un mismo paquete.";
            this.Opcion3.Text = "Aplicación para editar archivos de texto. Esto incluye códigos de todo tipo que también son textos escritos en un formato que la computadora puede entender.";
            this.Opcion4.Text = "Ninguna de las anteriores.";
            seleccion++;
        }
        private void pregunta4()
        {
            this.Pregunta1.Text = "¿Qué es un diagrama de flujo?";
            this.Opcion1.Text = "Representación grafica de un proceso o sistema.";
            this.Opcion2.Text = "Proceso de cambiar un programa para mejorar su estructura interna sin cambiar su funcionamiento.";
            this.Opcion3.Text = "Desarrollar una estructura modelo para empresa.";
            this.Opcion4.Text = "Es la parte de una aplicación web que la persona que la usa, ve e interactúa.";
            seleccion++;
        }
        private void pregunta5()
        {
            this.Pregunta1.Text = "¿Qué son los datos primitivos?";
            this.Opcion1.Text = "Conjunto de palabras o símbolos que contienen instrucciones para la computadora.";
            this.Opcion2.Text = "Representación grafica de un proceso o sistema.";
            this.Opcion3.Text = "Conjuntos de valores simples procesados por operaciones definidas por el lenguaje de programación.";
            this.Opcion4.Text = "Ventana, normalmente negra, donde se puede trabajar desde la línea de comandos.";
            seleccion++;
        }
        private void pregunta6()
        {
            this.Pregunta1.Text = "¿Cuáles de las siguientes opciones son operadores de datos?";
            this.Opcion1.Text = "Ruby, Sublime Text, C++";
            this.Opcion2.Text = "Aritméticos, Asignación, Incrementales y Relacionales.";
            this.Opcion3.Text = "int, char, float, doubel.";
            this.Opcion4.Text = "Ninguna de las anteriores.";
            seleccion++;
        }
        private void pregunta7()
        {
            this.Pregunta1.Text = "¿Cuáles son los operadores Lógicos?";
            this.Opcion1.Text = "Devuelven el valor del objeto especificado por el operando izquierdo después de la asignación.";
            this.Opcion2.Text = "Calcular un valor de dos o más números, o cambiar el signo de un número de positivo a negativo o viceversa.";
            this.Opcion3.Text = "Comparan datos numéricos, de serie de caracteres o lógicos.";
            this.Opcion4.Text = "Operan dos valores booleanos para dar como resultado un valor verdadero, falso o nulo.";
            seleccion++;
        }
        private void pregunta8()
        {
            this.Pregunta1.Text = "¿Qué es una variable?";
            this.Opcion1.Text = "Elemento donde se almacenan y recuperan datos para utilizar a lo largo del Código.";
            this.Opcion2.Text = "Problema en el código que hace que no ejecute correctamente su función.";
            this.Opcion3.Text = "Repiten el mismo bloque de código por un número finito de veces.";
            this.Opcion4.Text = "Solicitud de información y/o datos para una base de datos.";
            seleccion++;
        }
        private void pregunta9()
        {
            this.Pregunta1.Text = "¿Qué es una función?";
            this.Opcion1.Text = "Bloque de Código que realiza operaciones.";
            this.Opcion2.Text = "Código de un programa. La computadora lo usa para generar una versión del programa que es capaz de procesar.";
            this.Opcion3.Text = "código formado solo por 0 y 1 que tiene como función codificar algo.";
            this.Opcion4.Text = "La clase padre; clase que se amplía.";
            seleccion++;
        }
        private void pregunta10()
        {
            this.Pregunta1.Text = "De las siguientes opciones ¿cuáles son algunos paradigmas de programación?";
            this.Opcion1.Text = "Funcional y Abstracta.";
            this.Opcion2.Text = ".Net y HTML.";
            this.Opcion3.Text = "Clase y Dato.";
            this.Opcion4.Text = "Estructurada y Orientada a objetos.";
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
                    if (Opcion4.Checked == true)
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
                    if (Opcion2.Checked == true)
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
                case 3:
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
                    pregunta4();
                    Limpiar();
                    break;
                case 4:
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
                    pregunta5();
                    Limpiar();
                    break;
                case 5:
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
                    pregunta6();
                    Limpiar();
                    break;
                case 6:
                    if (Opcion2.Checked == true)
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
                    pregunta7();
                    Limpiar();
                    break;
                case 7:
                    if (Opcion4.Checked == true)
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
                    pregunta8();
                    Limpiar();
                    break;
                case 8:
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
                    pregunta9();
                    Limpiar();
                    break;
                case 9:
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
                    pregunta10();
                    Limpiar();
                    break;
                case 10:
                    if (Opcion4.Checked == true)
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
                    if (puntaje >= 4500)
                    {
                        MessageBox.Show(puntaje.ToString() + " Puntos Obtenidos en esta prueba", "Puntaje Sobresaliente", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    }
                    else
                    {
                        MessageBox.Show(puntaje.ToString()+" Puntos Obtenidos en esta prueba", "Debes Atender Mas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();

                    break;
                default:
                    break;
            }
        }
    }
}
