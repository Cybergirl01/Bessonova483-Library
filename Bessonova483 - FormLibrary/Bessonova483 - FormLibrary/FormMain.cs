using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bessonova483_classLibrary;

namespace Bessonova483___FormLibrary
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Quadratic_Equation equation = new Quadratic_Equation();
        private void buttonDo_Click(object sender, EventArgs e)
        {
            equation.a = Convert.ToSingle(textBox1.Text);
            equation.b = Convert.ToSingle(textBox2.Text);
            equation.c = Convert.ToSingle(textBox3.Text);
            textBoxItog.Text = Convert.ToString(equation.Solve(out float[] x));
        }
    }
}
