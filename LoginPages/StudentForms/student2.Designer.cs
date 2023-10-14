namespace LoginPages.Student
{
    partial class student2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student2));
            button5 = new Button();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            menuButton = new Button();
            panel3 = new Panel();
            view_grades = new Button();
            back_button = new Button();
            view_attandance = new Button();
            view_marks = new Button();
            view_fee = new Button();
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
            button5.Location = new Point(1257, -313);
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
            menuButton.Location = new Point(3, 80);
            menuButton.Margin = new Padding(5, 3, 5, 3);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(276, 51);
            menuButton.TabIndex = 15;
            menuButton.Text = "     Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(view_grades);
            panel3.Controls.Add(back_button);
            panel3.Controls.Add(view_attandance);
            panel3.Controls.Add(view_marks);
            panel3.Controls.Add(view_fee);
            panel3.Location = new Point(3, 344);
            panel3.Name = "panel3";
            panel3.Size = new Size(276, 374);
            panel3.TabIndex = 24;
            // 
            // view_grades
            // 
            view_grades.BackColor = Color.FromArgb(88, 103, 221);
            view_grades.BackgroundImageLayout = ImageLayout.None;
            view_grades.FlatAppearance.BorderSize = 0;
            view_grades.FlatStyle = FlatStyle.Flat;
            view_grades.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_grades.ForeColor = Color.White;
            view_grades.Image = (Image)resources.GetObject("view_grades.Image");
            view_grades.ImageAlign = ContentAlignment.MiddleLeft;
            view_grades.Location = new Point(-2, 3);
            view_grades.Margin = new Padding(5, 3, 5, 3);
            view_grades.Name = "view_grades";
            view_grades.Size = new Size(277, 60);
            view_grades.TabIndex = 22;
            view_grades.Text = "  View Grades";
            view_grades.UseVisualStyleBackColor = false;
            view_grades.Click += view_grades_Click;
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
            // view_attandance
            // 
            view_attandance.BackColor = Color.FromArgb(88, 103, 221);
            view_attandance.BackgroundImageLayout = ImageLayout.None;
            view_attandance.FlatAppearance.BorderSize = 0;
            view_attandance.FlatStyle = FlatStyle.Flat;
            view_attandance.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_attandance.ForeColor = Color.White;
            view_attandance.Image = Properties.Resources.resume;
            view_attandance.ImageAlign = ContentAlignment.MiddleLeft;
            view_attandance.Location = new Point(-1, 152);
            view_attandance.Margin = new Padding(5, 3, 5, 3);
            view_attandance.Name = "view_attandance";
            view_attandance.Size = new Size(276, 60);
            view_attandance.TabIndex = 19;
            view_attandance.Text = "        View Attandance";
            view_attandance.UseVisualStyleBackColor = false;
            view_attandance.Click += view_attandance_Click;
            // 
            // view_marks
            // 
            view_marks.BackColor = Color.FromArgb(88, 103, 221);
            view_marks.BackgroundImageLayout = ImageLayout.None;
            view_marks.FlatAppearance.BorderSize = 0;
            view_marks.FlatStyle = FlatStyle.Flat;
            view_marks.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_marks.ForeColor = SystemColors.Control;
            view_marks.Image = (Image)resources.GetObject("view_marks.Image");
            view_marks.ImageAlign = ContentAlignment.MiddleLeft;
            view_marks.Location = new Point(-1, 77);
            view_marks.Margin = new Padding(5, 3, 5, 3);
            view_marks.Name = "view_marks";
            view_marks.Size = new Size(276, 60);
            view_marks.TabIndex = 17;
            view_marks.Text = "         View Marks";
            view_marks.TextAlign = ContentAlignment.MiddleLeft;
            view_marks.UseVisualStyleBackColor = false;
            view_marks.Click += view_marks_Click;
            // 
            // view_fee
            // 
            view_fee.BackColor = Color.FromArgb(88, 103, 221);
            view_fee.BackgroundImageLayout = ImageLayout.None;
            view_fee.FlatAppearance.BorderColor = SystemColors.Control;
            view_fee.FlatAppearance.BorderSize = 0;
            view_fee.FlatStyle = FlatStyle.Flat;
            view_fee.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            view_fee.ForeColor = SystemColors.Control;
            view_fee.Image = (Image)resources.GetObject("view_fee.Image");
            view_fee.ImageAlign = ContentAlignment.MiddleLeft;
            view_fee.Location = new Point(5, 228);
            view_fee.Margin = new Padding(5, 3, 5, 3);
            view_fee.Name = "view_fee";
            view_fee.Size = new Size(277, 60);
            view_fee.TabIndex = 18;
            view_fee.Text = "  View Fee";
            view_fee.UseVisualStyleBackColor = false;
            view_fee.Click += edit_teacher_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(88, 103, 221);
            button1.Location = new Point(1802, 12);
            button1.Name = "button1";
            button1.Size = new Size(59, 47);
            button1.TabIndex = 23;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // student2
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
            Name = "student2";
            Text = "s";
            Load += student2_Load;
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
        private Button back_button;
        private Button view_attandance;
        private Button view_marks;
        private Button view_fee;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button menuButton;
        private Button view_grades;
        private Button button1;
    }
}