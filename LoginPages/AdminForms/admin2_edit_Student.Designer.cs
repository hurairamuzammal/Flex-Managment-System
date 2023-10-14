namespace LoginPages
{
    partial class admin2_edit_Student
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
            open_button = new Button();
            btnSerach = new Button();
            dataGridView1 = new DataGridView();
            textsearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            first_name = new TextBox();
            fn_name = new TextBox();
            label4 = new Label();
            contact_box = new TextBox();
            label5 = new Label();
            fee_status = new TextBox();
            label6 = new Label();
            address_box = new TextBox();
            label7a = new Label();
            submit_button = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // open_button
            // 
            open_button.BackColor = Color.FromArgb(88, 103, 221);
            open_button.Font = new Font("Perpetua Titling MT", 10.7462683F, FontStyle.Bold, GraphicsUnit.Point);
            open_button.ForeColor = Color.White;
            open_button.Location = new Point(1297, 675);
            open_button.Name = "open_button";
            open_button.Size = new Size(123, 52);
            open_button.TabIndex = 10;
            open_button.Text = "View";
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += open_button_Click;
            // 
            // btnSerach
            // 
            btnSerach.BackColor = Color.FromArgb(88, 103, 221);
            btnSerach.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
            btnSerach.ForeColor = SystemColors.ButtonFace;
            btnSerach.Location = new Point(1305, 152);
            btnSerach.Name = "btnSerach";
            btnSerach.Size = new Size(105, 37);
            btnSerach.TabIndex = 9;
            btnSerach.Text = "Search";
            btnSerach.UseVisualStyleBackColor = false;
            btnSerach.Click += btnSerach_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(342, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1078, 449);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textsearch
            // 
            textsearch.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textsearch.Location = new Point(342, 158);
            textsearch.Name = "textsearch";
            textsearch.Size = new Size(967, 28);
            textsearch.TabIndex = 6;
            textsearch.TextChanged += textsearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(779, 114);
            label1.Name = "label1";
            label1.Size = new Size(222, 22);
            label1.TabIndex = 12;
            label1.Text = "Search Roll Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(730, 31);
            label2.Name = "label2";
            label2.Size = new Size(317, 48);
            label2.TabIndex = 13;
            label2.Text = "Edit Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(351, 795);
            label3.Name = "label3";
            label3.Size = new Size(120, 22);
            label3.TabIndex = 14;
            label3.Text = "First Name";
            // 
            // first_name
            // 
            first_name.Location = new Point(351, 829);
            first_name.Name = "first_name";
            first_name.Size = new Size(431, 30);
            first_name.TabIndex = 15;
            first_name.TextChanged += first_name_TextChanged;
            // 
            // fn_name
            // 
            fn_name.Location = new Point(975, 829);
            fn_name.Name = "fn_name";
            fn_name.Size = new Size(431, 30);
            fn_name.TabIndex = 17;
            fn_name.TextChanged += fn_name_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(975, 795);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 16;
            label4.Text = "Last Name";
            // 
            // contact_box
            // 
            contact_box.Location = new Point(975, 905);
            contact_box.Name = "contact_box";
            contact_box.Size = new Size(431, 30);
            contact_box.TabIndex = 21;
            contact_box.TextChanged += contact_box_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(975, 871);
            label5.Name = "label5";
            label5.Size = new Size(145, 22);
            label5.TabIndex = 20;
            label5.Text = "Contact No";
            // 
            // fee_status
            // 
            fee_status.Location = new Point(351, 905);
            fee_status.Name = "fee_status";
            fee_status.Size = new Size(431, 30);
            fee_status.TabIndex = 19;
            fee_status.TextChanged += fee_status_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 871);
            label6.Name = "label6";
            label6.Size = new Size(118, 22);
            label6.TabIndex = 18;
            label6.Text = "Fee Status";
            // 
            // address_box
            // 
            address_box.Location = new Point(664, 975);
            address_box.Name = "address_box";
            address_box.Size = new Size(431, 30);
            address_box.TabIndex = 22;
            address_box.TextChanged += address_box_TextChanged;
            // 
            // label7a
            // 
            label7a.AutoSize = true;
            label7a.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label7a.Location = new Point(664, 950);
            label7a.Name = "label7a";
            label7a.Size = new Size(93, 22);
            label7a.TabIndex = 23;
            label7a.Text = "Address";
            // 
            // submit_button
            // 
            submit_button.BackColor = Color.FromArgb(88, 103, 221);
            submit_button.Font = new Font("Perpetua Titling MT", 10.7462683F, FontStyle.Bold, GraphicsUnit.Point);
            submit_button.ForeColor = Color.White;
            submit_button.Location = new Point(624, 1029);
            submit_button.Name = "submit_button";
            submit_button.Size = new Size(509, 52);
            submit_button.TabIndex = 24;
            submit_button.Text = "submit";
            submit_button.UseVisualStyleBackColor = false;
            submit_button.Click += submit_button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Perpetua Titling MT", 10.2089548F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(351, 705);
            label7.Name = "label7";
            label7.Size = new Size(303, 22);
            label7.TabIndex = 27;
            label7.Text = "For edit Enter roll number";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(351, 747);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(913, 28);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(342, 675);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(104, 23);
            lblTotal.TabIndex = 28;
            lblTotal.Text = "Total Record";
            // 
            // admin2_edit_Student
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1850, 1104);
            Controls.Add(lblTotal);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(submit_button);
            Controls.Add(label7a);
            Controls.Add(address_box);
            Controls.Add(contact_box);
            Controls.Add(label5);
            Controls.Add(fee_status);
            Controls.Add(label6);
            Controls.Add(fn_name);
            Controls.Add(label4);
            Controls.Add(first_name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(open_button);
            Controls.Add(btnSerach);
            Controls.Add(dataGridView1);
            Controls.Add(textsearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin2_edit_Student";
            Text = "admin2_edit_Student";
            Load += admin2_edit_Student_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button open_button;
        private Button btnSerach;
        private DataGridView dataGridView1;
        private TextBox textsearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox first_name;
        private TextBox fn_name;
        private Label label4;
        private TextBox contact_box;
        private Label label5;
        private TextBox fee_status;
        private Label label6;
        private TextBox address_box;
        private Label label7a;
        private Button submit_button;
        private Label label7;
        private TextBox textBox1;
        private Label lblTotal;
    }
}