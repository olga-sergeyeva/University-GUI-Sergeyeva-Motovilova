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
    public partial class ChangeStudentInfoForm2 : Form
    {
        public ChangeStudentInfoForm2()
        {
            InitializeComponent();

            comboBox1.DataSource = GetData().ToList();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\user\\documents\\visual studio 2015\\Projects\\University\\University\\Students.txt";
            string sline = comboBox1.Text;

            string newInfo = textBox1.Text + ' ' + textBox2.Text + ' ' + textBox3.Text + ' ' + textBox4.Text + ' ' + textBox5.Text + ' ' + textBox6.Text;
            
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != sline)
                    List.Add(lines[i]);
                else
                {
                    lines[i] = newInfo;
                    List.Add(lines[i]);
                }
            }

            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = string.Empty;
                File.WriteAllText(path, lines[i] + "\r\n");
            }                

            foreach (string l in List)
                File.WriteAllText(path, l + "\r\n");

            MessageBox.Show("Изменения сохранены");
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
    }
}
