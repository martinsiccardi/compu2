namespace programacion
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

        private void button3_Click(object sender, EventArgs e)
        {
            frmusuarios form2 = new frmusuarios();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmventas form2 = new frmventas();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmproductos form2 = new frmproductos();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmvendidos form2 = new frmvendidos();
            form2.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {

        }
    }
}

