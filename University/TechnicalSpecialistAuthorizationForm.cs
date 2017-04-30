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
    public partial class TechnicalSpecialistAuthorizationForm : Form
    {
        public TechnicalSpecialistAuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "user2";
            string password = "123";

            if (textBox1.Text == login && textBox2.Text == password)
            //MessageBox.Show("Авторизация прошла успешно");
            {
                TSActionsForm tsaform = new TSActionsForm();
                tsaform.Show();
                this.Hide();
            }

            else MessageBox.Show("Неверный логин/пароль");
        }
    }
}
