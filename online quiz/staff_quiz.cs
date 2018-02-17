using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace online_quiz
{
    public partial class staff_quiz : Form
    {

        SqlConnection sq;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        BindingSource bs = new BindingSource();
        string ansof_qus;
        public staff_quiz()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void staff_quiz_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            sq = new SqlConnection("Data Source=HARI-GS\\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
            sq.Open();
            
        }

        private void ans_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ansof_qus = ans_cmb.SelectedItem.ToString();
        }

        private void out_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void Res_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            sda = new SqlDataAdapter("select * from stu_report",sq);
            dt = new DataTable();
            sda.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into ques_staff values('" + ques_txt.Text + "','" + opt_a.Text + "','" + opt_b.Text + "','" + opt_c.Text + "','" + opt_d.Text + "','" + ansof_qus + "')", sq);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted");
            delete();
        }

        private void delete() 
        {
            ques_txt.Text = " ";
            opt_a.Text = " ";
            opt_b.Text = " ";
            opt_c.Text = " ";
            opt_d.Text = " ";
            ans_cmb.Text = " ";
        
        }
    
    }

}
