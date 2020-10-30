namespace ComercialNFC
{
    partial class FormComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComercial));
            this.GridEmpresas = new System.Windows.Forms.DataGridView();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseDeDatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // GridEmpresas
            // 
            this.GridEmpresas.AllowUserToAddRows = false;
            this.GridEmpresas.AllowUserToDeleteRows = false;
            this.GridEmpresas.AllowUserToResizeRows = false;
            this.GridEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridEmpresas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.GridEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmpresas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empresa,
            this.BaseDeDatos});
            this.GridEmpresas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEmpresas.Location = new System.Drawing.Point(0, 0);
            this.GridEmpresas.MultiSelect = false;
            this.GridEmpresas.Name = "GridEmpresas";
            this.GridEmpresas.ReadOnly = true;
            this.GridEmpresas.RowHeadersVisible = false;
            this.GridEmpresas.Size = new System.Drawing.Size(451, 263);
            this.GridEmpresas.TabIndex = 0;
            this.GridEmpresas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEmpresas_CellContentDoubleClick);
            // 
            // Empresa
            // 
            this.Empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            // 
            // BaseDeDatos
            // 
            this.BaseDeDatos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BaseDeDatos.HeaderText = "Base de Datos";
            this.BaseDeDatos.Name = "BaseDeDatos";
            this.BaseDeDatos.ReadOnly = true;
            // 
            // FormComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 263);
            this.Controls.Add(this.GridEmpresas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Empresas";
            this.Load += new System.EventHandler(this.FormComercial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseDeDatos;
    }
}