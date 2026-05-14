using Microsoft.Data.SqlClient;
using System.Configuration;
namespace Auth
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBox1.Checked;
            switch (check)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true; break;
            }
        }
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "select * from allusers where name = @user and password = @pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@pass", textBox2.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                MessageBox.Show("Login Successfully....", "SUCCESS",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login Feild....", "Failur",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup register = new Signup();
            this.Hide();
            register.ShowDialog();
            this.Close();
            


        }
    }
}
