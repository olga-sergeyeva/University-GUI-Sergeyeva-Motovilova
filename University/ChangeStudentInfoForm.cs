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
                Dock = DockStyle.Fill
            };
           
            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));


            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(combobox, 1, 1);
            table.Controls.Add(new Panel(), 0, 9);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            combobox.Click += (sender, args) => ListStudent(combobox);
        }

        private void ListStudent(ComboBox combobox)
        {
            string path = "C:\\Users\\user\\Desktop\\ListOfStudents.txt";
            List<string> List = new List<string>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
                List.Add(lines[i]);
            combobox.DataSource = List.ToList();
        }
    }
}
