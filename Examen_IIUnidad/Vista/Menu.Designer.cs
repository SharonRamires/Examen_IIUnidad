namespace Vista
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADEUSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tIPOSDESOPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADESOPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tICKECTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.tIPOSDESOPORTEToolStripMenuItem,
            this.tICKECTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADEUSUARIOSToolStripMenuItem});
            this.uSUARIOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // lISTADEUSUARIOSToolStripMenuItem
            // 
            this.lISTADEUSUARIOSToolStripMenuItem.Name = "lISTADEUSUARIOSToolStripMenuItem";
            this.lISTADEUSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lISTADEUSUARIOSToolStripMenuItem.Text = "LISTA DE USUARIOS";
            this.lISTADEUSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.lISTADEUSUARIOSToolStripMenuItem_Click);
            // 
            // tIPOSDESOPORTEToolStripMenuItem
            // 
            this.tIPOSDESOPORTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTADESOPORTESToolStripMenuItem});
            this.tIPOSDESOPORTEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tIPOSDESOPORTEToolStripMenuItem.Name = "tIPOSDESOPORTEToolStripMenuItem";
            this.tIPOSDESOPORTEToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.tIPOSDESOPORTEToolStripMenuItem.Text = "TIPOS DE SOPORTE";
            // 
            // lISTADESOPORTESToolStripMenuItem
            // 
            this.lISTADESOPORTESToolStripMenuItem.Name = "lISTADESOPORTESToolStripMenuItem";
            this.lISTADESOPORTESToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.lISTADESOPORTESToolStripMenuItem.Text = "LISTA DE SOPORTES";
            this.lISTADESOPORTESToolStripMenuItem.Click += new System.EventHandler(this.lISTADESOPORTESToolStripMenuItem_Click);
            // 
            // tICKECTToolStripMenuItem
            // 
            this.tICKECTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tICKECTToolStripMenuItem.Name = "tICKECTToolStripMenuItem";
            this.tICKECTToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.tICKECTToolStripMenuItem.Text = "TICKECT";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem lISTADEUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem tIPOSDESOPORTEToolStripMenuItem;
        private ToolStripMenuItem lISTADESOPORTESToolStripMenuItem;
        private ToolStripMenuItem tICKECTToolStripMenuItem;
    }
}