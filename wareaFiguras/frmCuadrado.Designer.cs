
namespace wareaFiguras
{
    partial class frmCuadrado
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
            this.btncuadrado = new System.Windows.Forms.Button();
            this.txtlado = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncuadrado
            // 
            this.btncuadrado.Location = new System.Drawing.Point(331, 162);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(114, 39);
            this.btncuadrado.TabIndex = 0;
            this.btncuadrado.Text = "Calcular el Área y Dibujar Cuadrado";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.btncuadrado_Click);
            // 
            // txtlado
            // 
            this.txtlado.Location = new System.Drawing.Point(345, 83);
            this.txtlado.Name = "txtlado";
            this.txtlado.Size = new System.Drawing.Size(100, 20);
            this.txtlado.TabIndex = 1;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(345, 251);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 2;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(285, 86);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(31, 13);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(287, 258);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(29, 13);
            this.lblarea.TabIndex = 4;
            this.lblarea.Text = "Área";
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtlado);
            this.Controls.Add(this.btncuadrado);
            this.Name = "frmCuadrado";
            this.Text = "Área cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncuadrado;
        private System.Windows.Forms.TextBox txtlado;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblarea;
    }
}