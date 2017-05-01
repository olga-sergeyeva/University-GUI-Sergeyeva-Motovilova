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
            comboBox1.DataSource = GetData().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            string gpa;
            string[] parsedLine = new string[6];
            parsedLine = sline.Split(' ');

            gpa = parsedLine[4];

            if (gpa == "Отлично")
                textBox1.Text = "2000";

            if (gpa == "Хорошо")
                textBox1.Text = "1500";

            if (gpa == "Удовлетворительно" || gpa == "Неудовлетворительно")
                textBox1.Text = "0";

        }

        private List<string> GetData()
        {
            string path = "C:\\Users\\user\\documents\\visual studio 2015\\Projects\\University\\University\\Students.txt";
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
                List.Add(lines[i]);

            return List;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Стипендия назначена");
        }
    }
}
