using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;


namespace Presentation
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        //Metodos para validar campos de texto
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.DimGray;
            }
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Gainsboro;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Gainsboro;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }
        //Realizar Registro
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "Nombre")
            {
                if (txtUser.Text != "Usuario")
                {
                    if (txtPass.Text != "Contraseña")
                    {
                        UserModel user = new UserModel();
                        var validRegister = user.RegisterUser(txtNombre.Text, txtUser.Text, txtPass.Text);
                        if (validRegister)
                        {
                            MessageBox.Show("¡Usuario registrado correctamente!");
                            LimpiarDatos();
                        }
                        else
                        {
                            msgError("Datos No validos.");
                            LimpiarDatos();
                        }
                    }
                    else msgError(" Por favor ingrese una contraseña");
                }
                else msgError("Por favor ingrese un nombre de usuario");
            }
            else msgError("Por favor ingrese un nombre");
        }
        //Inicio de Sesion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Close();
            formLogin.Show();
        }
        //Botones de Ventana
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "  " + msg;
            lblErrorMessage.Visible = true;
        }
        private void LimpiarDatos() 
        {
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Text = "Nombre";
            txtUser.ForeColor = Color.DimGray;
            txtUser.Text = "Usuario";
            txtPass.ForeColor = Color.DimGray;
            txtPass.Text = "Contraseña";
        }
    }
}
