namespace MyFirstForm
    //My First Form Using C# Language
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName;
            firstName = textBox1.Text;
            String lastName;
            lastName = textBox2.Text;
            label3.Text = "Hello " + firstName + " " + lastName;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}