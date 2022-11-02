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
using Domain;
using Presentation.Forms;

namespace Presentation
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            //View
            lblNombre.Text = UserLoginCache.Nombre;
            lblUsuario.Text = UserLoginCache.Usuario;
            lblCargo.Text = UserLoginCache.Cargo;
            
            //Edit Panel
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
            LoadUserData();
            editarcontroles();
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reset();
            PanelEditUsuario.Visible = true;
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
        private void button1_Click_1(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            PanelEditUsuario.Visible = false;
            reset();
        }
    }
}
