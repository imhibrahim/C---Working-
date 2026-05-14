namespace listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fruitlist.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int data = fruitlist.Items.Count;
            MessageBox.Show("Total List is : " + data.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fruitlist.Sorted = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fruitlist.Items.RemoveAt(fruitlist.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fruitlist.Items.Clear();
        }
    }
}
   