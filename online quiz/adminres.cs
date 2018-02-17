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
    public partial class adminres : Form
    {
        SqlConnection sq;
        //SqlCommand cmd;
        BindingSource bs = new BindingSource();
        public adminres()
        {
            InitializeComponent();
        }

        private void adminres_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.quizDataSet.staff);


            loaddata();

            
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           


           

        }

        private void st_stsbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[2].Value.ToString();
                sq.Open();
                SqlCommand cmd = new SqlCommand("update staff1 set status='true' where id='"+id+"'",sq);
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("updated!!");
                
                dataGridView1.Update();
                dataGridView1.Refresh();
                loaddata();
            }
        }
        private void loaddata() {

            sq = new SqlConnection("Data Source=HARI-GS\\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
            //string s = "staff";
            SqlDataAdapter dtd = new SqlDataAdapter("select staff_name,mail,id,status from staff1 where status='false';", sq);
            DataTable dt = new DataTable();

            //DataSet ds = new DataSet();
            dtd.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            //dataGridView1.databind();
           
        
        }

        private void st_stsflase_Click(object sender, EventArgs e)
        {

            sq = new SqlConnection("Data Source=ADMIN3-PC;Initial Catalog=quiz;Integrated Security=True");
            //string s = "staff";
            SqlDataAdapter dtd = new SqlDataAdapter("select staff_name,mail,id,status from staff1;", sq);
            DataTable dt = new DataTable();

            //DataSet ds = new DataSet();
            dtd.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            



        }

        private void st_dlt_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string id = row.Cells[2].Value.ToString();
                sq.Open();
                SqlCommand cmd = new SqlCommand("delete from staff1 where id='" + id + "'", sq);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted!!");

                dataGridView1.Update();
                dataGridView1.Refresh();
                loaddata();


            }


        }
        
    
    }






}
