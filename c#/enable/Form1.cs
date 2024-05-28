using System;
using System.Windows.Forms;

public class CourseForm : Form
{
    private CheckedListBox coursesListBox;
    private Label totalLabel;
    private Button calculateButton;

    public CourseForm()
    {
        this.Text = "Curso Selección";
        this.Size = new System.Drawing.Size(300, 200);

        coursesListBox = new CheckedListBox();
        coursesListBox.Location = new System.Drawing.Point(10, 10);
        coursesListBox.Size = new System.Drawing.Size(260, 100);
        coursesListBox.Items.AddRange(new object[] {
            "Access",
            "PL/SQL",
            "Transact-SQL",
            "SQL Server",
            "Oracle",
            "My SQL",
            "Visual studio.net",
            "PHP"
        });
        this.Controls.Add(coursesListBox);

        totalLabel = new Label();
        totalLabel.Location = new System.Drawing.Point(10, 120);
        totalLabel.AutoSize = true;
        this.Controls.Add(totalLabel);

        calculateButton = new Button();
        calculateButton.Location = new System.Drawing.Point(10, 150);
        calculateButton.Size = new System.Drawing.Size(75, 23);
        calculateButton.Text = "Calcular";
        calculateButton.Click += new EventHandler(calculateButton_Click);
        this.Controls.Add(calculateButton);
    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
        int total = 0;
        foreach (var item in coursesListBox.CheckedItems)
        {
            // Here you can add the logic to calculate the total based on the selected courses.
            // For simplicity, I'm assuming each selected course adds 1 to the total.
            total++;
        }

        totalLabel.Text = $"Total: {total}";
    }
}