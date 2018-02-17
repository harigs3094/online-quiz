namespace online_quiz
{
    partial class student_quiz
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
            this.label1 = new System.Windows.Forms.Label();
            this.Quiz_btn = new System.Windows.Forms.Button();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submit_btn_ans = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.stu_ans_cmb = new System.Windows.Forms.ComboBox();
            this.opd_txt = new System.Windows.Forms.TextBox();
            this.opc_txt = new System.Windows.Forms.TextBox();
            this.opb_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.opa_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stu_qus_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.score_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // Quiz_btn
            // 
            this.Quiz_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quiz_btn.Location = new System.Drawing.Point(143, 155);
            this.Quiz_btn.Name = "Quiz_btn";
            this.Quiz_btn.Size = new System.Drawing.Size(204, 33);
            this.Quiz_btn.TabIndex = 1;
            this.Quiz_btn.Text = "Start Quiz";
            this.Quiz_btn.UseVisualStyleBackColor = true;
            this.Quiz_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_btn.Location = new System.Drawing.Point(913, 27);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(96, 33);
            this.Logout_btn.TabIndex = 2;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.UseVisualStyleBackColor = true;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.score_lbl);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.submit_btn_ans);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.stu_ans_cmb);
            this.panel1.Controls.Add(this.opd_txt);
            this.panel1.Controls.Add(this.opc_txt);
            this.panel1.Controls.Add(this.opb_txt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.opa_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.stu_qus_txt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 333);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // submit_btn_ans
            // 
            this.submit_btn_ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn_ans.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn_ans.Location = new System.Drawing.Point(295, 247);
            this.submit_btn_ans.Name = "submit_btn_ans";
            this.submit_btn_ans.Size = new System.Drawing.Size(97, 35);
            this.submit_btn_ans.TabIndex = 13;
            this.submit_btn_ans.Text = "Submit";
            this.submit_btn_ans.UseVisualStyleBackColor = true;
            this.submit_btn_ans.Click += new System.EventHandler(this.submit_btn_ans_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Select Ans";
            // 
            // stu_ans_cmb
            // 
            this.stu_ans_cmb.FormattingEnabled = true;
            this.stu_ans_cmb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.stu_ans_cmb.Location = new System.Drawing.Point(127, 251);
            this.stu_ans_cmb.Name = "stu_ans_cmb";
            this.stu_ans_cmb.Size = new System.Drawing.Size(66, 31);
            this.stu_ans_cmb.TabIndex = 11;
            // 
            // opd_txt
            // 
            this.opd_txt.Location = new System.Drawing.Point(682, 173);
            this.opd_txt.Name = "opd_txt";
            this.opd_txt.Size = new System.Drawing.Size(151, 30);
            this.opd_txt.TabIndex = 10;
            this.opd_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // opc_txt
            // 
            this.opc_txt.Location = new System.Drawing.Point(461, 174);
            this.opc_txt.Name = "opc_txt";
            this.opc_txt.Size = new System.Drawing.Size(149, 30);
            this.opc_txt.TabIndex = 9;
            // 
            // opb_txt
            // 
            this.opb_txt.Location = new System.Drawing.Point(243, 177);
            this.opb_txt.Name = "opb_txt";
            this.opb_txt.Size = new System.Drawing.Size(132, 30);
            this.opb_txt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(638, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "D)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "C)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "B)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "A)";
            // 
            // opa_txt
            // 
            this.opa_txt.Location = new System.Drawing.Point(61, 173);
            this.opa_txt.Name = "opa_txt";
            this.opa_txt.Size = new System.Drawing.Size(132, 30);
            this.opa_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Options";
            // 
            // stu_qus_txt
            // 
            this.stu_qus_txt.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stu_qus_txt.Location = new System.Drawing.Point(43, 63);
            this.stu_qus_txt.Name = "stu_qus_txt";
            this.stu_qus_txt.Size = new System.Drawing.Size(621, 37);
            this.stu_qus_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(442, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "Score";
            // 
            // score_lbl
            // 
            this.score_lbl.AutoSize = true;
            this.score_lbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_lbl.Location = new System.Drawing.Point(538, 247);
            this.score_lbl.Name = "score_lbl";
            this.score_lbl.Size = new System.Drawing.Size(26, 30);
            this.score_lbl.TabIndex = 15;
            this.score_lbl.Text = "0";
            // 
            // student_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logout_btn);
            this.Controls.Add(this.Quiz_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "student_quiz";
            this.Text = "student_quiz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.student_quiz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Quiz_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opa_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opd_txt;
        private System.Windows.Forms.TextBox opc_txt;
        private System.Windows.Forms.TextBox opb_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stu_qus_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stu_ans_cmb;
        private System.Windows.Forms.Button submit_btn_ans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label score_lbl;
    }
}