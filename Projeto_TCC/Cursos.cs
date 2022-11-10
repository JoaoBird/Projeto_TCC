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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (box_tecnico.Checked) 
            {
                box_tec.Visible = true;
            }
            else
            {
                box_tec.Visible = false;
            }
            if (box_rapido.Checked)
            {
                box_rap.Visible = true;
            }
            else
            {
                box_rap.Visible = false;
            }
            if (box_industrial.Checked)
            {
                box_apr.Visible = true;
            }
            else
            {
                box_apr.Visible = false;
            }
        }


        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
