using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class ChangeStudentInfoForm2 : Form
    {
        public ChangeStudentInfoForm2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            string[] parsedLine = new string[6];
            parsedLine = sline.Split(' ');
            textBox1.Text = parsedLine[0];
            textBox2.Text = parsedLine[1];
            textBox3.Text = parsedLine[2];
            textBox4.Text = parsedLine[3];
            textBox5.Text = parsedLine[4];
            textBox6.Text = parsedLine[5];
        }
    }
}
