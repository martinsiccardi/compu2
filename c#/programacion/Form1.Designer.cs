namespace programacion
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnVentas = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 251, 70);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnVentas);
            panel1.Location = new Point(104, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 100);
            panel1.TabIndex = 3;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = SystemColors.HotTrack;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(593, 20);
            button4.Name = "button4";
            button4.Size = new Size(89, 61);
            button4.TabIndex = 4;
            button4.Text = "Vendedor";
            button4.UseCompatibleTextRendering = true;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = SystemColors.HotTrack;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(170, 20);
            button3.Name = "button3";
            button3.Size = new Size(139, 61);
            button3.TabIndex = 3;
            button3.Text = "Usuarios";
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = SystemColors.HotTrack;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(506, 20);
            button2.Name = "button2";
            button2.Size = new Size(71, 61);
            button2.TabIndex = 2;
            button2.Text = "Ventas ";
            button2.UseCompatibleTextRendering = true;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(340, 20);
            button1.Name = "button1";
            button1.Size = new Size(139, 61);
            button1.TabIndex = 1;
            button1.Text = "Productos";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.AutoSize = true;
            btnVentas.BackColor = Color.Black;
            btnVentas.BackgroundImageLayout = ImageLayout.Stretch;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ButtonFace;
            btnVentas.Location = new Point(6, 20);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(139, 61);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Menu";
            btnVentas.UseCompatibleTextRendering = true;
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 448);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(104, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 507);
            panel3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVentas;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Panel panel3;
    }
}
