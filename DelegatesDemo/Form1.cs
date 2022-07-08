namespace DelegatesDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click Here";
            b.Size = new Size(100, 50);
            b.Location = new Point(150, 150);
            this.Controls.Add(b);
            // b.Click += new EventHandler(b_Click); //delegate

            //or

            //b.Click += delegate (object sender, EventArgs e)
            //{
            //    MessageBox.Show("Hello World");
            //};

            //or
            //b.Click += delegate
            //{
            //    MessageBox.Show("Hello World");
            //};

            //or  - lamda Expression
            b.Click += (sender,ev) =>
            {
                MessageBox.Show("Hello World");
            };

        }

        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}