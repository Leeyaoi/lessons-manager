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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void seeLessons_Click(object sender, EventArgs e)
        {
            ShowLessons sl = new ShowLessons();
            sl.Show();
        }

        private void seeStudents_Click(object sender, EventArgs e)
        {
            ShowTeachersStudents sts = new ShowTeachersStudents();
            sts.Show();
        }
    }
}
