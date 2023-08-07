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
    public partial class AddLesson : Form
    {
        public static Student student;

        public AddLesson(Student stud)
        {
            InitializeComponent();
            student = stud;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllLines(student.path.Replace(".txt","less.txt"), new string[] {$"{datePick.Text} {TimePick.Text}"});
            student.lessons.Add($"{datePick.Text} {TimePick.Text}");
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddLesson_Load(object sender, EventArgs e)
        {

        }
    }
}
