namespace практика
{
    partial class ShowLessons
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
            this.studsCB = new System.Windows.Forms.ComboBox();
            this.LessonsTB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLess = new System.Windows.Forms.Button();
            this.DeleteLesson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studsCB
            // 
            this.studsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studsCB.FormattingEnabled = true;
            this.studsCB.Location = new System.Drawing.Point(81, 12);
            this.studsCB.Name = "studsCB";
            this.studsCB.Size = new System.Drawing.Size(200, 28);
            this.studsCB.TabIndex = 0;
            this.studsCB.SelectedIndexChanged += new System.EventHandler(this.studsCB_SelectedIndexChanged);
            // 
            // LessonsTB
            // 
            this.LessonsTB.FormattingEnabled = true;
            this.LessonsTB.ItemHeight = 20;
            this.LessonsTB.Location = new System.Drawing.Point(12, 46);
            this.LessonsTB.Name = "LessonsTB";
            this.LessonsTB.Size = new System.Drawing.Size(269, 144);
            this.LessonsTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ученик ";
            // 
            // AddLess
            // 
            this.AddLess.Location = new System.Drawing.Point(12, 196);
            this.AddLess.Name = "AddLess";
            this.AddLess.Size = new System.Drawing.Size(269, 29);
            this.AddLess.TabIndex = 3;
            this.AddLess.Text = "Добавить урок";
            this.AddLess.UseVisualStyleBackColor = true;
            this.AddLess.Click += new System.EventHandler(this.AddLess_Click);
            // 
            // DeleteLesson
            // 
            this.DeleteLesson.Location = new System.Drawing.Point(12, 231);
            this.DeleteLesson.Name = "DeleteLesson";
            this.DeleteLesson.Size = new System.Drawing.Size(269, 29);
            this.DeleteLesson.TabIndex = 4;
            this.DeleteLesson.Text = "Удалить урок";
            this.DeleteLesson.UseVisualStyleBackColor = true;
            this.DeleteLesson.Click += new System.EventHandler(this.DeleteLesson_Click);
            // 
            // ShowLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 267);
            this.Controls.Add(this.DeleteLesson);
            this.Controls.Add(this.AddLess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LessonsTB);
            this.Controls.Add(this.studsCB);
            this.Name = "ShowLessons";
            this.Text = "Электронный дневник";
            this.Activated += new System.EventHandler(this.ShowLessons_Activated);
            this.Load += new System.EventHandler(this.ShowLessons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox studsCB;
        private ListBox LessonsTB;
        private Label label1;
        private Button AddLess;
        private Button DeleteLesson;
    }
}