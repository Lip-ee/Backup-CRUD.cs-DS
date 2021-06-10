namespace Proj_Biblioteca
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIVROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cONSULTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESSOASFILTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIVROS2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.cONSULTAToolStripMenuItem,
            this.rELATÓRIOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lIVROSToolStripMenuItem,
            this.toolStripMenuItem1,
            this.lIVROS2ToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // lIVROSToolStripMenuItem
            // 
            this.lIVROSToolStripMenuItem.Name = "lIVROSToolStripMenuItem";
            this.lIVROSToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.lIVROSToolStripMenuItem.Text = "LIVROS";
            this.lIVROSToolStripMenuItem.Click += new System.EventHandler(this.lIVROSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // cONSULTAToolStripMenuItem
            // 
            this.cONSULTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESSOASFILTROToolStripMenuItem});
            this.cONSULTAToolStripMenuItem.Name = "cONSULTAToolStripMenuItem";
            this.cONSULTAToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.cONSULTAToolStripMenuItem.Text = "CONSULTA";
            // 
            // pESSOASFILTROToolStripMenuItem
            // 
            this.pESSOASFILTROToolStripMenuItem.Name = "pESSOASFILTROToolStripMenuItem";
            this.pESSOASFILTROToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.pESSOASFILTROToolStripMenuItem.Text = "LIVROS (FILTRO)";
            this.pESSOASFILTROToolStripMenuItem.Click += new System.EventHandler(this.pESSOASFILTROToolStripMenuItem_Click);
            // 
            // rELATÓRIOToolStripMenuItem
            // 
            this.rELATÓRIOToolStripMenuItem.Name = "rELATÓRIOToolStripMenuItem";
            this.rELATÓRIOToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.rELATÓRIOToolStripMenuItem.Text = "RELATÓRIO";
            // 
            // lIVROS2ToolStripMenuItem
            // 
            this.lIVROS2ToolStripMenuItem.Name = "lIVROS2ToolStripMenuItem";
            this.lIVROS2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lIVROS2ToolStripMenuItem.Text = "LIVROS 2";
            this.lIVROS2ToolStripMenuItem.Click += new System.EventHandler(this.lIVROS2ToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 554);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIVROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESSOASFILTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIVROS2ToolStripMenuItem;
    }
}

