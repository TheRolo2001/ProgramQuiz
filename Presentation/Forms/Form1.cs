using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;


namespace Cuestionario
{

    public partial class Form1 : Form
    {
        int puntaje;
        int correctas;
        int incorrectas;
        public Form1()

        {
            InitializeComponent();
            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerficar1_Click(object sender, EventArgs e)
        {
            if (RBcorrecto.Checked == true)
            {
                puntaje = puntaje + 1000;
                Puntaje.Text = puntaje.ToString();
                correctas = correctas + 1;
                LbCorrectas.Text = correctas.ToString();
            }
            else
            {
                incorrectas = incorrectas + 1;
                LbIncorrectas.Text = incorrectas.ToString();
                
            }
            groupBox1.Enabled = false;
        }

        private void BtnVerficar2_Click(object sender, EventArgs e)
        {
            if (RBcorrecto1.Checked == true)
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
            groupBox2.Enabled = false;
        }   
    }
}
