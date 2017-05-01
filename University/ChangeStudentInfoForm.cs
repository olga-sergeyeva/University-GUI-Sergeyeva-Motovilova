using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class ChangeStudentInfoForm : Form
    {
        public ChangeStudentInfoForm()
        {
            var label = new Label
            {
                Text = "Выберите студента из списка",
                Dock = DockStyle.Fill
            };

            var combobox = new ComboBox
            {
                DataSource = GetData().ToList(),
                Dock = DockStyle.Fill
            };

            var buttonChange = new Button()
            {
                Text = "Редактировать",
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

            var boxFaculty = new TextBox
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
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));


            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(combobox, 1, 1);
            table.Controls.Add(buttonChange, 1, 2);
            table.Controls.Add(labelID, 0, 3);
            table.Controls.Add(boxID, 1, 3);
            table.Controls.Add(labelFirstName, 0, 4);
            table.Controls.Add(boxFirstName, 1, 4);
            table.Controls.Add(labelLastName, 0, 5);
            table.Controls.Add(boxLastName, 1, 5);
            table.Controls.Add(labelFaculty, 0, 6);
            table.Controls.Add(boxFaculty, 1, 6);
            table.Controls.Add(labelGPA, 0, 7);
            table.Controls.Add(boxGPA, 1, 7);
            table.Controls.Add(labelAscholarship, 0, 8);
            table.Controls.Add(boxAsholarship, 1, 8);
            table.Controls.Add(new Panel(), 0, 9);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            buttonChange.Click += (sender, args) => ChangeInfo(combobox, boxID, boxFirstName, boxLastName, boxFaculty, boxGPA, boxAsholarship);
        }

        private List<string> GetData()
        {
            string path = "C:\\Users\\user\\Desktop\\ListOfStudents.txt";
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
                List.Add(lines[i]);

            return List;
        }

        private void ChangeInfo(ComboBox combobox, TextBox boxID, TextBox boxFirstName, TextBox boxLastName, TextBox boxFaculty, TextBox boxGPA, TextBox boxAsholarship)
        {
            string line = combobox.SelectedText;
            string[] parsedLine = new string[6];
            parsedLine = line.Split(' ');
            boxID.Text = parsedLine[0];
            boxFirstName.Text = parsedLine[1];
            boxLastName.Text = parsedLine[2];
            boxFaculty.Text = parsedLine[3];
            boxGPA.Text = parsedLine[4];
            boxAsholarship.Text = parsedLine[5];

            string path = "C:\\Users\\user\\Desktop\\ListOfStudents.txt";
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
               
            }
        }

    }
}

