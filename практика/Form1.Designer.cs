namespace практика
{
    partial class AuthorizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.AutorizBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(12, 79);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(260, 27);
            this.loginTB.TabIndex = 1;
            // 
            // AutorizBtn
            // 
            this.AutorizBtn.Location = new System.Drawing.Point(99, 213);
            this.AutorizBtn.Name = "AutorizBtn";
            this.AutorizBtn.Size = new System.Drawing.Size(78, 31);
            this.AutorizBtn.TabIndex = 2;
            this.AutorizBtn.Text = "Вход";
            this.AutorizBtn.UseVisualStyleBackColor = true;
            this.AutorizBtn.Click += new System.EventHandler(this.AutorizBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(12, 161);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(260, 27);
            this.passwordTB.TabIndex = 4;
            // 
            // AuthorizeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutorizBtn);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label1);
            this.Name = "AuthorizeForm";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.AuthorizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox loginTB;
        private Button AutorizBtn;
        private Label label2;
        private Label label3;
        private TextBox passwordTB;
    }
}