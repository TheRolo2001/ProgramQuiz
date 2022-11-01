using Common.Cache;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormEditUsuario : Form
    {
        public FormEditUsuario()
        {
            InitializeComponent();
        }
        private void FormEditUsuario_Load(object sender, EventArgs e)
        {
            Edicion();
            editarcontroles();
        }

        private void Edicion()
        {
            txtNombre.Text = UserLoginCache.Nombre;
            txtUsuario.Text = UserLoginCache.Usuario;
            txtContraseña.Text = UserLoginCache.Contraseña;
            txtConfContraseña.Text = UserLoginCache.Contraseña;
            txtActual.Text = "";
        }
        private void editarcontroles()
        {
            txtContraseña.Enabled = false;
            txtContraseña.UseSystemPasswordChar = true;
            txtConfContraseña.Enabled = false;
            txtConfContraseña.UseSystemPasswordChar = true;
            txtActual.Enabled = false;
            txtActual.UseSystemPasswordChar = true;
        }

        private void reset()
        {
            Edicion();
            editarcontroles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfContraseña.Text)
            {
                if (txtActual.Text == UserLoginCache.Contraseña)
                {
                    var userModel = new UserModel(id: UserLoginCache.Id_Usuario, nombre: txtNombre.Text, usuario: txtUsuario.Text, contraseña: txtContraseña.Text);
                    var resultado = userModel.editarusuario();
                    MessageBox.Show(resultado);
                    reset();
                }
                else
                    MessageBox.Show("Error en la confirmacion");
            }
            else
                MessageBox.Show("Las contraseñas no coninciden");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtContraseña.Enabled = true;
            txtContraseña.Text = "";
            txtConfContraseña.Enabled = true;
            txtConfContraseña.Text = "";
            txtActual.Enabled = true;
            txtActual.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
