﻿namespace AplicaciónDeWinForms
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
            if(disposing && (components != null))
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
            Probando = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // Probando
            // 
            Probando.AutoSize = true;
            Probando.Cursor = Cursors.Hand;
            Probando.Location = new Point(350, 204);
            Probando.Name = "Probando";
            Probando.Size = new Size(121, 15);
            Probando.TabIndex = 0;
            Probando.Text = "Probando algo nuevo";
            Probando.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(315, 253);
            button1.Name = "button1";
            button1.Size = new Size(183, 61);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 333);
            button2.Name = "button2";
            button2.Size = new Size(183, 61);
            button2.TabIndex = 2;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Probando);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Probando;
        private Button button1;
        private Button button2;
    }
}
