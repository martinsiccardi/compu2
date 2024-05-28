namespace _02_ejercicio1
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
            TxtCorrectas = new TextBox();
            TxtBlancos = new TextBox();
            TxtIncorrectas = new TextBox();
            TxtCorrecta = new Label();
            Txt = new Label();
            TxtIncorrecta = new Label();
            btnCalcular = new Button();
            btnSalir = new Button();
            btnNuevoCalculo = new Button();
            txtPuntajeTotal = new Label();
            SuspendLayout();
            // 
            // TxtCorrectas
            // 
            TxtCorrectas.Location = new Point(195, 74);
            TxtCorrectas.Name = "TxtCorrectas";
            TxtCorrectas.Size = new Size(326, 23);
            TxtCorrectas.TabIndex = 0;
            // 
            // TxtBlancos
            // 
            TxtBlancos.Location = new Point(195, 166);
            TxtBlancos.Name = "TxtBlancos";
            TxtBlancos.Size = new Size(326, 23);
            TxtBlancos.TabIndex = 1;
            // 
            // TxtIncorrectas
            // 
            TxtIncorrectas.Location = new Point(195, 119);
            TxtIncorrectas.Name = "TxtIncorrectas";
            TxtIncorrectas.Size = new Size(326, 23);
            TxtIncorrectas.TabIndex = 2;
            // 
            // TxtCorrecta
            // 
            TxtCorrecta.AutoSize = true;
            TxtCorrecta.Location = new Point(115, 74);
            TxtCorrecta.Name = "TxtCorrecta";
            TxtCorrecta.Size = new Size(57, 15);
            TxtCorrecta.TabIndex = 3;
            TxtCorrecta.Text = "Correctas";
            // 
            // Txt
            // 
            Txt.AutoSize = true;
            Txt.Location = new Point(115, 166);
            Txt.Name = "Txt";
            Txt.Size = new Size(59, 15);
            Txt.TabIndex = 4;
            Txt.Text = "En blanco";
            // 
            // TxtIncorrecta
            // 
            TxtIncorrecta.AutoSize = true;
            TxtIncorrecta.Location = new Point(115, 119);
            TxtIncorrecta.Name = "TxtIncorrecta";
            TxtIncorrecta.Size = new Size(60, 15);
            TxtIncorrecta.TabIndex = 5;
            TxtIncorrecta.Text = "Incorrecta";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(149, 245);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(410, 245);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCalculo
            // 
            btnNuevoCalculo.Location = new Point(276, 245);
            btnNuevoCalculo.Name = "btnNuevoCalculo";
            btnNuevoCalculo.Size = new Size(75, 23);
            btnNuevoCalculo.TabIndex = 8;
            btnNuevoCalculo.Text = "Nuevo";
            btnNuevoCalculo.UseVisualStyleBackColor = true;
            // 
            // txtPuntajeTotal
            // 
            txtPuntajeTotal.AutoSize = true;
            txtPuntajeTotal.Location = new Point(276, 211);
            txtPuntajeTotal.Name = "txtPuntajeTotal";
            txtPuntajeTotal.Size = new Size(39, 15);
            txtPuntajeTotal.TabIndex = 9;
            txtPuntajeTotal.Text = "TOTAL";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPuntajeTotal);
            Controls.Add(btnNuevoCalculo);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(TxtIncorrecta);
            Controls.Add(Txt);
            Controls.Add(TxtCorrecta);
            Controls.Add(TxtIncorrectas);
            Controls.Add(TxtBlancos);
            Controls.Add(TxtCorrectas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtCorrectas;
        private TextBox TxtBlancos;
        private TextBox TxtIncorrectas;
        private Label TxtCorrecta;
        private Label Txt;
        private Label TxtIncorrecta;
        private Button btnCalcular;
        private Button btnSalir;
        private Button btnNuevoCalculo;
        private Label txtPuntajeTotal;
    }
}
