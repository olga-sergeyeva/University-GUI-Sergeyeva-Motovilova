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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary(decimal.Parse(textBox5.Text));
            Premium prem = new Premium(decimal.Parse(textBox6.Text));
            Employee employee = new Employee(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, sal, prem);
            employee.AddEmployee(employee);
            MessageBox.Show("Сотрудник добавлен");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetBack();
        }

        private void GetBack()
        {
            TSActionsForm tsaform = new TSActionsForm();
            tsaform.Show();
            this.Hide();
        }
    }
}
