﻿
namespace Repaso_2do_Bloque_JS
{
    partial class NumAleatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNummax = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese un numero superior para generar un numero aleatorio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 a";
            // 
            // txtNummax
            // 
            this.txtNummax.Location = new System.Drawing.Point(92, 68);
            this.txtNummax.Name = "txtNummax";
            this.txtNummax.Size = new System.Drawing.Size(152, 29);
            this.txtNummax.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "generar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNummax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NumAleatorio";
            this.Text = "ingrese un numero superior para genrar un numero aleatorio ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNummax;
        private System.Windows.Forms.Button button1;
    }
}