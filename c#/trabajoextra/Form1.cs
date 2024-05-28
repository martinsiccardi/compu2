namespace trabajoextra
{
    public partial class Form1 : Form
    {
        private List<int> numeros;

        public Form1()
        {
            InitializeComponent();
            numeros = new List<int>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumero.Text, out int numero))
            {
                if (numeros.Count < 10)
                {
                    numeros.Add(numero);
                    listBoxNumeros.Items.Add(numero);
                    textBoxNumero.Clear();
                }
                else
                {
                    MessageBox.Show("Ya ha ingresado 10 números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxNumeros.Items.Count < 5)
            {
                MessageBox.Show("Debe ingresar al menos 5 números para calcular.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> numeros = listBoxNumeros.Items.Cast<int>().ToList();

            if (checkBoxMostrarSuma.Checked)
            {
                int suma = numeros.Sum();
                textBoxSuma.Text = suma.ToString();
            }

            if (checkBoxMostrarProducto.Checked)
            {
                long producto = numeros.Aggregate(1L, (acc, x) => acc * x);
                textBoxProducto.Text = producto.ToString();
            }

            textBoxSuma.Enabled = checkBoxMostrarSuma.Checked;
            textBoxProducto.Enabled = checkBoxMostrarProducto.Checked;
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            numeros.Clear();
            listBoxNumeros.Items.Clear();
            textBoxSuma.Clear();
            textBoxProducto.Clear();
        }

        private void buttonQuitar_Click(object sender, EventArgs e)
        {
            if (listBoxNumeros.SelectedIndex >= 0)
            {
                listBoxNumeros.Items.RemoveAt(listBoxNumeros.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un número para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
