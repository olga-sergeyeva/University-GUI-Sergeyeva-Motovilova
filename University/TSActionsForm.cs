using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class TSActionsForm : Form
    {
        public TSActionsForm()
        {
            InitializeForm();
        }

        private void InitializeForm()
        {
            var label = new Label
            {
                Text = "Выберите действие",
                Dock = DockStyle.Fill
            };

            var buttonAddStudent = new Button
            {
                Text = "Добавить студента",
                Dock = DockStyle.Fill
            };

            var buttonChangeStudentInfo = new Button
            {
                Text = "Редактировать профиль студента",
                Dock = DockStyle.Fill
            };

            var buttonDeleteStudent = new Button
            {
                Text = "Удалить студента",
                Dock = DockStyle.Fill
            };

            var buttonAddEmployee = new Button
            {
                Text = "Добавить сотрудника",
                Dock = DockStyle.Fill
            };

            var buttonChangeInfoEmployee = new Button
            {
                Text = "Редактировать профиль сотрудника",
                Dock = DockStyle.Fill
            };

            var buttonDeleteEmployee = new Button
            {
                Text = "Удалить сотрудника",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(buttonAddStudent, 0, 2);
            table.Controls.Add(buttonChangeStudentInfo, 0, 3);
            table.Controls.Add(buttonDeleteStudent, 0, 4);
            table.Controls.Add(buttonAddEmployee, 1, 2);
            table.Controls.Add(buttonChangeInfoEmployee, 1, 3);
            table.Controls.Add(buttonDeleteEmployee, 1, 4);
            table.Controls.Add(new Panel(), 0, 5);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            buttonAddStudent.Click += (sender, args) => AddStudent();
        }

        private void AddStudent()
        {
            AddStudentForm asform = new AddStudentForm();
            asform.Show();
            this.Hide();
        }
    }
}
