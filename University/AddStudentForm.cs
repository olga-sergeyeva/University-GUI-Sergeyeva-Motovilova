using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            var label = new Label
            {
                Text = "Заполните информацию о новом студенте",
                Dock = DockStyle.Fill
            };

            var labelID = new Label
            {
                Text = "ID студента",
                Dock = DockStyle.Fill
            };

            var boxID = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var labelFirstName = new Label
            {
                Text = "Имя",
                Dock = DockStyle.Fill
            };

            var boxFirstName = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var labelLastName = new Label
            {
                Text = "Фамилия",
                Dock = DockStyle.Fill
            };

            var boxLastName = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var labelFaculty = new Label
            {
                Text = "Факультет",
                Dock = DockStyle.Fill
            };

            var boxFaculty= new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var labelGPA = new Label
            {
                Text = "Успеваемость",
                Dock = DockStyle.Fill
            };

            var boxGPA = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var labelAscholarship = new Label
            {
                Text = "Размер академической стипендии",
                Dock = DockStyle.Fill
            };

            var boxAsholarship = new TextBox
            {
                Dock = DockStyle.Fill,
            };

            var buttonAdd = new Button
            {
                Text = "Добавить нового студента",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));


            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(labelID, 0, 2);
            table.Controls.Add(boxID, 1, 2);
            table.Controls.Add(labelFirstName, 0, 3);
            table.Controls.Add(boxFirstName, 1, 3);
            table.Controls.Add(labelLastName, 0, 4);
            table.Controls.Add(boxLastName, 1, 4);
            table.Controls.Add(labelFaculty, 0, 5);
            table.Controls.Add(boxFaculty, 1, 5);
            table.Controls.Add(labelGPA, 0, 6);
            table.Controls.Add(boxGPA, 1, 6);
            table.Controls.Add(labelAscholarship, 0, 7);
            table.Controls.Add(boxAsholarship, 1, 7);
            table.Controls.Add(buttonAdd, 1, 8);
            table.Controls.Add(new Panel(), 0, 9);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            buttonAdd.Click += (sender, args) => ClickAddStudent(int.Parse(boxID.Text), boxFirstName.Text, boxLastName.Text, boxFaculty.Text, boxGPA.Text, decimal.Parse(boxAsholarship.Text));
        }

        private void ClickAddStudent(int id, string fname, string lname, string faculty, string gpa, decimal ascholarship)
        {
            string path = "C:\\Users\\user\\Desktop\\ListOfStudents.txt";
            string info = id.ToString() + ' ' + fname + ' ' + lname + ' ' + faculty + ' ' + gpa + ' ' + ascholarship.ToString();           
            File.AppendAllText(path, info + "\r\n");
            MessageBox.Show("Студент добавлен в систему");
        }
    }
}
