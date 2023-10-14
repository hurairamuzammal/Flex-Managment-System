namespace LoginPages.Admin
{
    partial class admin2_view_student
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
            textsearch = new TextBox();
            SearchLabel = new Label();
            dataGridView1 = new DataGridView();
            btnSerach = new Button();
            open_button = new Button();
            lblTotal = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textsearch.Location = new Point(360, 191);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(900, 28);
            textsearch.TabIndex = 0;
            textsearch.TextChanged += textsearch_TextChanged;
            textsearch.KeyPress += textsearch_KeyPress;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(293, 194);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(61, 23);
            SearchLabel.TabIndex = 1;
            SearchLabel.Text = "Search";
            SearchLabel.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1078, 538);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnSerach
            // 
            btnSerach.BackColor = Color.FromArgb(88, 103, 221);
            btnSerach.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            btnSerach.ForeColor = SystemColors.ButtonFace;
            btnSerach.Location = new Point(1266, 185);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(105, 37);
            btnSerach.TabIndex = 3;
            btnSerach.Text = "Search";
            btnSerach.UseVisualStyleBackColor = false;
            btnSerach.Click += button1_Click;
            // 
            // open_button
            // 
            open_button.BackColor = Color.FromArgb(88, 103, 221);
            open_button.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            open_button.ForeColor = Color.White;
            open_button.Location = new Point(1266, 774);
            open_button.Name = "open_button";
            open_button.Size = new Size(100, 37);
            open_button.TabIndex = 4;
            open_button.Text = "View";
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += button2_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(303, 788);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 23);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total Record";
            lblTotal.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(712, 69);
            label1.Name = "label1";
            label1.Size = new Size(328, 48);
            label1.TabIndex = 6;
            label1.Text = "View Student";
            // 
            // admin2_view_student
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 867);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(open_button);
            Controls.Add(btnSerach);
            Controls.Add(dataGridView1);
            Controls.Add(SearchLabel);
            Controls.Add(textsearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin2_view_student";
            Text = "admin2_view_student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textsearch;
        private Label SearchLabel;
        private DataGridView dataGridView1;
        private Button btnSerach;
        private Button open_button;
        private Label lblTotal;
        private Label label1;
    }
}