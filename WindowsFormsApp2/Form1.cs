using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            string val1 = textBox1.Text;
            string val2 = textBox2.Text;

            string message = "Do you want to close this window?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (val1 == "moiz" && val2 == "22")
            {
                MessageBox.Show(message, title, buttons);
            }
            else
            {
                MessageBox.Show("error");
            }


        }
    }
}
