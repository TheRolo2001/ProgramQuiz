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
            lblNombre.Text = UserLoginCache.Nombre;
            lblEmail.Text = UserLoginCache.Usuario;
            lblCargo.Text = UserLoginCache.Cargo;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Form form = new FormEditUsuario();
            form.Show();
        }
    }
}
