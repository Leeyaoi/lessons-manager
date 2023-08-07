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
    public partial class TheirLessons : Form
    {
        List<string> lessons = new List<string>();

        public TheirLessons()
        {
            InitializeComponent();
        }

        private void TheirLessons_Load(object sender, EventArgs e)
        {
            foreach (var line in File.ReadAllLines(ThisUser.GetStudsLessons()))
            {
                lessons.Add(line);
            }

            UpdateLessons();
        }

        private void UpdateLessons()
        {
            LessonsTB.DataSource = new List<string>();
            LessonsTB.DataSource = lessons;
        }

    }
}
