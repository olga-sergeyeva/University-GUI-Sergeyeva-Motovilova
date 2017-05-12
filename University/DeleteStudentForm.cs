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
    public partial class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
        {
            InitializeComponent();

            comboBox1.DataSource = FileReader.ReadStudents().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
            FileReader.DeleteStudent(sline);
            MessageBox.Show("Студент удален");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sline = comboBox1.Text;
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
