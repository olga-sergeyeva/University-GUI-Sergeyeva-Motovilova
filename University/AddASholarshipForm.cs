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
    public partial class AddASholarshipForm : Form
    {
        public AddASholarshipForm()
        {
            InitializeComponent();
            comboBox1.DataSource = FileReader.ReadStudents().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            string gpa;
            string[] parsedLine = new string[8];
            parsedLine = sline.Split('\t');

            gpa = parsedLine[6];

            if (gpa == "Отличная")
                textBox1.Text = "2000";

            if (gpa == "Хорошая")
                textBox1.Text = "1500";

            if (gpa == "Удовлетворительная" || gpa == "Неудовлетворительная")
                textBox1.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стипендия назначена");
        }

        private void GetBack()
        {
            TSActionsForm tsaform = new TSActionsForm();
            tsaform.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetBack();
        }
    }
}
