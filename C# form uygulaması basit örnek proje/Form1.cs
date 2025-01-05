namespace C__form_uygulaması_basit_örnek_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.AutoSize = true;
            button2.AutoSize = true;
            button3.AutoSize = true;
            button1.Text = "textBox'a yaz";
            button2.Text = "Sil";
            button3.Text = "Programı kapat";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Merhaba,bu benim ilk programım!";
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.Pink;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
