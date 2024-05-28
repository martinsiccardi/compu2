namespace tp_programacion
{
    partial class Form1
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
            pesosLabel = new Label();
            textBoxPesos = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            cleanButton = new Button();
            eurosLabel = new Label();
            label3 = new Label();
            dolaresLabel = new Label();
            label5 = new Label();
            txtEuros = new TextBox();
            txtDolares = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // pesosLabel
            // 
            pesosLabel.AutoSize = true;
            pesosLabel.Location = new Point(58, 50);
            pesosLabel.Name = "pesosLabel";
            pesosLabel.Size = new Size(49, 15);
            pesosLabel.TabIndex = 0;
            pesosLabel.Text = "pesos: $";
            // 
            // txtPesos
            // 
            txtPesos.Location = new Point(103, 47);
            txtPesos.Name = "txtPesos";
            txtPesos.Size = new Size(100, 23);
            txtPesos.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(70, 107);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "calcular";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(70, 165);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "salir";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            cleanButton.Location = new Point(70, 136);
            cleanButton.Name = "cleanButton";
            cleanButton.Size = new Size(75, 23);
            cleanButton.TabIndex = 4;
            cleanButton.Text = "limpiar";
            cleanButton.UseVisualStyleBackColor = true;
            // 
            // eurosLabel
            // 
            eurosLabel.AutoSize = true;
            eurosLabel.Location = new Point(381, 169);
            eurosLabel.Name = "eurosLabel";
            eurosLabel.Size = new Size(36, 15);
            eurosLabel.TabIndex = 5;
            eurosLabel.Text = "Euros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 168);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Pesos=";
            // 
            // dolaresLabel
            // 
            dolaresLabel.AutoSize = true;
            dolaresLabel.Location = new Point(381, 115);
            dolaresLabel.Name = "dolaresLabel";
            dolaresLabel.Size = new Size(46, 15);
            dolaresLabel.TabIndex = 7;
            dolaresLabel.Text = "Dolares";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 115);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 8;
            label5.Text = "Pesos=";
            // 
            // txtEuros
            // 
            txtEuros.Location = new Point(307, 166);
            txtEuros.Name = "txtEuros";
            txtEuros.Size = new Size(68, 23);
            txtEuros.TabIndex = 9;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(307, 112);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(68, 23);
            txtDolares.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(189, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(189, 112);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(68, 23);
            textBox5.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtDolares);
            Controls.Add(txtEuros);
            Controls.Add(label5);
            Controls.Add(dolaresLabel);
            Controls.Add(label3);
            Controls.Add(eurosLabel);
            Controls.Add(cleanButton);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(txtPesos);
            Controls.Add(pesosLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pesosLabel;
        private TextBox txtPesos;
        private Button calculateButton;
        private Button exitButton;
        private Button cleanButton;
        private Label eurosLabel;
        private Label label3;
        private Label dolaresLabel;
        private Label label5;
        private TextBox txtEuros;
        private TextBox txtDolares;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
