namespace LoginPages.Student
{
    partial class student_viewMarks
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
            open_button = new Button();
            btnSerach = new Button();
            dataGridView1 = new DataGridView();
            SearchLabel = new Label();
            textsearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(805, 179);
            label1.Name = "label1";
            label1.Size = new Size(273, 48);
            label1.TabIndex = 13;
            label1.Text = "View Marks";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(396, 898);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 23);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "Total Record";
            // 
            // open_button
            // 
            open_button.BackColor = Color.FromArgb(88, 103, 221);
            open_button.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            open_button.ForeColor = Color.White;
            open_button.Location = new Point(1359, 884);
            open_button.Name = "open_button";
            open_button.Size = new Size(100, 37);
            open_button.TabIndex = 11;
            open_button.Text = "View";
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += open_button_Click;
            // 
            // btnSerach
            // 
            btnSerach.BackColor = Color.FromArgb(88, 103, 221);
            btnSerach.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            btnSerach.ForeColor = SystemColors.ButtonFace;
            btnSerach.Location = new Point(1359, 295);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(105, 37);
            btnSerach.TabIndex = 10;
            btnSerach.Text = "Search";
            btnSerach.UseVisualStyleBackColor = false;
            btnSerach.Click += btnSerach_Click;
            btnSerach.KeyPress += btnSerach_KeyPress;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(386, 340);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1078, 538);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(386, 304);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(61, 23);
            SearchLabel.TabIndex = 8;
            SearchLabel.Text = "Search";
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textsearch.Location = new Point(453, 301);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(900, 28);
            textsearch.TabIndex = 7;
            textsearch.TextChanged += textsearch_TextChanged;
            // 
            // student_viewMarks
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1850, 1100);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(open_button);
            Controls.Add(btnSerach);
            Controls.Add(dataGridView1);
            Controls.Add(SearchLabel);
            Controls.Add(textsearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "student_viewMarks";
            Text = "student_viewMarks";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTotal;
        private Button open_button;
        private Button btnSerach;
        private DataGridView dataGridView1;
        private Label SearchLabel;
        private TextBox textsearch;
    }
}