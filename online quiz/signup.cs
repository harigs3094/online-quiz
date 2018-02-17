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
    public partial class signup : Form
    {
        string s,des;
        public signup()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=HARI-GS\\SQLEXPRESS;Initial Catalog=quiz;Integrated Security=True");
        SqlCommand cmd;
        private void subbtn_Click(object sender, EventArgs e)
        {
        
            con.Open();
             cmd = new SqlCommand("insert into signup1 values('"+unametxt.Text+"', '"+spasstxt.Text+"', '"+scpasstxt.Text+"' , '"+mailtxt.Text+"','"+s+"','"+des+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("inserted");

            staff_stat();
            
            con.Close();
           
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Close();


        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            unametxt.Text = "";
            scpasstxt.Text = "";
            spasstxt.Text = "";
            mailtxt.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                 s = openFileDialog1.FileName;
                
            
            
            }
        }

        private void des_SelectedIndexChanged(object sender, EventArgs e)
        {
            des = desing.SelectedItem.ToString();


        }
        private void staff_stat() {

            string st="False";
            //con.Open();
            if (des.Equals("Staff"))
            {

                cmd = new SqlCommand("insert into staff1 values ('" + unametxt.Text + "','" + spasstxt.Text + "','" + mailtxt.Text + "','" + s + "','" + st + "')", con);
                cmd.ExecuteNonQuery();

            }
            else {

                cmd = new SqlCommand("insert into stu_login values ('" + unametxt.Text + "','" + spasstxt.Text + "','" + mailtxt.Text + "','" + s + "')", con);
                cmd.ExecuteNonQuery();

            
            }
            con.Close();
        
        }

        private void signup_Load(object sender, EventArgs e)
        {
           
            
        }
    
    
    }
}
