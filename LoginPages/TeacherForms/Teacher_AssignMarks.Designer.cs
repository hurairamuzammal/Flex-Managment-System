﻿namespace LoginPages.Teacher
{
     partial class Teacher_AssignMarks
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
               label2 = new Label();
               RollNo_box = new TextBox();
               marks_box = new TextBox();
               label3 = new Label();
               assign_button = new Button();
               button1 = new Button();
               label4 = new Label();
               textBox1 = new TextBox();
               ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
               SuspendLayout();
               // 
               // label1
               // 
               label1.AutoSize = true;
               label1.FlatStyle = FlatStyle.Flat;
               label1.Font = new Font("Perpetua Titling MT", 22.02985F, FontStyle.Regular, GraphicsUnit.Point);
               label1.Location = new Point(534, 58);
               label1.Margin = new Padding(2, 0, 2, 0);
               label1.Name = "label1";
               label1.Size = new Size(231, 36);
               label1.TabIndex = 20;
               label1.Text = "Assign Marks";
               // 
               // lblTotal
               // 
               lblTotal.AutoSize = true;
               lblTotal.Location = new Point(90, 86);
               lblTotal.Margin = new Padding(2, 0, 2, 0);
               lblTotal.Name = "lblTotal";
               lblTotal.Size = new Size(10, 15);
               lblTotal.TabIndex = 19;
               lblTotal.Text = ".";
               // 
               // open_button
               // 
               open_button.BackColor = Color.FromArgb(88, 103, 221);
               open_button.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
               open_button.ForeColor = Color.White;
               open_button.Location = new Point(44, 686);
               open_button.Margin = new Padding(2, 2, 2, 2);
               open_button.Name = "open_button";
               open_button.Size = new Size(22, 15);
               open_button.TabIndex = 18;
               open_button.Text = ".";
               open_button.UseVisualStyleBackColor = false;
               open_button.Click += open_button_Click;
               // 
               // btnSerach
               // 
               btnSerach.BackColor = Color.FromArgb(88, 103, 221);
               btnSerach.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
               btnSerach.ForeColor = SystemColors.ButtonFace;
               btnSerach.Location = new Point(1016, 685);
               btnSerach.Margin = new Padding(2, 2, 2, 2);
               btnSerach.Name = "btnSerach";
               btnSerach.Size = new Size(20, 24);
               btnSerach.TabIndex = 17;
               btnSerach.Text = ".";
               btnSerach.UseVisualStyleBackColor = false;
               btnSerach.Click += btnSerach_Click;
               // 
               // dataGridView1
               // 
               dataGridView1.BackgroundColor = SystemColors.ButtonFace;
               dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               dataGridView1.Location = new Point(99, 48);
               dataGridView1.Margin = new Padding(2, 2, 2, 2);
               dataGridView1.Name = "dataGridView1";
               dataGridView1.RowHeadersWidth = 57;
               dataGridView1.RowTemplate.Height = 32;
               dataGridView1.Size = new Size(23, 26);
               dataGridView1.TabIndex = 16;
               // 
               // SearchLabel
               // 
               SearchLabel.AutoSize = true;
               SearchLabel.Location = new Point(792, 72);
               SearchLabel.Margin = new Padding(2, 0, 2, 0);
               SearchLabel.Name = "SearchLabel";
               SearchLabel.Size = new Size(10, 15);
               SearchLabel.TabIndex = 15;
               SearchLabel.Text = ".";
               // 
               // textsearch
               // 
               textsearch.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
               textsearch.Location = new Point(1041, 685);
               textsearch.Margin = new Padding(2, 2, 2, 2);
               textsearch.Name = "textsearch";
               textsearch.Size = new Size(14, 22);
               textsearch.TabIndex = 14;
               textsearch.TextChanged += textsearch_TextChanged;
               // 
               // label2
               // 
               label2.AutoSize = true;
               label2.Location = new Point(205, 239);
               label2.Margin = new Padding(2, 0, 2, 0);
               label2.Name = "label2";
               label2.Size = new Size(46, 15);
               label2.TabIndex = 21;
               label2.Text = "Subject";
               // 
               // RollNo_box
               // 
               RollNo_box.Location = new Point(302, 264);
               RollNo_box.Margin = new Padding(2, 2, 2, 2);
               RollNo_box.Name = "RollNo_box";
               RollNo_box.Size = new Size(735, 23);
               RollNo_box.TabIndex = 22;
               RollNo_box.TextChanged += RollNo_box_TextChanged;
               // 
               // marks_box
               // 
               marks_box.Location = new Point(298, 322);
               marks_box.Margin = new Padding(2, 2, 2, 2);
               marks_box.Name = "marks_box";
               marks_box.Size = new Size(735, 23);
               marks_box.TabIndex = 24;
               marks_box.TextChanged += marks_box_TextChanged;
               // 
               // label3
               // 
               label3.AutoSize = true;
               label3.Location = new Point(201, 296);
               label3.Margin = new Padding(2, 0, 2, 0);
               label3.Name = "label3";
               label3.Size = new Size(123, 15);
               label3.TabIndex = 23;
               label3.Text = "Write Marks to assign \r\n";
               // 
               // assign_button
               // 
               assign_button.BackColor = Color.FromArgb(88, 103, 221);
               assign_button.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
               assign_button.ForeColor = Color.White;
               assign_button.Location = new Point(884, 658);
               assign_button.Margin = new Padding(2, 2, 2, 2);
               assign_button.Name = "assign_button";
               assign_button.Size = new Size(34, 32);
               assign_button.TabIndex = 25;
               assign_button.Text = "Assign";
               assign_button.UseVisualStyleBackColor = false;
               // 
               // button1
               // 
               button1.BackColor = Color.FromArgb(88, 103, 221);
               button1.Font = new Font("Bahnschrift", 10.7462683F, FontStyle.Regular, GraphicsUnit.Point);
               button1.ForeColor = SystemColors.ButtonFace;
               button1.Location = new Point(385, 451);
               button1.Margin = new Padding(2, 2, 2, 2);
               button1.Name = "button1";
               button1.Size = new Size(384, 35);
               button1.TabIndex = 28;
               button1.Text = "OK";
               button1.UseVisualStyleBackColor = false;
               button1.Click += button1_Click;
               // 
               // label4
               // 
               label4.AutoSize = true;
               label4.Location = new Point(201, 365);
               label4.Margin = new Padding(2, 0, 2, 0);
               label4.Name = "label4";
               label4.Size = new Size(74, 15);
               label4.TabIndex = 27;
               label4.Text = "Roll Number";
               // 
               // textBox1
               // 
               textBox1.Font = new Font("Bahnschrift", 9.134328F, FontStyle.Regular, GraphicsUnit.Point);
               textBox1.Location = new Point(298, 382);
               textBox1.Margin = new Padding(2, 2, 2, 2);
               textBox1.Name = "textBox1";
               textBox1.Size = new Size(739, 22);
               textBox1.TabIndex = 26;
               textBox1.TextChanged += textBox1_TextChanged;
               textBox1.KeyPress += textBox1_KeyPress;
               // 
               // Teacher_AssignMarks
               // 
               AutoScaleDimensions = new SizeF(7F, 15F);
               AutoScaleMode = AutoScaleMode.Font;
               ClientSize = new Size(1439, 717);
               Controls.Add(button1);
               Controls.Add(label4);
               Controls.Add(textBox1);
               Controls.Add(assign_button);
               Controls.Add(marks_box);
               Controls.Add(label3);
               Controls.Add(RollNo_box);
               Controls.Add(label2);
               Controls.Add(label1);
               Controls.Add(lblTotal);
               Controls.Add(open_button);
               Controls.Add(btnSerach);
               Controls.Add(dataGridView1);
               Controls.Add(SearchLabel);
               Controls.Add(textsearch);
               FormBorderStyle = FormBorderStyle.None;
               Margin = new Padding(2, 2, 2, 2);
               Name = "Teacher_AssignMarks";
               Text = "Assign_Marks";
               Load += Teacher_AssignMarks_Load;
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
          private Label label2;
          private TextBox RollNo_box;
          private TextBox marks_box;
          private Label label3;
          private Button assign_button;
          private Button button1;
          private Label label4;
          private TextBox textBox1;
     }
}