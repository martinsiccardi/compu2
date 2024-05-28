namespace actividad2
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
            label1 = new Label();
            txtKilogramos = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            txtGramos = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            btnConvertir = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Kilogramos";
            // 
            // txtKilogramos
            // 
            txtKilogramos.Location = new Point(6, 47);
            txtKilogramos.Name = "txtKilogramos";
            txtKilogramos.Size = new Size(100, 23);
            txtKilogramos.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 20);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Libras";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 158);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Miligramos";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 158);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Onzas";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 113);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 86);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 10;
            label5.Text = "Decagramos";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(6, 113);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 9;
            // 
            // txtGramos
            // 
            txtGramos.AutoSize = true;
            txtGramos.Location = new Point(3, 86);
            txtGramos.Name = "txtGramos";
            txtGramos.Size = new Size(48, 15);
            txtGramos.TabIndex = 8;
            txtGramos.Text = "Gramos";
            txtGramos.Click += ttGramos_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(138, 248);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(135, 221);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 14;
            label7.Text = "Tonelada metrica";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(6, 248);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 221);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 12;
            label8.Text = "Toneladas";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtKilogramos);
            groupBox1.Controls.Add(textBox8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(txtGramos);
            groupBox1.Location = new Point(53, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 277);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Convercion";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btnConvertir);
            groupBox2.Location = new Point(370, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(135, 145);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 100);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(12, 21);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtKilogramos;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label txtGramos;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button btnConvertir;
    }
}
