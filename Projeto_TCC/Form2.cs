using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos sistema = new Cursos();
            sistema.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro sistema = new Cadastro();
            sistema.ShowDialog();
        }
    }
}
