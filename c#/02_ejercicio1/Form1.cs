namespace _02_ejercicio1
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnCalcular_Click(object sender, EventArgs e)
            {
                // Variables para almacenar las respuestas
                int respuestasCorrectas = int.Parse(TxtCorrectas.Text);
                int respuestasIncorrectas = int.Parse(TxtIncorrectas.Text);
                int respuestasEnBlanco = int.Parse(TxtBlancos.Text);

                // Calcular el puntaje total
                int puntajeTotal = (respuestasCorrectas * 4) + (respuestasIncorrectas * -1);

                // Mostrar el puntaje total
                txtPuntajeTotal.Text = puntajeTotal.ToString();
            }

            private void btnNuevoCalculo_Click(object sender, EventArgs e)
            {
                // Limpiar los cuadros de texto
                TxtCorrectas.Clear();
                TxtIncorrectas.Clear();
                TxtBlancos.Clear();
                txtPuntajeTotal.Clear();
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                // Salir de la aplicación
                Application.Exit();
            }
        }
    }
