namespace online_quiz
{
    partial class adminres
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.quizDataSet = new online_quiz.quizDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new online_quiz.quizDataSetTableAdapters.staffTableAdapter();
            this.st_stsbtn = new System.Windows.Forms.Button();
            this.st_dlt = new System.Windows.Forms.Button();
            this.st_update = new System.Windows.Forms.Button();
            this.st_stsflase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(826, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Requests";
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "quizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.quizDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // st_stsbtn
            // 
            this.st_stsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_stsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_stsbtn.Location = new System.Drawing.Point(921, 129);
            this.st_stsbtn.Name = "st_stsbtn";
            this.st_stsbtn.Size = new System.Drawing.Size(108, 59);
            this.st_stsbtn.TabIndex = 2;
            this.st_stsbtn.Text = "Check_true";
            this.st_stsbtn.UseVisualStyleBackColor = true;
            this.st_stsbtn.Click += new System.EventHandler(this.st_stsbtn_Click);
            // 
            // st_dlt
            // 
            this.st_dlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_dlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_dlt.Location = new System.Drawing.Point(921, 317);
            this.st_dlt.Name = "st_dlt";
            this.st_dlt.Size = new System.Drawing.Size(108, 59);
            this.st_dlt.TabIndex = 4;
            this.st_dlt.Text = "Delete";
            this.st_dlt.UseVisualStyleBackColor = true;
            this.st_dlt.Click += new System.EventHandler(this.st_dlt_Click);
            // 
            // st_update
            // 
            this.st_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_update.Location = new System.Drawing.Point(921, 403);
            this.st_update.Name = "st_update";
            this.st_update.Size = new System.Drawing.Size(108, 59);
            this.st_update.TabIndex = 5;
            this.st_update.Text = "Update";
            this.st_update.UseVisualStyleBackColor = true;
            // 
            // st_stsflase
            // 
            this.st_stsflase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.st_stsflase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_stsflase.Location = new System.Drawing.Point(921, 224);
            this.st_stsflase.Name = "st_stsflase";
            this.st_stsflase.Size = new System.Drawing.Size(108, 59);
            this.st_stsflase.TabIndex = 3;
            this.st_stsflase.Text = "All_Data";
            this.st_stsflase.UseVisualStyleBackColor = true;
            this.st_stsflase.Click += new System.EventHandler(this.st_stsflase_Click);
            // 
            // adminres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.st_update);
            this.Controls.Add(this.st_dlt);
            this.Controls.Add(this.st_stsflase);
            this.Controls.Add(this.st_stsbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminres";
            this.Text = "adminres";
            this.Load += new System.EventHandler(this.adminres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private quizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private quizDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button st_stsbtn;
        private System.Windows.Forms.Button st_dlt;
        private System.Windows.Forms.Button st_update;
        private System.Windows.Forms.Button st_stsflase;
    }
}