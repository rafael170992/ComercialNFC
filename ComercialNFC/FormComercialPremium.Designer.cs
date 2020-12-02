namespace ComercialNFC
{
    partial class FormComercialPremium
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComercialPremium));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteProToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteProveedorBajoNivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaTImbradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaNotaDeCreditoREpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelDeControl = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogóToolStripMenuItem,
            this.pruebaTImbradoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogóToolStripMenuItem
            // 
            this.catalogóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteProToolStripMenuItem,
            this.altaClienteProveedorBajoNivelToolStripMenuItem});
            this.catalogóToolStripMenuItem.Name = "catalogóToolStripMenuItem";
            this.catalogóToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.catalogóToolStripMenuItem.Text = "Catálogo";
            // 
            // altaClienteProToolStripMenuItem
            // 
            this.altaClienteProToolStripMenuItem.DoubleClickEnabled = true;
            this.altaClienteProToolStripMenuItem.Name = "altaClienteProToolStripMenuItem";
            this.altaClienteProToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.altaClienteProToolStripMenuItem.Text = "Alta cliente/Proveedor";
            this.altaClienteProToolStripMenuItem.Click += new System.EventHandler(this.altaClienteProToolStripMenuItem_Click);
            // 
            // altaClienteProveedorBajoNivelToolStripMenuItem
            // 
            this.altaClienteProveedorBajoNivelToolStripMenuItem.Name = "altaClienteProveedorBajoNivelToolStripMenuItem";
            this.altaClienteProveedorBajoNivelToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.altaClienteProveedorBajoNivelToolStripMenuItem.Text = "Alta cliente/Proveedor bajo nivel";
            // 
            // pruebaTImbradoToolStripMenuItem
            // 
            this.pruebaTImbradoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaNotaDeCreditoREpToolStripMenuItem});
            this.pruebaTImbradoToolStripMenuItem.Name = "pruebaTImbradoToolStripMenuItem";
            this.pruebaTImbradoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.pruebaTImbradoToolStripMenuItem.Text = "Prueba TImbrado";
            // 
            // pruebaNotaDeCreditoREpToolStripMenuItem
            // 
            this.pruebaNotaDeCreditoREpToolStripMenuItem.Name = "pruebaNotaDeCreditoREpToolStripMenuItem";
            this.pruebaNotaDeCreditoREpToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pruebaNotaDeCreditoREpToolStripMenuItem.Text = "Prueba nota de credito/REp";
            this.pruebaNotaDeCreditoREpToolStripMenuItem.Click += new System.EventHandler(this.pruebaNotaDeCreditoREpToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelDeControl
            // 
            this.panelDeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeControl.Location = new System.Drawing.Point(0, 24);
            this.panelDeControl.Name = "panelDeControl";
            this.panelDeControl.Size = new System.Drawing.Size(800, 426);
            this.panelDeControl.TabIndex = 1;
            // 
            // FormComercialPremium
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDeControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormComercialPremium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comercial Premium";
            this.Load += new System.EventHandler(this.FormComercialPremium_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogóToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altaClienteProToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteProveedorBajoNivelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaTImbradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaNotaDeCreditoREpToolStripMenuItem;
        private System.Windows.Forms.Panel panelDeControl;
    }
}