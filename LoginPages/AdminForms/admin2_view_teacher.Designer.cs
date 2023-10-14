namespace LoginPages.Admin
{
    partial class admin2_view_teacher
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
            lblTotal = new Label();
            open_button = new Button();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            SearchLabel = new Label();
            textsearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(293, 789);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 23);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total Record";
            // 
            // open_button
            // 
            open_button.BackColor = Color.FromArgb(88, 103, 221);
            open_button.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            open_button.ForeColor = Color.White;
            open_button.Location = new Point(1256, 775);
            open_button.Name = "open_button";
            open_button.Size = new Size(100, 37);
            open_button.TabIndex = 10;
            open_button.Text = "View";
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += open_button_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(88, 103, 221);
            btnSearch.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.ButtonFace;
            btnSearch.Location = new Point(1256, 186);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 37);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSerach_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(283, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1078, 538);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Location = new Point(283, 195);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(61, 23);
            SearchLabel.TabIndex = 7;
            SearchLabel.Text = "Search";
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textsearch.Location = new Point(350, 192);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(900, 28);
            textsearch.TabIndex = 6;
            textsearch.TextChanged += textsearch_TextChanged;
            textsearch.KeyPress += textsearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(681, 49);
            label1.Name = "label1";
            label1.Size = new Size(341, 48);
            label1.TabIndex = 12;
            label1.Text = "View Teachers";
            // 
            // admin2_view_teacher
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 867);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(open_button);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Controls.Add(SearchLabel);
            Controls.Add(textsearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin2_view_teacher";
            Text = "admin2_view_teacher";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Button open_button;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Label SearchLabel;
        private TextBox textsearch;
        private Label label1;
    }
}