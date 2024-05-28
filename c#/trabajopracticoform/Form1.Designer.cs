namespace trabajopracticoform
{
    partial class actividad1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pesos = new Label();
            lbleuros = new Label();
            lbldolares = new Label();
            Pesos2 = new Label();
            Pesos1 = new Label();
            textBox1 = new TextBox();
            txtEuros = new TextBox();
            txtDolares = new TextBox();
            txtPesos1 = new TextBox();
            txtPesos = new TextBox();
            BtnCalcular = new Button();
            BtnSalir = new Button();
            BtnLimpiar = new Button();
            Groupcalculos = new GroupBox();
            grouppesos = new GroupBox();
            Groupcalculos.SuspendLayout();
            grouppesos.SuspendLayout();
            SuspendLayout();
            // 
            // Pesos
            // 
            Pesos.AutoSize = true;
            Pesos.Location = new Point(21, 25);
            Pesos.Name = "Pesos";
            Pesos.Size = new Size(49, 15);
            Pesos.TabIndex = 0;
            Pesos.Text = "Pesos: $";
            // 
            // lbleuros
            // 
            lbleuros.AutoSize = true;
            lbleuros.Location = new Point(368, 91);
            lbleuros.Name = "lbleuros";
            lbleuros.Size = new Size(36, 15);
            lbleuros.TabIndex = 1;
            lbleuros.Text = "Euros";
            // 
            // lbldolares
            // 
            lbldolares.AutoSize = true;
            lbldolares.Location = new Point(368, 37);
            lbldolares.Name = "lbldolares";
            lbldolares.Size = new Size(46, 15);
            lbldolares.TabIndex = 2;
            lbldolares.Text = "Dolares";
            // 
            // Pesos2
            // 
            Pesos2.AutoSize = true;
            Pesos2.Location = new Point(213, 91);
            Pesos2.Name = "Pesos2";
            Pesos2.Size = new Size(37, 15);
            Pesos2.TabIndex = 3;
            Pesos2.Text = "Pesos";
            // 
            // Pesos1
            // 
            Pesos1.AutoSize = true;
            Pesos1.Location = new Point(213, 37);
            Pesos1.Name = "Pesos1";
            Pesos1.Size = new Size(37, 15);
            Pesos1.TabIndex = 4;
            Pesos1.Text = "Pesos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // txtEuros
            // 
            txtEuros.Location = new Point(262, 88);
            txtEuros.Name = "txtEuros";
            txtEuros.Size = new Size(100, 23);
            txtEuros.TabIndex = 6;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(262, 34);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 7;
            // 
            // txtPesos1
            // 
            txtPesos1.Location = new Point(107, 88);
            txtPesos1.Name = "txtPesos1";
            txtPesos1.Size = new Size(100, 23);
            txtPesos1.TabIndex = 8;
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(107, 34);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(100, 23);
            txtPesos.TabIndex = 9;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(11, 30);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(75, 23);
            BtnCalcular.TabIndex = 10;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click_1;
            // 
            // BtnSalir
            // 
            BtnSalir.Location = new Point(11, 87);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(75, 23);
            BtnSalir.TabIndex = 11;
            BtnSalir.Text = "Salir";
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Location = new Point(11, 59);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(75, 23);
            BtnLimpiar.TabIndex = 12;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click_1;
            // 
            // Groupcalculos
            // 
            Groupcalculos.Controls.Add(txtPesos);
            Groupcalculos.Controls.Add(BtnLimpiar);
            Groupcalculos.Controls.Add(lbleuros);
            Groupcalculos.Controls.Add(BtnSalir);
            Groupcalculos.Controls.Add(lbldolares);
            Groupcalculos.Controls.Add(BtnCalcular);
            Groupcalculos.Controls.Add(Pesos2);
            Groupcalculos.Controls.Add(Pesos1);
            Groupcalculos.Controls.Add(txtPesos1);
            Groupcalculos.Controls.Add(txtEuros);
            Groupcalculos.Controls.Add(txtDolares);
            Groupcalculos.Location = new Point(54, 90);
            Groupcalculos.Name = "Groupcalculos";
            Groupcalculos.Size = new Size(429, 142);
            Groupcalculos.TabIndex = 13;
            Groupcalculos.TabStop = false;
            Groupcalculos.Enter += Groupcalculos_Enter;
            // 
            // grouppesos
            // 
            grouppesos.Controls.Add(textBox1);
            grouppesos.Controls.Add(Pesos);
            grouppesos.Location = new Point(54, 32);
            grouppesos.Name = "grouppesos";
            grouppesos.Size = new Size(200, 52);
            grouppesos.TabIndex = 14;
            grouppesos.TabStop = false;
            // 
            // actividad1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grouppesos);
            Controls.Add(Groupcalculos);
            Name = "actividad1";
            Text = "Form1";
            Groupcalculos.ResumeLayout(false);
            Groupcalculos.PerformLayout();
            grouppesos.ResumeLayout(false);
            grouppesos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Pesos;
        private Label lbleuros;
        private Label lbldolares;
        private Label Pesos2;
        private Label Pesos1;
        private TextBox textBox1;
        private TextBox txtEuros;
        private TextBox txtDolares;
        private TextBox txtPesos1;
        private TextBox txtPesos;
        private Button BtnCalcular;
        private Button BtnSalir;
        private Button BtnLimpiar;
        private GroupBox Groupcalculos;
        private GroupBox grouppesos;
    }
}
