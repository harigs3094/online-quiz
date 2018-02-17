namespace online_quiz
{
    partial class staff_quiz
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
            this.ques_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.opt_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.opt_b = new System.Windows.Forms.TextBox();
            this.opt_c = new System.Windows.Forms.TextBox();
            this.opt_d = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ans_cmb = new System.Windows.Forms.ComboBox();
            this.Res_btn = new System.Windows.Forms.Button();
            this.out_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Quiz";
            // 
            // ques_txt
            // 
            this.ques_txt.Location = new System.Drawing.Point(106, 77);
            this.ques_txt.Name = "ques_txt";
            this.ques_txt.Size = new System.Drawing.Size(435, 30);
            this.ques_txt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Options";
            // 
            // opt_a
            // 
            this.opt_a.Location = new System.Drawing.Point(55, 186);
            this.opt_a.Name = "opt_a";
            this.opt_a.Size = new System.Drawing.Size(113, 30);
            this.opt_a.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "A)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "B)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "C)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "D)";
            // 
            // opt_b
            // 
            this.opt_b.Location = new System.Drawing.Point(235, 186);
            this.opt_b.Name = "opt_b";
            this.opt_b.Size = new System.Drawing.Size(113, 30);
            this.opt_b.TabIndex = 9;
            // 
            // opt_c
            // 
            this.opt_c.Location = new System.Drawing.Point(415, 186);
            this.opt_c.Name = "opt_c";
            this.opt_c.Size = new System.Drawing.Size(113, 30);
            this.opt_c.TabIndex = 10;
            // 
            // opt_d
            // 
            this.opt_d.Location = new System.Drawing.Point(604, 186);
            this.opt_d.Name = "opt_d";
            this.opt_d.Size = new System.Drawing.Size(113, 30);
            this.opt_d.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(742, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ans";
            // 
            // ans_cmb
            // 
            this.ans_cmb.FormattingEnabled = true;
            this.ans_cmb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.ans_cmb.Location = new System.Drawing.Point(786, 183);
            this.ans_cmb.Name = "ans_cmb";
            this.ans_cmb.Size = new System.Drawing.Size(48, 31);
            this.ans_cmb.TabIndex = 13;
            this.ans_cmb.SelectedIndexChanged += new System.EventHandler(this.ans_cmb_SelectedIndexChanged);
            // 
            // Res_btn
            // 
            this.Res_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Res_btn.Location = new System.Drawing.Point(403, 280);
            this.Res_btn.Name = "Res_btn";
            this.Res_btn.Size = new System.Drawing.Size(217, 46);
            this.Res_btn.TabIndex = 14;
            this.Res_btn.Text = "Results Of student";
            this.Res_btn.UseVisualStyleBackColor = true;
            this.Res_btn.Click += new System.EventHandler(this.Res_btn_Click);
            // 
            // out_btn
            // 
            this.out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.out_btn.Location = new System.Drawing.Point(914, 53);
            this.out_btn.Name = "out_btn";
            this.out_btn.Size = new System.Drawing.Size(89, 35);
            this.out_btn.TabIndex = 15;
            this.out_btn.Text = "Logout";
            this.out_btn.UseVisualStyleBackColor = true;
            this.out_btn.Click += new System.EventHandler(this.out_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 382);
            this.dataGridView1.TabIndex = 16;
            // 
            // insert_btn
            // 
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_btn.Location = new System.Drawing.Point(855, 177);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(148, 35);
            this.insert_btn.TabIndex = 17;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // staff_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1356, 741);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.out_btn);
            this.Controls.Add(this.Res_btn);
            this.Controls.Add(this.ans_cmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.opt_d);
            this.Controls.Add(this.opt_c);
            this.Controls.Add(this.opt_b);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.opt_a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ques_txt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "staff_quiz";
            this.Text = "staff_quiz";
            this.Load += new System.EventHandler(this.staff_quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ques_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox opt_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox opt_b;
        private System.Windows.Forms.TextBox opt_c;
        private System.Windows.Forms.TextBox opt_d;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ans_cmb;
        private System.Windows.Forms.Button Res_btn;
        private System.Windows.Forms.Button out_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insert_btn;
    }
}