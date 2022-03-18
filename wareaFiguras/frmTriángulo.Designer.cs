
namespace wareaFiguras
{
    partial class frmTriángulo
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
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.btntriangulo = new System.Windows.Forms.Button();
            this.lblárea = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(332, 69);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(100, 20);
            this.txtbase.TabIndex = 0;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(332, 113);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 1;
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Location = new System.Drawing.Point(281, 69);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(31, 13);
            this.lblbase.TabIndex = 2;
            this.lblbase.Text = "Base";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(284, 119);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(34, 13);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "Altura";
            // 
            // btntriangulo
            // 
            this.btntriangulo.Location = new System.Drawing.Point(322, 180);
            this.btntriangulo.Name = "btntriangulo";
            this.btntriangulo.Size = new System.Drawing.Size(110, 43);
            this.btntriangulo.TabIndex = 4;
            this.btntriangulo.Text = "Dibujar Triángulo y Calcular Área";
            this.btntriangulo.UseVisualStyleBackColor = true;
            this.btntriangulo.Click += new System.EventHandler(this.btntriangulo_Click);
            // 
            // lblárea
            // 
            this.lblárea.AutoSize = true;
            this.lblárea.Location = new System.Drawing.Point(284, 259);
            this.lblárea.Name = "lblárea";
            this.lblárea.Size = new System.Drawing.Size(29, 13);
            this.lblárea.TabIndex = 5;
            this.lblárea.Text = "Área";

            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(332, 252);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 20);
            this.txtarea.TabIndex = 6;
            // 
            // frmTriángulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblárea);
            this.Controls.Add(this.btntriangulo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtbase);
            this.Name = "frmTriángulo";
            this.Text = "frmTriángulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Button btntriangulo;
        private System.Windows.Forms.Label lblárea;
        private System.Windows.Forms.TextBox txtarea;
    }
}