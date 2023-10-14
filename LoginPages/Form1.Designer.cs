namespace LoginPages
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            admin_button = new Button();
            Student_button = new Button();
            Teacher_button = new Button();
            label1 = new Label();
            label2 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 57);
            pictureBox1.Margin = new Padding(5, 3, 5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(351, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // admin_button
            // 
            admin_button.BackColor = Color.FromArgb(88, 103, 221);
            admin_button.BackgroundImageLayout = ImageLayout.None;
            admin_button.FlatStyle = FlatStyle.Flat;
            admin_button.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            admin_button.ForeColor = Color.White;
            admin_button.Location = new Point(137, 419);
            admin_button.Margin = new Padding(5, 3, 5, 3);
            admin_button.Name = "admin_button";
            admin_button.Size = new Size(333, 51);
            admin_button.TabIndex = 1;
            admin_button.Text = "Admin";
            admin_button.UseVisualStyleBackColor = false;
            admin_button.Click += button1_Click;
            // 
            // Student_button
            // 
            Student_button.BackColor = Color.FromArgb(88, 103, 221);
            Student_button.BackgroundImageLayout = ImageLayout.None;
            Student_button.FlatStyle = FlatStyle.Flat;
            Student_button.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            Student_button.ForeColor = Color.White;
            Student_button.Location = new Point(137, 569);
            Student_button.Margin = new Padding(5, 3, 5, 3);
            Student_button.Name = "Student_button";
            Student_button.Size = new Size(333, 51);
            Student_button.TabIndex = 2;
            Student_button.Text = "Student ";
            Student_button.UseVisualStyleBackColor = false;
            Student_button.Click += button2_Click;
            // 
            // Teacher_button
            // 
            Teacher_button.BackColor = Color.FromArgb(88, 103, 221);
            Teacher_button.BackgroundImageLayout = ImageLayout.None;
            Teacher_button.FlatStyle = FlatStyle.Flat;
            Teacher_button.Font = new Font("Bahnschrift", 13.970149F, FontStyle.Bold, GraphicsUnit.Point);
            Teacher_button.ForeColor = Color.White;
            Teacher_button.Location = new Point(137, 495);
            Teacher_button.Margin = new Padding(5, 3, 5, 3);
            Teacher_button.Name = "Teacher_button";
            Teacher_button.Size = new Size(333, 51);
            Teacher_button.TabIndex = 3;
            Teacher_button.Text = "Teacher";
            Teacher_button.UseVisualStyleBackColor = false;
            Teacher_button.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 15.044776F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(227, 347);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 4;
            label1.Text = "Sign in as";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Light", 11.8208952F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 266);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 24);
            label2.TabIndex = 5;
            label2.Text = "Welcome to FLEX SYSTEM";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(88, 103, 221);
            button4.Location = new Point(561, 1);
            button4.Margin = new Padding(5, 3, 5, 3);
            button4.Name = "button4";
            button4.Size = new Size(56, 47);
            button4.TabIndex = 6;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(616, 663);
            ControlBox = false;
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Teacher_button);
            Controls.Add(Student_button);
            Controls.Add(admin_button);
            Controls.Add(pictureBox1);
            Font = new Font("Verdana", 11.8208952F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FLEX MANAGMENT SYSTEM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button admin_button;
        private Button Student_button;
        private Button Teacher_button;
        private Label label1;
        private Label label2;
        private Button button4;
    }
}