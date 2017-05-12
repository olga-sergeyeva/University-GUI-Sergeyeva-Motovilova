using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class ChangeStudentInfoForm : Form
    {
        public ChangeStudentInfoForm()
        {
            InitializeComponent();

            comboBox1.DataSource = FileReader.ReadStudents().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            string[] parsedLine = new string[6];
            parsedLine = sline.Split('\t');
            textBox1.Text = parsedLine[0]; //ID
            textBox2.Text = parsedLine[1]; //Ln
            textBox3.Text = parsedLine[2]; //Fn
            textBox4.Text = parsedLine[4]; //Fac
            textBox5.Text = parsedLine[6]; //GPA
            textBox6.Text = parsedLine[7]; //Privilege
            textBox7.Text = parsedLine[5]; //Dep
            textBox8.Text = parsedLine[3]; //Sn
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            string newInfo = textBox1.Text + '\t' + textBox2.Text + '\t' + textBox3.Text + '\t' + textBox8.Text + '\t' + textBox4.Text + '\t' + textBox7.Text + '\t' + textBox5.Text + '\t' + textBox6.Text;
            FileReader.RewriteStudents(sline, newInfo);
            MessageBox.Show("Изменения сохранены");
        }
    }
}
