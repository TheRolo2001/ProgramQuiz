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
using Cuestionario;
using Presentation.Forms;

namespace Presentation.Forms
{
    public partial class FormMenuCuestionarios : Form
    {
        public FormMenuCuestionarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FormCuestionario();
            form.Show();
            button1.Enabled = false;
        }
    }
}
