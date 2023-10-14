namespace LoginPages.Teacher
{
    partial class Teacher_MarkAttandance
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(88, 103, 221);
            button1.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(551, 657);
            button1.Name = "button1";
            button1.Size = new Size(858, 61);
            button1.TabIndex = 28;
            button1.Text = "Mark attandance";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 471);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 27;
            label2.Text = "Roll number";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(551, 362);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(858, 28);
            textBox1.TabIndex = 26;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(878, 225);
            label1.Name = "label1";
            label1.Size = new Size(437, 48);
            label1.TabIndex = 25;
            label1.Text = "Mark attandance";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(442, 834);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(14, 23);
            lblTotal.TabIndex = 24;
            lblTotal.Text = ".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(551, 320);
            label3.Name = "label3";
            label3.Size = new Size(106, 23);
            label3.TabIndex = 29;
            label3.Text = "Roll Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(551, 432);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 31;
            label4.Text = "Subject";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(551, 471);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(858, 28);
            textBox2.TabIndex = 30;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.WindowText;
            label5.Location = new Point(551, 525);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 33;
            label5.Text = "Attandance";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(551, 564);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(858, 28);
            textBox3.TabIndex = 32;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Teacher_MarkAttandance
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1850, 1100);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Teacher_MarkAttandance";
            Text = "Makr_attandance";
            Load += Teacher_MarkAttandance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label lblTotal;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox3;
    }
}