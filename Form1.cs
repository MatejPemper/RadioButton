using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Rezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButton1Avion.Checked)
            {
                textBox1.Text = "Odabarli ste prijevoz avionom.";
            }
            if (radioButton2Autobus.Checked)
            {
                textBox1.Text = "Odabarli ste prijevoz autobusom.";
            }
            if (radioButton3Vlastiti.Checked)
            {
                textBox1.Text = "Odabarli ste vlastiti prijevoz.";
            }

        }
    }
}
