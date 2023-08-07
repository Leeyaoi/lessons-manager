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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Form3 addStud = new Form3();
            addStud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowTeacher st = new ShowTeacher();
            st.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 AddTeacher = new Form6();
            AddTeacher.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowStudent ss = new ShowStudent();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
