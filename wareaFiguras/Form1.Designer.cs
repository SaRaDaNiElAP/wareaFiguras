
namespace wareaFiguras
{
    partial class frmareaFiguras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.figurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.círculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triánguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.figurasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // figurasToolStripMenuItem
            // 
            this.figurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.rectánguloToolStripMenuItem,
            this.círculoToolStripMenuItem,
            this.triánguloToolStripMenuItem});
            this.figurasToolStripMenuItem.Name = "figurasToolStripMenuItem";
            this.figurasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.figurasToolStripMenuItem.Text = "Figuras";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // rectánguloToolStripMenuItem
            // 
            this.rectánguloToolStripMenuItem.Name = "rectánguloToolStripMenuItem";
            this.rectánguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectánguloToolStripMenuItem.Text = "Rectángulo";
            this.rectánguloToolStripMenuItem.Click += new System.EventHandler(this.rectánguloToolStripMenuItem_Click);
            // 
            // círculoToolStripMenuItem
            // 
            this.círculoToolStripMenuItem.Name = "círculoToolStripMenuItem";
            this.círculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.círculoToolStripMenuItem.Text = "Círculo";
            this.círculoToolStripMenuItem.Click += new System.EventHandler(this.círculoToolStripMenuItem_Click);
            // 
            // triánguloToolStripMenuItem
            // 
            this.triánguloToolStripMenuItem.Name = "triánguloToolStripMenuItem";
            this.triánguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.triánguloToolStripMenuItem.Text = "Triángulo";
            this.triánguloToolStripMenuItem.Click += new System.EventHandler(this.triánguloToolStripMenuItem_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(269, 76);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(274, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "En el menú elige la figura a la que deseas hallarle el área";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmareaFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmareaFiguras";
            this.Text = "Área Figuras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectánguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem círculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triánguloToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
    }
}

