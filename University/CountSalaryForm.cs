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
    public partial class CountSalaryForm : Form
    {
        public CountSalaryForm()
        {
            InitializeComponent();

            comboBox1.DataSource = FileReader.ReadEmployees().ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string eline = comboBox1.SelectedText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eline = comboBox1.SelectedText;
            string[] parsedLine = new string[6];
            parsedLine = eline.Split('\t');

            decimal sal = decimal.Parse(parsedLine[4]);
            decimal prem = decimal.Parse(parsedLine[5]);

            decimal ts = ((sal * prem) / 100) + sal;
            textBox1.Text = ts.ToString();

            MessageBox.Show("З/П назначена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetBack();
        }

        private void GetBack()
        {
            AActionsForm aaform = new AActionsForm();
            aaform.Show();
            this.Hide();
        }
    }
}
