namespace trabajoextra
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
            groupBox1 = new GroupBox();
            textBoxNumero = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            listBoxNumeros = new ListBox();
            gbxCalculo = new GroupBox();
            buttonQuitar = new Button();
            button3 = new Button();
            btnBorrar = new Button();
            textBoxProducto = new TextBox();
            textBoxSuma = new TextBox();
            checkBoxMostrarProducto = new CheckBox();
            checkBoxMostrarSuma = new CheckBox();
            groupBox1.SuspendLayout();
            gbxCalculo.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxNumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(132, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar numeros";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(233, 31);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 2;
            textBoxNumero.TextChanged += txtNumber_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 1;
            label1.Text = "ingrse un numero a la lista";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(354, 31);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Añadir";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAdd_Click;
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.ItemHeight = 15;
            listBoxNumeros.Location = new Point(132, 158);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.Size = new Size(146, 154);
            listBoxNumeros.TabIndex = 1;
            // 
            // gbxCalculo
            // 
            gbxCalculo.Controls.Add(buttonQuitar);
            gbxCalculo.Controls.Add(button3);
            gbxCalculo.Controls.Add(btnBorrar);
            gbxCalculo.Controls.Add(textBoxProducto);
            gbxCalculo.Controls.Add(textBoxSuma);
            gbxCalculo.Controls.Add(checkBoxMostrarProducto);
            gbxCalculo.Controls.Add(checkBoxMostrarSuma);
            gbxCalculo.Location = new Point(310, 158);
            gbxCalculo.Name = "gbxCalculo";
            gbxCalculo.Size = new Size(302, 154);
            gbxCalculo.TabIndex = 2;
            gbxCalculo.TabStop = false;
            gbxCalculo.Text = "Calcular";
            // 
            // buttonQuitar
            // 
            buttonQuitar.Location = new Point(16, 115);
            buttonQuitar.Name = "buttonQuitar";
            buttonQuitar.Size = new Size(75, 23);
            buttonQuitar.TabIndex = 3;
            buttonQuitar.Text = "Quitar";
            buttonQuitar.UseVisualStyleBackColor = true;
            buttonQuitar.Click += buttonQuitar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(112, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(206, 115);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // textBoxProducto
            // 
            textBoxProducto.Location = new Point(164, 76);
            textBoxProducto.Name = "textBoxProducto";
            textBoxProducto.Size = new Size(100, 23);
            textBoxProducto.TabIndex = 3;
            // 
            // textBoxSuma
            // 
            textBoxSuma.Location = new Point(164, 39);
            textBoxSuma.Name = "textBoxSuma";
            textBoxSuma.Size = new Size(100, 23);
            textBoxSuma.TabIndex = 2;
            // 
            // checkBoxMostrarProducto
            // 
            checkBoxMostrarProducto.AutoSize = true;
            checkBoxMostrarProducto.Location = new Point(25, 78);
            checkBoxMostrarProducto.Name = "checkBoxMostrarProducto";
            checkBoxMostrarProducto.Size = new Size(119, 19);
            checkBoxMostrarProducto.TabIndex = 1;
            checkBoxMostrarProducto.Text = "Mostrar producto";
            checkBoxMostrarProducto.UseVisualStyleBackColor = true;
            // 
            // checkBoxMostrarSuma
            // 
            checkBoxMostrarSuma.AutoSize = true;
            checkBoxMostrarSuma.Location = new Point(25, 41);
            checkBoxMostrarSuma.Name = "checkBoxMostrarSuma";
            checkBoxMostrarSuma.Size = new Size(99, 19);
            checkBoxMostrarSuma.TabIndex = 0;
            checkBoxMostrarSuma.Text = "Mostrar suma";
            checkBoxMostrarSuma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxCalculo);
            Controls.Add(listBoxNumeros);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbxCalculo.ResumeLayout(false);
            gbxCalculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxNumero;
        private Label label1;
        private Button btnAgregar;
        private ListBox listBoxNumeros;
        private GroupBox gbxCalculo;
        private CheckBox checkBoxMostrarSuma;
        private CheckBox checkBoxMostrarProducto;
        private TextBox textBoxProducto;
        private TextBox textBoxSuma;
        private Button button3;
        private Button btnBorrar;
        private Button buttonQuitar;
    }
}
