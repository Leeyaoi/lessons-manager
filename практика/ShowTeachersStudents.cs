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
    public partial class ShowTeachersStudents : Form
    {
        int index = 0;
        string[] students = File.ReadAllLines(ThisUser.GetTeachersPath())[1..];

        private void ShowOne()
        {
            string[] thisOne = File.ReadAllText(students[index]).Split("\n----------------------");

            name.Text = thisOne[0].Trim();
            charact.Text = thisOne[2].Trim();
            temes.Text = thisOne[3].Trim();
        }

        public ShowTeachersStudents()
        {
            InitializeComponent();
        }

        private void ShowTeachersStudents_Load(object sender, EventArgs e)
        {
            ShowOne();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            index++;
            if (index == students.Length) index = 0;
            ShowOne();
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0) index = students.Length - 1;
            ShowOne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllText(students[index]).Split("\n----------------------");
            lines[3] = temes.Text;
            using(StreamWriter sw = new StreamWriter(students[index]))
            {
                sw.WriteLine(lines[0].Trim());
                sw.WriteLine("----------------------");
                sw.WriteLine(lines[1].Trim());
                sw.WriteLine("----------------------");
                sw.WriteLine(lines[2].Trim());
                sw.WriteLine("----------------------");
                sw.WriteLine(lines[3].Trim());
            }
        }
    }
}
