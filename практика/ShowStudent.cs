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
    public partial class ShowStudent : Form
    {
        int index = 0;
        string[] students = File.ReadAllLines(@"Accounts\Students\UsersFiles.txt");

        public ShowStudent()
        {
            InitializeComponent();
        }

        private void ShowStudent_Load(object sender, EventArgs e)
        {
            ShowOne();
        }

        private void ShowOne()
        {
            string[] thisOne = File.ReadAllText(students[index]).Split("\n----------------------");

            name.Text = thisOne[0];
            teacher.Text = thisOne[1];
            charact.Text = thisOne[2];
            temes.Text = thisOne[3];
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0) index = students.Length - 1;
            ShowOne();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            index++;
            if (index == students.Length) index = 0;
            ShowOne();
        }
    }
}
