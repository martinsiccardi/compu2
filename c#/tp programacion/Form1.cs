namespace tp_programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double pesos = double.Parse(textBoxPesos.Text);

            double dolares = pesos / 880;
            double euros = pesos / 947.80;

            textBoxDolares.Text = dolares.ToString("0.00");
            textBoxEuros.Text = euros.ToString("0.00");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPesos.Text = "";
            textBoxDolares.Text = "";
            textBoxEuros.Text = "";
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
