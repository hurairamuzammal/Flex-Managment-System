namespace LoginPages.Teacher
{
    partial class teacher2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacher2));
            button5 = new Button();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menuButton = new Button();
            panel3 = new Panel();
            Mark_attandance = new Button();
            back_button = new Button();
            Assign_marks = new Button();
            asign_grades = new Button();
            time_Table = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Font = new Font("Verdana", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.FromArgb(88, 103, 221);
            button5.Location = new Point(1830, -273);
            button5.Name = "button5";
            button5.Size = new Size(59, 47);
            button5.TabIndex = 10;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(88, 103, 221);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(279, 1100);
            sidebar.MinimumSize = new Size(70, 1100);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(279, 1100);
            sidebar.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(menuButton);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 335);
            panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.BackgroundImageLayout = ImageLayout.None;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            menuButton.ForeColor = Color.White;
            menuButton.Image = Properties.Resources.th_removebg_preview;
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(3, 89);
            menuButton.Margin = new Padding(5, 3, 5, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(276, 51);
            menuButton.TabIndex = 15;
            menuButton.Text = "     Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(Mark_attandance);
            panel3.Controls.Add(back_button);
            panel3.Controls.Add(Assign_marks);
            panel3.Controls.Add(asign_grades);
            panel3.Controls.Add(time_Table);
            panel3.Location = new Point(3, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 523);
            panel3.TabIndex = 24;
            // 
            // Mark_attandance
            // 
            Mark_attandance.BackColor = Color.FromArgb(88, 103, 221);
            Mark_attandance.BackgroundImageLayout = ImageLayout.None;
            Mark_attandance.FlatAppearance.BorderSize = 0;
            Mark_attandance.FlatStyle = FlatStyle.Flat;
            Mark_attandance.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            Mark_attandance.ForeColor = Color.White;
            Mark_attandance.Image = Properties.Resources.student_add_removebg_preview;
            Mark_attandance.ImageAlign = ContentAlignment.MiddleLeft;
            Mark_attandance.Location = new Point(-1, 3);
            Mark_attandance.Margin = new Padding(5, 3, 5, 3);
            Mark_attandance.Name = "Mark_attandance";
            Mark_attandance.Size = new Size(277, 60);
            Mark_attandance.TabIndex = 21;
            Mark_attandance.Text = "     Mark Attandance";
            Mark_attandance.UseVisualStyleBackColor = false;
            Mark_attandance.Click += Mark_attandance_Click;
            // 
            // back_button
            // 
            back_button.BackColor = Color.FromArgb(88, 103, 221);
            back_button.BackgroundImageLayout = ImageLayout.None;
            back_button.FlatAppearance.BorderColor = SystemColors.Control;
            back_button.FlatAppearance.BorderSize = 0;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            back_button.ForeColor = SystemColors.Control;
            back_button.Image = Properties.Resources.back;
            back_button.ImageAlign = ContentAlignment.MiddleLeft;
            back_button.Location = new Point(-2, 294);
            back_button.Margin = new Padding(5, 3, 5, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(277, 60);
            back_button.TabIndex = 20;
            back_button.Text = "   Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // Assign_marks
            // 
            Assign_marks.BackColor = Color.FromArgb(88, 103, 221);
            Assign_marks.BackgroundImageLayout = ImageLayout.None;
            Assign_marks.FlatAppearance.BorderSize = 0;
            Assign_marks.FlatStyle = FlatStyle.Flat;
            Assign_marks.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            Assign_marks.ForeColor = Color.White;
            Assign_marks.Image = Properties.Resources.resume;
            Assign_marks.ImageAlign = ContentAlignment.MiddleLeft;
            Assign_marks.Location = new Point(-1, 152);
            Assign_marks.Margin = new Padding(5, 3, 5, 3);
            Assign_marks.Name = "Assign_marks";
            Assign_marks.Size = new Size(276, 60);
            Assign_marks.TabIndex = 19;
            Assign_marks.Text = "  Assign Marks";
            Assign_marks.UseVisualStyleBackColor = false;
            Assign_marks.Click += Assign_marks_Click;
            // 
            // asign_grades
            // 
            asign_grades.BackColor = Color.FromArgb(88, 103, 221);
            asign_grades.BackgroundImageLayout = ImageLayout.None;
            asign_grades.FlatAppearance.BorderSize = 0;
            asign_grades.FlatStyle = FlatStyle.Flat;
            asign_grades.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            asign_grades.ForeColor = SystemColors.Control;
            asign_grades.Image = (Image)resources.GetObject("asign_grades.Image");
            asign_grades.ImageAlign = ContentAlignment.MiddleLeft;
            asign_grades.Location = new Point(-1, 77);
            asign_grades.Margin = new Padding(5, 3, 5, 3);
            asign_grades.Name = "asign_grades";
            asign_grades.Size = new Size(276, 60);
            asign_grades.TabIndex = 17;
            asign_grades.Text = "        Asign Grades";
            asign_grades.TextAlign = ContentAlignment.MiddleLeft;
            asign_grades.UseVisualStyleBackColor = false;
            asign_grades.Click += asign_grades_Click;
            // 
            // time_Table
            // 
            time_Table.BackColor = Color.FromArgb(88, 103, 221);
            time_Table.BackgroundImageLayout = ImageLayout.None;
            time_Table.FlatAppearance.BorderColor = SystemColors.Control;
            time_Table.FlatAppearance.BorderSize = 0;
            time_Table.FlatStyle = FlatStyle.Flat;
            time_Table.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            time_Table.ForeColor = SystemColors.Control;
            time_Table.Image = Properties.Resources.teacher;
            time_Table.ImageAlign = ContentAlignment.MiddleLeft;
            time_Table.Location = new Point(-2, 228);
            time_Table.Margin = new Padding(5, 3, 5, 3);
            time_Table.Name = "time_Table";
            time_Table.Size = new Size(277, 60);
            time_Table.TabIndex = 18;
            time_Table.Text = "  Time Table";
            time_Table.UseVisualStyleBackColor = false;
            time_Table.Click += time_Table_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Verdana", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(88, 103, 221);
            button1.Location = new Point(1821, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // teacher2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1920, 1104);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "teacher2";
            Text = "teacher2";
            Load += teacher2_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Panel panel3;
        private Button Mark_attandance;
        private Button back_button;
        private Button Assign_marks;
        private Button asign_grades;
        private Button time_Table;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button menuButton;
        private Button button1;
    }
}