namespace LoginPages.Student
{
    partial class student_viewFee
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
            label1 = new Label();
            lblTotal = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(805, 179);
            label1.Name = "label1";
            label1.Size = new Size(200, 48);
            label1.TabIndex = 20;
            label1.Text = "View Fee";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(425, 769);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(14, 23);
            lblTotal.TabIndex = 19;
            lblTotal.Text = ".";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(88, 103, 221);
            button1.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(534, 466);
            button1.Name = "button1";
            button1.Size = new Size(858, 61);
            button1.TabIndex = 23;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 406);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 22;
            label2.Text = "Roll number";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(534, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(858, 28);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // student_viewFee
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1850, 1100);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "student_viewFee";
            Text = "student_viewFee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotal;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
    }
}