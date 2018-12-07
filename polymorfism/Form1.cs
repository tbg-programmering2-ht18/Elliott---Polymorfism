using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polymorfism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void skapa_Click(object sender, EventArgs e)
        {
            A Obj;
            if (radioButton1.Checked)
            {
                Obj = new A();
            }
            else
            {
                Obj = new B();
            }

            if (Obj is B)
            {
                textBox1.Text = (Obj as B).Description();
            }

            else
            {
                textBox1.Text = Obj.Description();

            }

        }
    }
}
