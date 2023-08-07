namespace практика
{
    partial class ShowTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NameOfTeacher = new System.Windows.Forms.Label();
            this.TheirStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Следующий";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(12, 205);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(115, 29);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "Предыдущий";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameOfTeacher
            // 
            this.NameOfTeacher.AutoSize = true;
            this.NameOfTeacher.Location = new System.Drawing.Point(12, 9);
            this.NameOfTeacher.Name = "NameOfTeacher";
            this.NameOfTeacher.Size = new System.Drawing.Size(50, 20);
            this.NameOfTeacher.TabIndex = 2;
            this.NameOfTeacher.Text = "label1";
            // 
            // TheirStudents
            // 
            this.TheirStudents.FormattingEnabled = true;
            this.TheirStudents.ItemHeight = 20;
            this.TheirStudents.Location = new System.Drawing.Point(12, 74);
            this.TheirStudents.Name = "TheirStudents";
            this.TheirStudents.Size = new System.Drawing.Size(263, 104);
            this.TheirStudents.TabIndex = 3;
            this.TheirStudents.SelectedIndexChanged += new System.EventHandler(this.TheirStudents_SelectedIndexChanged);
            this.TheirStudents.DoubleClick += new System.EventHandler(this.TheirStudents_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ученики:";
            // 
            // ShowTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TheirStudents);
            this.Controls.Add(this.NameOfTeacher);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.button1);
            this.Name = "ShowTeacher";
            this.Text = "Электронный дневник";
            this.Activated += new System.EventHandler(this.ShowTeacher_Activated);
            this.Load += new System.EventHandler(this.ShowTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button PrevBtn;
        private Label NameOfTeacher;
        private ListBox TheirStudents;
        private Label label1;
    }
}