namespace практика
{
    partial class TheirLessons
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
            this.LessonsTB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LessonsTB
            // 
            this.LessonsTB.FormattingEnabled = true;
            this.LessonsTB.ItemHeight = 20;
            this.LessonsTB.Location = new System.Drawing.Point(12, 12);
            this.LessonsTB.Name = "LessonsTB";
            this.LessonsTB.Size = new System.Drawing.Size(269, 144);
            this.LessonsTB.TabIndex = 2;
            // 
            // TheirLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 166);
            this.Controls.Add(this.LessonsTB);
            this.Name = "TheirLessons";
            this.Text = "Электронный дневник";
            this.Load += new System.EventHandler(this.TheirLessons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox LessonsTB;
    }
}