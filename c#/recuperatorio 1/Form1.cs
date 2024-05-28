namespace recuperatorio_1
{
    public partial class actividad1 : Form
    {
        public actividad1()
        {
            InitializeComponent();
            txtSueldo.Enabled = false;
            txtImpuesto.Enabled = false;
            txtSueldoNeto.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldoPorHora = Convert.ToDouble(txtSueldoPorHora.Text);
            double horasTrabajadas = Convert.ToDouble(txtHorasTrabajadas.Text);
            double horasExtras = Convert.ToDouble(txtHorasExtras.Text);

            double sueldoBase = (sueldoPorHora * horasTrabajadas) + (sueldoPorHora * horasExtras);
            double impuesto = sueldoBase * 0.15;
            double sueldoNeto = sueldoBase - impuesto;

            txtSueldo.Text = sueldoBase.ToString();
            txtImpuesto.Text = impuesto.ToString();
            txtSueldoNeto.Text = sueldoNeto.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldoPorHora.Clear();
            txtHorasTrabajadas.Clear();
            txtHorasExtras.Clear();
            txtSueldo.Clear();
            txtImpuesto.Clear();
            txtSueldoNeto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
