using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppteste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(caixausu1.Text);
            int n2 = int.Parse(caixausu2.Text);

            int res= n1 + n2;    

            resul.Text= res.ToString();
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            caixausu1.Clear();
            caixausu2.Clear();
            resul.Clear();
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
