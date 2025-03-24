namespace Guia1_24_marzo_01_DiegoAlbizuris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            for (int cont = 1; cont < 11; cont++)
            {
                int multi;
                multi = num1 * cont;

                dataGridView1.Rows.Add(num1, cont, multi);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 samy = new Form2();
            samy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 samy = new Form3();
            samy.ShowDialog();
        }
    }
}
