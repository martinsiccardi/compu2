namespace enable
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
            lblenabled = new Label();
            lbltotal = new Label();
            lblfrecuencia = new Label();
            btbcalcular = new Button();
            btbborrar = new Button();
            textBox1 = new TextBox();
            chcpaquete = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            raddiasemana = new RadioButton();
            radsabadodomingo = new RadioButton();
            SuspendLayout();
            // 
            // lblenabled
            // 
            lblenabled.AutoSize = true;
            lblenabled.Location = new Point(267, 71);
            lblenabled.Name = "lblenabled";
            lblenabled.Size = new Size(213, 15);
            lblenabled.TabIndex = 0;
            lblenabled.Text = "seleccione el curso al que deceas asistir";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(182, 289);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(32, 15);
            lbltotal.TabIndex = 1;
            lbltotal.Text = "Total";
            // 
            // lblfrecuencia
            // 
            lblfrecuencia.AutoSize = true;
            lblfrecuencia.Location = new Point(381, 270);
            lblfrecuencia.Name = "lblfrecuencia";
            lblfrecuencia.Size = new Size(64, 15);
            lblfrecuencia.TabIndex = 2;
            lblfrecuencia.Text = "Frecuencia";
            lblfrecuencia.Click += lblnombre_Click;
            // 
            // btbcalcular
            // 
            btbcalcular.Location = new Point(45, 270);
            btbcalcular.Name = "btbcalcular";
            btbcalcular.Size = new Size(75, 23);
            btbcalcular.TabIndex = 4;
            btbcalcular.Text = "Calcular";
            btbcalcular.UseVisualStyleBackColor = true;
            // 
            // btbborrar
            // 
            btbborrar.Location = new Point(45, 317);
            btbborrar.Name = "btbborrar";
            btbborrar.Size = new Size(75, 46);
            btbborrar.TabIndex = 7;
            btbborrar.Text = "Borrar";
            btbborrar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(79, 23);
            textBox1.TabIndex = 8;
            // 
            // chcpaquete
            // 
            chcpaquete.AutoSize = true;
            chcpaquete.Location = new Point(381, 114);
            chcpaquete.Name = "chcpaquete";
            chcpaquete.Size = new Size(62, 19);
            chcpaquete.TabIndex = 9;
            chcpaquete.Text = "Access";
            chcpaquete.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(381, 202);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "VISUALSTUDIO. NET";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(381, 177);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(116, 19);
            checkBox2.TabIndex = 11;
            checkBox2.Text = "TRANSACT - SQL";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(381, 139);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(65, 19);
            checkBox3.TabIndex = 12;
            checkBox3.Text = "PL/SQL";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(516, 139);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 19);
            checkBox4.TabIndex = 16;
            checkBox4.Text = "Oracle";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(516, 177);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(64, 19);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "mySQL";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(516, 202);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(47, 19);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "php";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(516, 114);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(89, 19);
            checkBox7.TabIndex = 13;
            checkBox7.Text = "SQL SERVER";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // raddiasemana
            // 
            raddiasemana.AutoSize = true;
            raddiasemana.Location = new Point(379, 309);
            raddiasemana.Name = "raddiasemana";
            raddiasemana.Size = new Size(101, 19);
            raddiasemana.TabIndex = 17;
            raddiasemana.TabStop = true;
            raddiasemana.Text = "dia de semana";
            raddiasemana.UseVisualStyleBackColor = true;
            // 
            // radsabadodomingo
            // 
            radsabadodomingo.AutoSize = true;
            radsabadodomingo.Location = new Point(499, 309);
            radsabadodomingo.Name = "radsabadodomingo";
            radsabadodomingo.Size = new Size(124, 19);
            radsabadodomingo.TabIndex = 18;
            radsabadodomingo.TabStop = true;
            radsabadodomingo.Text = "sabado y domingo";
            radsabadodomingo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radsabadodomingo);
            Controls.Add(raddiasemana);
            Controls.Add(checkBox4);
            Controls.Add(checkBox5);
            Controls.Add(checkBox6);
            Controls.Add(checkBox7);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(chcpaquete);
            Controls.Add(textBox1);
            Controls.Add(btbborrar);
            Controls.Add(btbcalcular);
            Controls.Add(lblfrecuencia);
            Controls.Add(lbltotal);
            Controls.Add(lblenabled);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblenabled;
        private Label lbltotal;
        private Label lblfrecuencia;
        private Button btbcalcular;
        private Button btbborrar;
        private TextBox textBox1;
        private CheckBox chcpaquete;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private RadioButton raddiasemana;
        private RadioButton radsabadodomingo;
    }
}
