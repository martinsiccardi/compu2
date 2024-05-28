using System.Windows.Forms;

namespace actividad_2
{
    public partial class Actividad2 : Form
    {
        private CheckBox[] CheckBoxes;
        private ListBox orderList;
        private Button viewOrderButton;
        private Button clearButton;
        public Actividad2()
        {
            InitializeComponent();
        }

        private void InitializeComponent1()
        {
            CheckBoxes = new CheckBox[]
            {
            new CheckBox { Text = "Frijoles fritos" },
            new CheckBox { Text = "Huevo picado" },
            new CheckBox { Text = "Tortilla" },
            new CheckBox { Text = "Café" },
            new CheckBox { Text = "Jugo de naranja" },
            new CheckBox { Text = "Carne asada" },
            new CheckBox { Text = "Chicharrones" },
            new CheckBox { Text = "Baleada" },
            new CheckBox { Text = "Guineo Verde" },
            new CheckBox { Text = "Queso" },
            new CheckBox { Text = "Mantequilla" },
            new CheckBox { Text = "Sopa de caracol" }
            };

            orderList = new ListBox();

        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();
            foreach (CheckBox checkBox in CheckBoxes)
            {
                if (checkBox.Checked)
                {
                    orderList.Items.Add(checkBox.Text);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in CheckBoxes)
            {
                checkBox.Checked = false;
            }
            orderList.Items.Clear();
        }

    }
}
