﻿namespace Combo_Box
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
            cmbNombre = new ComboBox();
            label1 = new Label();
            cmbNombres1 = new ComboBox();
            SuspendLayout();
            // 
            // cmbNombre
            // 
            cmbNombre.FormattingEnabled = true;
            cmbNombre.Location = new Point(114, 50);
            cmbNombre.Name = "cmbNombre";
            cmbNombre.Size = new Size(121, 23);
            cmbNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 90);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // cmbNombres1
            // 
            cmbNombres1.FormattingEnabled = true;
            cmbNombres1.Items.AddRange(new object[] { "dillan", "fabru", "franco" });
            cmbNombres1.Location = new Point(114, 111);
            cmbNombres1.Name = "cmbNombres1";
            cmbNombres1.Size = new Size(121, 23);
            cmbNombres1.TabIndex = 2;
            cmbNombres1.SelectedIndexChanged += cmbNombres1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbNombres1);
            Controls.Add(label1);
            Controls.Add(cmbNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNombre;
        private Label label1;
        private ComboBox cmbNombres1;
    }
}
