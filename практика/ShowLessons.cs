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
    public partial class ShowLessons : Form
    {
        Teacher thisOne = ThisUser.GetTeacher();
        Student student;

        public ShowLessons()
        {
            InitializeComponent();
        }

        private void UpdateLessons()
        {
            LessonsTB.DataSource = new List<string>();
            LessonsTB.DataSource = student.lessons;
        }

        private void AddLess_Click(object sender, EventArgs e)
        {
            AddLesson al = new AddLesson(student);
            al.Show();
        }

        private void DeleteLesson_Click(object sender, EventArgs e)
        {
            int i = LessonsTB.SelectedIndex;
            student.lessons.RemoveAt(i);
            File.WriteAllLines(student.path.Replace(".txt", "less.txt"), student.lessons);
            UpdateLessons();
        }

        private void ShowLessons_Load(object sender, EventArgs e)
        {
            studsCB.DataSource = thisOne.names;
            student = thisOne.students[thisOne.names.IndexOf(studsCB.Text)];
            UpdateLessons();
        }

        private void ShowLessons_Activated(object sender, EventArgs e)
        {
            UpdateLessons();
        }

        private void studsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            student = thisOne.students[thisOne.names.IndexOf(studsCB.Text)];
            UpdateLessons();
        }
    }
}
