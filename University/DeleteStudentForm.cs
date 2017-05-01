using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    class DeleteStudentForm : Form
    {
        public DeleteStudentForm()
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

            var buttonDelete = new Button()
            {
                Text = "Удалить",
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
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));


            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(combobox, 1, 1);
            table.Controls.Add(buttonDelete, 1, 2);
            table.Controls.Add(new Panel(), 0, 3);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            buttonDelete.Click += (sender, args) => DeleteStudent(combobox.SelectedText);
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

        private void DeleteStudent(string line)
        {
            string path = "C:\\Users\\user\\Desktop\\ListOfStudents.txt";
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != line)
                    List.Add(lines[i]);
            }

            foreach (string l in List)
                File.WriteAllText(path, l + "\r\n");

            MessageBox.Show("Студент удален из системы");
        }
    }
}
