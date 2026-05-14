using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Auth
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginform login = new loginform();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username.Text) == true)
            {
                username.Focus();
                errorProvider1.SetError(this.username, "Please Fill The User name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void mail_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mail.Text) == true)
            {
                mail.Focus();
                errorProvider2.SetError(this.mail, "Please Fill The Email");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(password.Text) == true)
            {
                password.Focus();
                errorProvider3.SetError(this.password, "Please Fill Password");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void confirmpassword_Leave(object sender, EventArgs e)
        {
            if (password.Text != confirmpassword.Text)
            {
                errorProvider5.SetError(this.confirmpassword, "Password Doed Not Match");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "insert into allusers(name,mail,password,gander)" +
                "values(@name,@mail,@pass,@gander)";
            String query2 = "select * from allusers where mail=@mail";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@mail", mail.Text);
            con.Open();
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.HasRows == true)
            {  MessageBox.Show(mail.Text+"Alreade Exits", "Failed",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
            else
            {    con.Close();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", username.Text);
                cmd.Parameters.AddWithValue("@mail", mail.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);
                cmd.Parameters.AddWithValue("@gander", gander.Text);
                con.Open();
                int dr = cmd.ExecuteNonQuery();
                if (dr > 0)
                {
                    MessageBox.Show("Account created Successfully....", "SUCCESS",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginform login = new loginform();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account create Feild....", "Failur",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
          




            
        }
    }
}
