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
            this.tIOSDESOPORTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTADEUSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOPORTETELEFONICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOPORTEPRESENCIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSToolStripMenuItem,
            this.tIOSDESOPORTEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(787, 25);
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
            // tIOSDESOPORTEToolStripMenuItem
            // 
            this.tIOSDESOPORTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sOPORTETELEFONICOToolStripMenuItem,
            this.sOPORTEPRESENCIALToolStripMenuItem});
            this.tIOSDESOPORTEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tIOSDESOPORTEToolStripMenuItem.Name = "tIOSDESOPORTEToolStripMenuItem";
            this.tIOSDESOPORTEToolStripMenuItem.Size = new System.Drawing.Size(133, 21);
            this.tIOSDESOPORTEToolStripMenuItem.Text = "TIOS  DE SOPORTE";
            // 
            // lISTADEUSUARIOSToolStripMenuItem
            // 
            this.lISTADEUSUARIOSToolStripMenuItem.Name = "lISTADEUSUARIOSToolStripMenuItem";
            this.lISTADEUSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lISTADEUSUARIOSToolStripMenuItem.Text = "LISTA DE USUARIOS";
            this.lISTADEUSUARIOSToolStripMenuItem.Click += new System.EventHandler(this.lISTADEUSUARIOSToolStripMenuItem_Click);
            // 
            // sOPORTETELEFONICOToolStripMenuItem
            // 
            this.sOPORTETELEFONICOToolStripMenuItem.Name = "sOPORTETELEFONICOToolStripMenuItem";
            this.sOPORTETELEFONICOToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sOPORTETELEFONICOToolStripMenuItem.Text = "SOPORTE TELEFONICO";
            // 
            // sOPORTEPRESENCIALToolStripMenuItem
            // 
            this.sOPORTEPRESENCIALToolStripMenuItem.Name = "sOPORTEPRESENCIALToolStripMenuItem";
            this.sOPORTEPRESENCIALToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sOPORTEPRESENCIALToolStripMenuItem.Text = "SOPORTE PRESENCIAL";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 440);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem tIOSDESOPORTEToolStripMenuItem;
        private ToolStripMenuItem sOPORTETELEFONICOToolStripMenuItem;
        private ToolStripMenuItem sOPORTEPRESENCIALToolStripMenuItem;
    }
}