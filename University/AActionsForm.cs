using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class AActionsForm : Form
    {
        public AActionsForm()
        {
            var label = new Label
            {
                Text = "Выберите действие",
                Dock = DockStyle.Fill
            };

            var buttonAScholarship = new Button
            {
                Text = "Назначить академическую стипендию",
                Dock = DockStyle.Fill
            };

            var buttonTotalSalary = new Button
            {
                Text = "Рассчитать заработную плату",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(buttonAScholarship, 0, 2);
            table.Controls.Add(buttonTotalSalary, 0, 3);
            table.Controls.Add(new Panel(), 0, 4);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            buttonAScholarship.Click += (sender, args) => ChooseAScholarship();
            buttonTotalSalary.Click += (sender, args) => ChooseTotalSalary();
        }

        private void ChooseAScholarship()
        {
            AddASholarshipForm aasform = new AddASholarshipForm();
            aasform.Show();
            this.Hide();
        }

        private void ChooseTotalSalary()
        {
            CountSalaryForm csform = new CountSalaryForm();
            csform.Show();
            this.Hide();
        }


    }
}
