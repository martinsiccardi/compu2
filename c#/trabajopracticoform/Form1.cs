
namespace trabajopracticoform
{
    public partial class actividad1 : Form
    {
        private const decimal Dolar = 880;
        private const decimal Euro = 947.80m;
        public actividad1()
        {
            InitializeComponent();
        }

        private void actividad1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPesos.Text, out decimal pesos))
            {
                txtDolares.Text = $"{pesos / Dolar:C2}";
                txtEuros.Text = $"{pesos / Euro:C2}";
                txtPesos.Text = txtPesos.Text;
                txtPesos1.Text = txtPesos.Text;

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            {
                txtPesos.Clear();
                txtDolares.Text = "0.00";
                txtEuros.Text = "0.00";
                txtPesos.Text = "0.00";
                txtPesos.Text = "0.00";
            }
        }

        private void Groupcalculos_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}