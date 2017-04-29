using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class ActorChoiceForm : Form 
    {
        public ActorChoiceForm()
        {
            var singInLabel = new Label
            {
                Dock = DockStyle.Fill
            };

            var buttonAccountant = new Button
            {
                Text = "Бухгалтер",
                Dock = DockStyle.Fill
            };

            var buttonTechnicalSpecialist = new Button
            {
                Text = "Технический специалист",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            for (int i = 0; i < 3; i++)
            {
                table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            }
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            table.Dock = DockStyle.Fill;

            table.Controls.Add(new System.Windows.Forms.Panel(), 0, 0);
            table.Controls.Add(singInLabel, 0, 1);
            table.Controls.Add(buttonAccountant, 0, 2);
            table.Controls.Add(buttonTechnicalSpecialist, 0, 3);
            table.Controls.Add(new System.Windows.Forms.Panel(), 0, 4);

            Controls.Add(table);

            buttonAccountant.Click += (sender, args) => button_AAForm(); //кнопка бухгалтер
            buttonTechnicalSpecialist.Click += (sender, args) => button_TSForm(); //кнопка тех специалист
        }

        private void button_AAForm()
        {
            AccountantAuthorizationForm aaform = new AccountantAuthorizationForm();
            aaform.Show();
            this.Hide();
        }

        private void button_TSForm()
        {
            TechnicalSpecialistAuthorizationForm tsform = new TechnicalSpecialistAuthorizationForm();
            tsform.Show();
            this.Hide();
        }
    }
}
