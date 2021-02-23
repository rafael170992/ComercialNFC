namespace ComercialNFC
{
    partial class FormAltaCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.CodigoCliente = new System.Windows.Forms.TextBox();
            this.NombreDelCliente = new System.Windows.Forms.TextBox();
            this.NombreLargoDelCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(685, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.CodigoCliente.Location = new System.Drawing.Point(6, 63);
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.Size = new System.Drawing.Size(123, 20);
            this.CodigoCliente.TabIndex = 1;
            this.CodigoCliente.Text = "Código del cliente";
            this.CodigoCliente.Enter += new System.EventHandler(this.CodigoCliente_Enter);
            this.CodigoCliente.Leave += new System.EventHandler(this.CodigoCliente_Leave);
            // 
            // NombreDelCliente
            // 
            this.NombreDelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NombreDelCliente.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NombreDelCliente.Location = new System.Drawing.Point(6, 89);
            this.NombreDelCliente.Name = "NombreDelCliente";
            this.NombreDelCliente.Size = new System.Drawing.Size(123, 20);
            this.NombreDelCliente.TabIndex = 4;
            this.NombreDelCliente.Text = "Nombre del cliente";
            this.NombreDelCliente.Enter += new System.EventHandler(this.NombreDelCliente_Enter);
            this.NombreDelCliente.Leave += new System.EventHandler(this.NombreDelCliente_Leave);
            // 
            // NombreLargoDelCliente
            // 
            this.NombreLargoDelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreLargoDelCliente.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NombreLargoDelCliente.Location = new System.Drawing.Point(6, 115);
            this.NombreLargoDelCliente.Name = "NombreLargoDelCliente";
            this.NombreLargoDelCliente.Size = new System.Drawing.Size(123, 20);
            this.NombreLargoDelCliente.TabIndex = 6;
            this.NombreLargoDelCliente.Text = "Nombre largo del cliente";
            this.NombreLargoDelCliente.Enter += new System.EventHandler(this.NombreLargoDelCliente_Enter);
            this.NombreLargoDelCliente.Leave += new System.EventHandler(this.NombreLargoDelCliente_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NombreLargoDelCliente);
            this.groupBox1.Controls.Add(this.CodigoCliente);
            this.groupBox1.Controls.Add(this.NombreDelCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo cliente";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(164, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 20);
            this.panel1.TabIndex = 8;
            // 
            // FormAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAltaCliente";
            this.Text = "FormAltaCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CodigoCliente;
        private System.Windows.Forms.TextBox NombreDelCliente;
        private System.Windows.Forms.TextBox NombreLargoDelCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}