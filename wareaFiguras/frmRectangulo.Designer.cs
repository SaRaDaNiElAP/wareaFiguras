
namespace wareaFiguras
{
    partial class frmRectangulo
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
            this.txtbase = new System.Windows.Forms.TextBox();
            this.btnrectangulo = new System.Windows.Forms.Button();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(342, 84);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 0;
            // 
            // btnrectangulo
            // 
            this.btnrectangulo.Location = new System.Drawing.Point(328, 200);
            this.btnrectangulo.Name = "btnrectangulo";
            this.btnrectangulo.Size = new System.Drawing.Size(114, 50);
            this.btnrectangulo.TabIndex = 1;
            this.btnrectangulo.Text = "Dibujar Rectángulo y Calcular Área";
            this.btnrectangulo.UseVisualStyleBackColor = true;
            this.btnrectangulo.Click += new System.EventHandler(this.btnrectangulo_Click);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(342, 134);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 2;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(342, 291);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 3;
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(295, 91);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(31, 13);
            this.lblbase.TabIndex = 4;
            this.lblbase.Text = "Base";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(292, 137);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 5;
            this.lblaltura.Text = "Altura";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(292, 294);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(29, 13);
            this.lblarea.TabIndex = 6;
            this.lblarea.Text = "Área";
            // 
            // frmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.btnrectangulo);
            this.Controls.Add(this.txtbase);
            this.Name = "frmRectangulo";
            this.Text = "Área Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Button btnrectangulo;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblarea;
    }
}