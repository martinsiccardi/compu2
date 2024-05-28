namespace recuperatorio_1
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
            groupBox1 = new GroupBox();
            txtHorasExtras = new TextBox();
            txtHorasTrabajadas = new TextBox();
            txtSueldoPorHora = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtSueldoNeto = new TextBox();
            txtImpuesto = new TextBox();
            txtSueldo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHorasExtras);
            groupBox1.Controls.Add(txtHorasTrabajadas);
            groupBox1.Controls.Add(txtSueldoPorHora);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(128, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // txtHorasExtras
            // 
            txtHorasExtras.Location = new Point(160, 106);
            txtHorasExtras.Name = "txtHorasExtras";
            txtHorasExtras.Size = new Size(112, 23);
            txtHorasExtras.TabIndex = 7;
            // 
            // txtHorasTrabajadas
            // 
            txtHorasTrabajadas.Location = new Point(177, 77);
            txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            txtHorasTrabajadas.Size = new Size(95, 23);
            txtHorasTrabajadas.TabIndex = 6;
            // 
            // txtSueldoPorHora
            // 
            txtSueldoPorHora.Location = new Point(118, 44);
            txtSueldoPorHora.Name = "txtSueldoPorHora";
            txtSueldoPorHora.Size = new Size(154, 23);
            txtSueldoPorHora.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(170, 23);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 47);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Sueldo x hora";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 80);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 2;
            label3.Text = "Cantidad de horas trabajadas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 109);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de horas extras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnLimpiar);
            groupBox2.Controls.Add(btnCalcular);
            groupBox2.Controls.Add(txtSueldoNeto);
            groupBox2.Controls.Add(txtImpuesto);
            groupBox2.Controls.Add(txtSueldo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(128, 228);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calculo";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(218, 82);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(218, 53);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(218, 21);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtSueldoNeto
            // 
            txtSueldoNeto.Location = new Point(92, 79);
            txtSueldoNeto.Name = "txtSueldoNeto";
            txtSueldoNeto.Size = new Size(95, 23);
            txtSueldoNeto.TabIndex = 10;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(80, 53);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(95, 23);
            txtImpuesto.TabIndex = 9;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(66, 26);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(95, 23);
            txtSueldo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 56);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Impuesto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 82);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 5;
            label6.Text = "Salario neto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 29);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Sueldo";
            // 
            // actividad1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "actividad1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtSueldoPorHora;
        private TextBox txtNombre;
        private TextBox txtHorasExtras;
        private TextBox txtHorasTrabajadas;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtSueldoNeto;
        private TextBox txtImpuesto;
        private TextBox txtSueldo;
    }
}
