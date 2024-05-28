namespace LISTBOX
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
            ltsFrutas = new ListBox();
            txtFruta = new TextBox();
            btnadicionar = new Button();
            btbEliminar = new Button();
            lblseleccion = new Label();
            SuspendLayout();
            // 
            // ltsFrutas
            // 
            ltsFrutas.FormattingEnabled = true;
            ltsFrutas.ItemHeight = 15;
            ltsFrutas.Items.AddRange(new object[] { "BANANA", "MANZANA" });
            ltsFrutas.Location = new Point(237, 133);
            ltsFrutas.Name = "ltsFrutas";
            ltsFrutas.Size = new Size(120, 94);
            ltsFrutas.TabIndex = 0;
            ltsFrutas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtFruta
            // 
            txtFruta.Location = new Point(237, 81);
            txtFruta.Name = "txtFruta";
            txtFruta.Size = new Size(120, 23);
            txtFruta.TabIndex = 1;
            // 
            // btnadicionar
            // 
            btnadicionar.Location = new Point(414, 80);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(75, 23);
            btnadicionar.TabIndex = 2;
            btnadicionar.Text = "adicionar";
            btnadicionar.UseVisualStyleBackColor = true;
            btnadicionar.Click += button1_Click;
            // 
            // btbEliminar
            // 
            btbEliminar.Location = new Point(414, 162);
            btbEliminar.Name = "btbEliminar";
            btbEliminar.Size = new Size(75, 23);
            btbEliminar.TabIndex = 3;
            btbEliminar.Text = "eliminar";
            btbEliminar.UseVisualStyleBackColor = true;
            btbEliminar.Click += btbEliminar_Click;
            // 
            // lblseleccion
            // 
            lblseleccion.AutoSize = true;
            lblseleccion.Location = new Point(236, 116);
            lblseleccion.Name = "lblseleccion";
            lblseleccion.Size = new Size(47, 15);
            lblseleccion.TabIndex = 4;
            lblseleccion.Text = "seccion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblseleccion);
            Controls.Add(btbEliminar);
            Controls.Add(btnadicionar);
            Controls.Add(txtFruta);
            Controls.Add(ltsFrutas);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ltsFrutas;
        private TextBox txtFruta;
        private Button btnadicionar;
        private Button btbEliminar;
        private Label lblseleccion;
    }
}
