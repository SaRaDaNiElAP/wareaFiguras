
namespace wareaFiguras
{
    partial class frmCírculo
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
            this.btncirculo = new System.Windows.Forms.Button();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.txtárea = new System.Windows.Forms.TextBox();
            this.lblradio = new System.Windows.Forms.Label();
            this.lblárea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncirculo
            // 
            this.btncirculo.Location = new System.Drawing.Point(346, 138);
            this.btncirculo.Name = "btncirculo";
            this.btncirculo.Size = new System.Drawing.Size(107, 45);
            this.btncirculo.TabIndex = 0;
            this.btncirculo.Text = "Calcular área y dibujar círculo";
            this.btncirculo.UseVisualStyleBackColor = true;
            this.btncirculo.Click += new System.EventHandler(this.btncirculo_Click);
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(353, 79);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(100, 20);
            this.txtradio.TabIndex = 1;
            // 
            // txtárea
            // 
            this.txtárea.Location = new System.Drawing.Point(353, 214);
            this.txtárea.Name = "txtárea";
            this.txtárea.Size = new System.Drawing.Size(100, 20);
            this.txtárea.TabIndex = 2;
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Location = new System.Drawing.Point(295, 79);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(35, 13);
            this.lblradio.TabIndex = 3;
            this.lblradio.Text = "Radio";
            // 
            // lblárea
            // 
            this.lblárea.AutoSize = true;
            this.lblárea.Location = new System.Drawing.Point(298, 220);
            this.lblárea.Name = "lblárea";
            this.lblárea.Size = new System.Drawing.Size(29, 13);
            this.lblárea.TabIndex = 4;
            this.lblárea.Text = "Área";
            // 
            // frmCírculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblárea);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.txtárea);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.btncirculo);
            this.Name = "frmCírculo";
            this.Text = "frmCírculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncirculo;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.TextBox txtárea;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.Label lblárea;
    }
}