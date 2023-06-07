namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Random rand = new Random();
        public int stor;
        public int value;
        public int jj = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                stor = int.Parse(textBox1.Text);
                button2.Enabled = true;
                value = rand.Next(stor + 1);
                button1.Enabled = false;
            }
            catch 
            {
                MessageBox.Show($"YOU HAVE TO WRITE SOMETHING!!!", "STOOOOP!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox3.Text) == value)
                {
                    jj++;
                    listBox1.Items.Add(jj);
                    button2.Enabled = false;
                    textBox2.Text = value.ToString();
                }
                else
                {
                    button2.Enabled = false;
                    textBox2.Text = value.ToString();
                }
            }
            catch
            {
                MessageBox.Show($"YOU HAVE TO GUSSE A NUMBER BTWEEN 0-{stor}!!!","WHAT ARE YOU DOING!!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            button3.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Clear();
                stor = int.Parse(textBox1.Text);
                button2.Enabled = true;
                value = rand.Next(stor + 1);
                button3.Enabled = false;
                textBox3.Clear();
            }
            catch
            {
                MessageBox.Show($"YOU HAVE TO WRITE SOMETHING!!!", "STOOOOP!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}