namespace LoginPages
{
    partial class admin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin2));
            button5 = new Button();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menuButton = new Button();
            panel3 = new Panel();
            add_student = new Button();
            back_button = new Button();
            edit_Student = new Button();
            add_teachers = new Button();
            edit_teacher = new Button();
            view_teacher = new Button();
            view_student = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
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
            button5.Location = new Point(1772, 12);
            button5.Name = "button5";
            button5.Size = new Size(59, 48);
            button5.TabIndex = 7;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(88, 103, 221);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(279, 1099);
            sidebar.MinimumSize = new Size(69, 1099);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(279, 1099);
            sidebar.TabIndex = 9;
            sidebar.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(menuButton);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 334);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            menuButton.Location = new Point(0, 90);
            menuButton.Margin = new Padding(5, 3, 5, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(276, 51);
            menuButton.TabIndex = 14;
            menuButton.Text = "     Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(add_student);
            panel3.Controls.Add(back_button);
            panel3.Controls.Add(edit_Student);
            panel3.Controls.Add(add_teachers);
            panel3.Controls.Add(edit_teacher);
            panel3.Controls.Add(view_teacher);
            panel3.Controls.Add(view_student);
            panel3.Location = new Point(3, 343);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 523);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // add_student
            // 
            add_student.BackColor = Color.FromArgb(88, 103, 221);
            add_student.BackgroundImageLayout = ImageLayout.None;
            add_student.FlatAppearance.BorderSize = 0;
            add_student.FlatStyle = FlatStyle.Flat;
            add_student.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            add_student.ForeColor = Color.White;
            add_student.Image = Properties.Resources.student_add_removebg_preview;
            add_student.ImageAlign = ContentAlignment.MiddleLeft;
            add_student.Location = new Point(-1, 3);
            add_student.Margin = new Padding(5, 3, 5, 3);
            add_student.Name = "add_student";
            add_student.Size = new Size(276, 60);
            add_student.TabIndex = 21;
            add_student.Text = "  Add Student";
            add_student.UseVisualStyleBackColor = false;
            add_student.Click += add_student_Click;
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
            back_button.Location = new Point(-1, 460);
            back_button.Margin = new Padding(5, 3, 5, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(276, 60);
            back_button.TabIndex = 20;
            back_button.Text = "   Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += button4_Click_1;
            // 
            // edit_Student
            // 
            edit_Student.BackColor = Color.FromArgb(88, 103, 221);
            edit_Student.BackgroundImageLayout = ImageLayout.None;
            edit_Student.FlatAppearance.BorderSize = 0;
            edit_Student.FlatStyle = FlatStyle.Flat;
            edit_Student.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            edit_Student.ForeColor = Color.White;
            edit_Student.Image = Properties.Resources.resume;
            edit_Student.ImageAlign = ContentAlignment.MiddleLeft;
            edit_Student.Location = new Point(-1, 152);
            edit_Student.Margin = new Padding(5, 3, 5, 3);
            edit_Student.Name = "edit_Student";
            edit_Student.Size = new Size(276, 60);
            edit_Student.TabIndex = 19;
            edit_Student.Text = "  Edit Student";
            edit_Student.UseVisualStyleBackColor = false;
            edit_Student.Click += edit_Student_Click;
            // 
            // add_teachers
            // 
            add_teachers.BackColor = Color.FromArgb(88, 103, 221);
            add_teachers.BackgroundImageLayout = ImageLayout.None;
            add_teachers.FlatAppearance.BorderSize = 0;
            add_teachers.FlatStyle = FlatStyle.Flat;
            add_teachers.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            add_teachers.ForeColor = SystemColors.Control;
            add_teachers.Image = (Image)resources.GetObject("add_teachers.Image");
            add_teachers.ImageAlign = ContentAlignment.MiddleLeft;
            add_teachers.Location = new Point(-1, 77);
            add_teachers.Margin = new Padding(5, 3, 5, 3);
            add_teachers.Name = "add_teachers";
            add_teachers.Size = new Size(276, 60);
            add_teachers.TabIndex = 17;
            add_teachers.Text = "        Add Teacher";
            add_teachers.TextAlign = ContentAlignment.MiddleLeft;
            add_teachers.UseVisualStyleBackColor = false;
            add_teachers.Click += add_teachers_Click;
            // 
            // edit_teacher
            // 
            edit_teacher.BackColor = Color.FromArgb(88, 103, 221);
            edit_teacher.BackgroundImageLayout = ImageLayout.None;
            edit_teacher.FlatAppearance.BorderColor = SystemColors.Control;
            edit_teacher.FlatAppearance.BorderSize = 0;
            edit_teacher.FlatStyle = FlatStyle.Flat;
            edit_teacher.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            edit_teacher.ForeColor = SystemColors.Control;
            edit_teacher.Image = Properties.Resources.teacher;
            edit_teacher.ImageAlign = ContentAlignment.MiddleLeft;
            edit_teacher.Location = new Point(-3, 228);
            edit_teacher.Margin = new Padding(5, 3, 5, 3);
            edit_teacher.Name = "edit_teacher";
            edit_teacher.Size = new Size(276, 60);
            edit_teacher.TabIndex = 18;
            edit_teacher.Text = "  Edit Teacher";
            edit_teacher.UseVisualStyleBackColor = false;
            edit_teacher.Click += edit_teacher_Click_1;
            // 
            // view_teacher
            // 
            view_teacher.BackColor = Color.FromArgb(88, 103, 221);
            view_teacher.BackgroundImageLayout = ImageLayout.None;
            view_teacher.FlatAppearance.BorderSize = 0;
            view_teacher.FlatStyle = FlatStyle.Flat;
            view_teacher.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_teacher.ForeColor = Color.White;
            view_teacher.Image = Properties.Resources.group;
            view_teacher.ImageAlign = ContentAlignment.MiddleLeft;
            view_teacher.Location = new Point(-1, 304);
            view_teacher.Margin = new Padding(5, 3, 5, 3);
            view_teacher.Name = "view_teacher";
            view_teacher.Size = new Size(282, 60);
            view_teacher.TabIndex = 22;
            view_teacher.Text = "  View Teacher";
            view_teacher.UseVisualStyleBackColor = false;
            view_teacher.Click += view_teacher_Click;
            // 
            // view_student
            // 
            view_student.BackColor = Color.FromArgb(88, 103, 221);
            view_student.BackgroundImageLayout = ImageLayout.None;
            view_student.FlatAppearance.BorderSize = 0;
            view_student.FlatStyle = FlatStyle.Flat;
            view_student.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_student.ForeColor = Color.White;
            view_student.Image = Properties.Resources.education;
            view_student.ImageAlign = ContentAlignment.MiddleLeft;
            view_student.Location = new Point(-1, 380);
            view_student.Margin = new Padding(5, 3, 5, 3);
            view_student.Name = "view_student";
            view_student.Size = new Size(276, 60);
            view_student.TabIndex = 23;
            view_student.Text = "    View Students";
            view_student.UseVisualStyleBackColor = false;
            view_student.Click += view_student_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // admin2
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1396, 794);
            Controls.Add(button5);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            IsMdiContainer = true;
            Name = "admin2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin2";
            WindowState = FormWindowState.Maximized;
            Load += admin2_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button5;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button button2;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button Menu;
        private Button menuButton;
        private Panel panel3;
        private Button add_student;
        private Button back_button;
        private Button edit_teacher;
        private Button view_student;
        private Button view_teacher;
        private Button add_teachers;
        private Button edit_Student;
    }
}