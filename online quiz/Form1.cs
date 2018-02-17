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
    public partial class Form1 : Form
    {
        public static string name;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=HARI-GS\\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
       sq.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select name,pass from stu_login where name='"+nametxt.Text+"' and pass='"+passtxt.Text+"'" ,sq);
            DataTable dt= new DataTable();
            sda.Fill(dt);
            name = nametxt.Text.ToString();
            if (dt.Rows.Count >0)
            {
               // string name=nametxt.Text;
                student_quiz stq = new student_quiz();
                
                stq.Show();
                this.Hide();

            }
            SqlDataAdapter st_sda = new SqlDataAdapter("select staff_name,pass,status from staff1 where staff_name='"+nametxt.Text+"' and pass='"+passtxt.Text+"'" ,sq);
            DataTable st_dt= new DataTable();
            st_sda.Fill(st_dt);
            if (st_dt.Rows.Count > 0)
            {

                string st_res = st_dt.Rows[0][2].ToString();
                if(st_res.Equals("true"))
                {
                    staff_quiz stq = new staff_quiz();
                    stq.Show();
                    this.Hide();
                }

                else if (st_res.Equals("False"))
                {
                    MessageBox.Show("Your Request is hold.......!login some other time");
                }


                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            
            
            }

           
            

            


            }

        private void signupbtn_Click(object sender, EventArgs e)
        {
             signup sg = new signup();
             sg.Show();
             this.Hide();
        
        }

        private void cleartxt_Click(object sender, EventArgs e)
        {
        nametxt.Text = "";
            passtxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
         adminres ob = new adminres();
            ob.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
            
 

            
        }
          
            
        

      

       
    }

