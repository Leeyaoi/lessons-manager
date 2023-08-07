using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class ShowTeacher : Form
    {
        int index = 0;
        List<string> names = new List<string>();
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        public ShowTeacher()
        {
            InitializeComponent();
        }

        private void ShowTeacher_Load(object sender, EventArgs e)
        {
            ShowOne();
        }

        public void ShowOne()
        {
            string name = Database.TeachersNames[index];
            Teacher thisOne = Database.teachers[name];
            NameOfTeacher.Text = name;

            names = new List<string>();
            students = new Dictionary<string, Student>();

            foreach (var i in thisOne.students)
            {
                names.Add(i.name);
                students.Add(i.name, i);
            }

            TheirStudents.DataSource = names;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index--;
            if(index < 0) index = Database.TeachersNames.Count - 1;
            ShowOne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index++;
            if (index == Database.TeachersNames.Count) index = 0;
            ShowOne();
        }

        private void TheirStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TheirStudents_DoubleClick(object sender, EventArgs e)
        {
            ShowTheStud sts = new ShowTheStud(students[names[TheirStudents.SelectedIndex]], Database.TeachersNames[index], TheirStudents.SelectedIndex);
            sts.Show();
        }

        private void ShowTeacher_Activated(object sender, EventArgs e)
        {
            ShowOne();
        }
    }
}
