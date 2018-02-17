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
    public partial class student_quiz : Form
    {
        SqlConnection sq;
        SqlDataAdapter sda;
        DataTable st;
        SqlCommand cmd;
        bool hold=true;
        string answer;
        Int32 total = 0;
        Int32 num = 0;
        public student_quiz()
        {
            InitializeComponent();

        }

        public student_quiz(string name)
        {
            // TODO: Complete member initialization
            this.Name = name;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                        panel1.Visible = true;
            
            sda = new SqlDataAdapter("select * from ques_staff", sq);
             st = new DataTable();
            sda.Fill(st);
            load_ques(num);
            MessageBox.Show("Thank you...!!");
             
            //cmd = new SqlCommand("insert into stu_report values('')");
        
        
        }

        private void load_ques(Int32 num)
        {
            if (num == 0)
            {
                print_ques(st.Rows[0]);
                //num = num + 1;

            }
            else if (num != st.Rows.Count)
            {

                print_ques(st.Rows[num]);

                //num = num + 1;
            }
            else
            {
                MessageBox.Show("Your Score is",total.ToString());
                cmd = new SqlCommand("insert into stu_report values('"+Form1.name.ToString()+"','"+total+"')",sq);
                sq.Open();
                cmd.ExecuteNonQuery();
                delete();
            }
        
        
        }
        
        
        
        private void print_ques(DataRow r) 
        {
            //string quest, opta, optb, optc, optd;
            stu_ans_cmb.Text = " ";
            stu_qus_txt.Text = r.ItemArray[0].ToString();
            opa_txt.Text = r.ItemArray[1].ToString();
            opb_txt.Text = r.ItemArray[2].ToString();
            opc_txt.Text = r.ItemArray[3].ToString();
            opd_txt.Text = r.ItemArray[4].ToString();
            answer = r.ItemArray[5].ToString();
            //hold = false; 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void student_quiz_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            
            sq = new SqlConnection("Data Source=HARI-GS\\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
           // sq.Open();
            label1.Text="Welcome "+Form1.name.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submit_btn_ans_Click(object sender, EventArgs e)
        {
            string ans = stu_ans_cmb.SelectedItem.ToString();
            if (ans.Equals(answer)) 
            {
                MessageBox.Show("Correct!!");
                total = total + 1;
                score_lbl.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Wrong..the Ans is",ans);
                
            }
            //hold = true;
            num = num + 1;
            load_ques(num);
        
        
        }
        private void delete() 
        {
            stu_qus_txt.Text = " ";
            stu_ans_cmb.Text = " ";
            opa_txt.Text = " ";
            opb_txt.Text = " ";
            opc_txt.Text = " ";
            opd_txt.Text = " ";

        
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    
    }
}
