namespace практика
{
    public partial class AuthorizeForm : Form
    {
        static string AllUsersFile = @"Accounts\Users.txt";

        const string admin = "2";
        const string teacher = "1";
        const string student = "0";

        Form2 TeacherMenu = new Form2();
        Form4 StudentMenu = new Form4();
        Form5 AdminMenu = new Form5();

        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void AutorizBtn_Click(object sender, EventArgs e)
        {
            string login = loginTB.Text;
            string password = passwordTB.Text;
            bool found = false;
            using(StreamReader sr = new StreamReader(AllUsersFile))
            {
                string str = sr.ReadLine();
                while(str != null)
                {
                    string[] user = str.Split();
                    if (user[0] == login && user[1] == password)
                    {
                        switch (user[2])
                        {
                            case admin:
                                MessageBox.Show("Вы вошли как администратор");
                                ThisUser.role = 2;
                                AdminMenu.Show();
                                break;
                            case teacher:
                                MessageBox.Show("Вы вошли как учитель");
                                ThisUser.role = 1;
                                TeacherMenu.Show();
                                break;
                            case student:
                                MessageBox.Show("Вы вошли как ученик");
                                ThisUser.role = 0;
                                StudentMenu.Show();
                                break;
                           
                        }
                        ThisUser.login = login;
                        ThisUser.password = password;
                        sr.Close();
                        found = true;
                        break;
                    }
                    str = sr.ReadLine();
                }
                if (!found)
                {
                    MessageBox.Show("Такого пользователя нет");
                }
                
            }
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            Database.GetAllTeachers();
        }
    }
}