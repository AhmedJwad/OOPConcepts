using OOPConcepts.Logic;

namespace OOPConcepts.UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("you must enter a year", "Error");
                return;
            };
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("you must enter amonth", "Error");
                return;
            };
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("you must enter a day", "Error");
                return;
            };
            try
            {
                int year = Convert.ToInt32(textBox1.Text);
                int month = Convert.ToInt32(textBox2.Text);
                int day = Convert.ToInt32(textBox3.Text);
                var date = new Date(year, month, day);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"something wrong accured{ex.Message}:", "Error");
            }

        }
    }
}
