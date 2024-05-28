namespace LISTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltsFrutas.SelectedIndex != -1)
            {
                lblseleccion.Text = (string)ltsFrutas.Items[ltsFrutas.SelectedIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ltsFrutas.Items.Add(txtFruta.Text);
            txtFruta.Text = string.Empty;
        }

        private void ltsFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btbEliminar_Click(object sender, EventArgs e)
        {
            int indice = ltsFrutas.SelectedIndex;
            if (indice != -1)
            {
                ltsFrutas.Items.RemoveAt(indice);
            }
        }
    }
}

