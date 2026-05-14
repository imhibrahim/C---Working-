namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello : "+username.Text);
            if (num1.Text != "" && num2.Text != "")
            {
                int val1 = int.Parse(num1.Text);
                int val2 = int.Parse(num2.Text);
                int result = val1 + val2;
                ans.Text = result.ToString();
                ans.Visible = true;

                //ans.Text = num1.Text;
                //ans.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Insert Input Feild!...............");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "")
            {
                int val1 = int.Parse(num1.Text);
                int val2 = int.Parse(num2.Text);
                int result = val1 / val2;
                ans.Text = result.ToString();
                ans.Visible = true;

                //ans.Text = num1.Text;
                //ans.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Insert Input Feild!...............");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "")
            {
                int val1 = int.Parse(num1.Text);
                int val2 = int.Parse(num2.Text);
                int result = val1 - val2;
                ans.Text = result.ToString();
                ans.Visible = true;

                //ans.Text = num1.Text;
                //ans.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Insert Input Feild!...............");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.Text != "" && num2.Text != "")
            {
                int val1 = int.Parse(num1.Text);
                int val2 = int.Parse(num2.Text);
                int result = val1 * val2;
                ans.Text = result.ToString();
                ans.Visible = true;

                //ans.Text = num1.Text;
                //ans.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Insert Input Feild!...............");
            }
        }
    }
}
