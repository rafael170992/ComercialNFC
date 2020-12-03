namespace ComercialNFC
{
    partial class PruebaNotaCreditoRep
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
            this.GenerarDocumento = new System.Windows.Forms.Button();
            this.CodigoConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimbrarDocumento = new System.Windows.Forms.Button();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Unidades = new System.Windows.Forms.TextBox();
            this.CodigoProducto = new System.Windows.Forms.TextBox();
            this.CodigoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigoClienteProveedorNotaDeCredito = new System.Windows.Forms.GroupBox();
            this.GenerarDocumentoNotaDeCredito = new System.Windows.Forms.Button();
            this.TimbrarNotaDeCredito = new System.Windows.Forms.Button();
            this.ImportePagarNotaDeCredito = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FolioPagarNotaDeCredito = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ConceptoPagarNotaDeCredito = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ImporteNotaDeCredito = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClienteProveedorNotaCredito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ConceptoNotaCredito = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TimbrarReciboElectronicoDePago = new System.Windows.Forms.Button();
            this.GenerardocumentoElectronicoDePago = new System.Windows.Forms.Button();
            this.ImportaPagarDocumentoReciboElectronicoDePago = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.FolioDocumentoPagarReciboElectronicoDePago = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ImporteReciboElectronicoPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoClienteProveedorReciboElectronicoDePago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ConceptoReciboElectronicoPago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.CodigoClienteProveedorNotaDeCredito.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerarDocumento
            // 
            this.GenerarDocumento.Location = new System.Drawing.Point(416, 19);
            this.GenerarDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.GenerarDocumento.Name = "GenerarDocumento";
            this.GenerarDocumento.Size = new System.Drawing.Size(113, 27);
            this.GenerarDocumento.TabIndex = 0;
            this.GenerarDocumento.Text = "Generar Documento";
            this.GenerarDocumento.UseVisualStyleBackColor = true;
            this.GenerarDocumento.Click += new System.EventHandler(this.GenerarDocumento_Click);
            // 
            // CodigoConcepto
            // 
            this.CodigoConcepto.Location = new System.Drawing.Point(71, 19);
            this.CodigoConcepto.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoConcepto.Name = "CodigoConcepto";
            this.CodigoConcepto.Size = new System.Drawing.Size(95, 20);
            this.CodigoConcepto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Concepto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimbrarDocumento);
            this.groupBox1.Controls.Add(this.Precio);
            this.groupBox1.Controls.Add(this.Unidades);
            this.groupBox1.Controls.Add(this.CodigoProducto);
            this.groupBox1.Controls.Add(this.GenerarDocumento);
            this.groupBox1.Controls.Add(this.CodigoCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CodigoConcepto);
            this.groupBox1.Location = new System.Drawing.Point(107, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(571, 109);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documento Factura";
            // 
            // TimbrarDocumento
            // 
            this.TimbrarDocumento.Location = new System.Drawing.Point(416, 58);
            this.TimbrarDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.TimbrarDocumento.Name = "TimbrarDocumento";
            this.TimbrarDocumento.Size = new System.Drawing.Size(113, 27);
            this.TimbrarDocumento.TabIndex = 11;
            this.TimbrarDocumento.Text = "Timbrar Documento";
            this.TimbrarDocumento.UseVisualStyleBackColor = true;
            this.TimbrarDocumento.Click += new System.EventHandler(this.TimbrarDocumento_Click);
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(313, 47);
            this.Precio.Margin = new System.Windows.Forms.Padding(2);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(55, 20);
            this.Precio.TabIndex = 10;
            // 
            // Unidades
            // 
            this.Unidades.Location = new System.Drawing.Point(221, 45);
            this.Unidades.Margin = new System.Windows.Forms.Padding(2);
            this.Unidades.Name = "Unidades";
            this.Unidades.Size = new System.Drawing.Size(38, 20);
            this.Unidades.TabIndex = 9;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.Location = new System.Drawing.Point(71, 45);
            this.CodigoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.Size = new System.Drawing.Size(95, 20);
            this.CodigoProducto.TabIndex = 8;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.Location = new System.Drawing.Point(273, 19);
            this.CodigoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoCliente.Name = "CodigoCliente";
            this.CodigoCliente.Size = new System.Drawing.Size(95, 20);
            this.CodigoCliente.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Piezas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente/Proveedor:";
            // 
            // CodigoClienteProveedorNotaDeCredito
            // 
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.GenerarDocumentoNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.TimbrarNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.ImportePagarNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label12);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.FolioPagarNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label11);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.ConceptoPagarNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label10);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.ImporteNotaDeCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label9);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.ClienteProveedorNotaCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label8);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.ConceptoNotaCredito);
            this.CodigoClienteProveedorNotaDeCredito.Controls.Add(this.label2);
            this.CodigoClienteProveedorNotaDeCredito.Location = new System.Drawing.Point(54, 148);
            this.CodigoClienteProveedorNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoClienteProveedorNotaDeCredito.Name = "CodigoClienteProveedorNotaDeCredito";
            this.CodigoClienteProveedorNotaDeCredito.Padding = new System.Windows.Forms.Padding(2);
            this.CodigoClienteProveedorNotaDeCredito.Size = new System.Drawing.Size(688, 109);
            this.CodigoClienteProveedorNotaDeCredito.TabIndex = 4;
            this.CodigoClienteProveedorNotaDeCredito.TabStop = false;
            this.CodigoClienteProveedorNotaDeCredito.Text = "Documento Nota de Credito";
            // 
            // GenerarDocumentoNotaDeCredito
            // 
            this.GenerarDocumentoNotaDeCredito.Location = new System.Drawing.Point(552, 25);
            this.GenerarDocumentoNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.GenerarDocumentoNotaDeCredito.Name = "GenerarDocumentoNotaDeCredito";
            this.GenerarDocumentoNotaDeCredito.Size = new System.Drawing.Size(121, 27);
            this.GenerarDocumentoNotaDeCredito.TabIndex = 23;
            this.GenerarDocumentoNotaDeCredito.Text = "Generar Documento";
            this.GenerarDocumentoNotaDeCredito.UseVisualStyleBackColor = true;
            this.GenerarDocumentoNotaDeCredito.Click += new System.EventHandler(this.GenerarDocumentoNotaDeCredito_Click);
            // 
            // TimbrarNotaDeCredito
            // 
            this.TimbrarNotaDeCredito.Location = new System.Drawing.Point(552, 63);
            this.TimbrarNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.TimbrarNotaDeCredito.Name = "TimbrarNotaDeCredito";
            this.TimbrarNotaDeCredito.Size = new System.Drawing.Size(121, 27);
            this.TimbrarNotaDeCredito.TabIndex = 12;
            this.TimbrarNotaDeCredito.Text = "Timbrar Documento";
            this.TimbrarNotaDeCredito.UseVisualStyleBackColor = true;
            this.TimbrarNotaDeCredito.Click += new System.EventHandler(this.TimbrarNotaDeCredito_Click);
            // 
            // ImportePagarNotaDeCredito
            // 
            this.ImportePagarNotaDeCredito.Location = new System.Drawing.Point(475, 47);
            this.ImportePagarNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.ImportePagarNotaDeCredito.Name = "ImportePagarNotaDeCredito";
            this.ImportePagarNotaDeCredito.Size = new System.Drawing.Size(63, 20);
            this.ImportePagarNotaDeCredito.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(387, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Importe a pagar:";
            // 
            // FolioPagarNotaDeCredito
            // 
            this.FolioPagarNotaDeCredito.Location = new System.Drawing.Point(313, 47);
            this.FolioPagarNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.FolioPagarNotaDeCredito.Name = "FolioPagarNotaDeCredito";
            this.FolioPagarNotaDeCredito.Size = new System.Drawing.Size(63, 20);
            this.FolioPagarNotaDeCredito.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Folio:";
            // 
            // ConceptoPagarNotaDeCredito
            // 
            this.ConceptoPagarNotaDeCredito.Location = new System.Drawing.Point(160, 47);
            this.ConceptoPagarNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.ConceptoPagarNotaDeCredito.Name = "ConceptoPagarNotaDeCredito";
            this.ConceptoPagarNotaDeCredito.Size = new System.Drawing.Size(99, 20);
            this.ConceptoPagarNotaDeCredito.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Concepto Documento a pagar:";
            // 
            // ImporteNotaDeCredito
            // 
            this.ImporteNotaDeCredito.Location = new System.Drawing.Point(341, 13);
            this.ImporteNotaDeCredito.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteNotaDeCredito.Name = "ImporteNotaDeCredito";
            this.ImporteNotaDeCredito.Size = new System.Drawing.Size(55, 20);
            this.ImporteNotaDeCredito.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Importe:";
            // 
            // ClienteProveedorNotaCredito
            // 
            this.ClienteProveedorNotaCredito.Location = new System.Drawing.Point(213, 15);
            this.ClienteProveedorNotaCredito.Margin = new System.Windows.Forms.Padding(2);
            this.ClienteProveedorNotaCredito.Name = "ClienteProveedorNotaCredito";
            this.ClienteProveedorNotaCredito.Size = new System.Drawing.Size(76, 20);
            this.ClienteProveedorNotaCredito.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cliente/Proveedor:";
            // 
            // ConceptoNotaCredito
            // 
            this.ConceptoNotaCredito.Location = new System.Drawing.Point(59, 15);
            this.ConceptoNotaCredito.Margin = new System.Windows.Forms.Padding(2);
            this.ConceptoNotaCredito.Name = "ConceptoNotaCredito";
            this.ConceptoNotaCredito.Size = new System.Drawing.Size(55, 20);
            this.ConceptoNotaCredito.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Concepto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TimbrarReciboElectronicoDePago);
            this.groupBox3.Controls.Add(this.GenerardocumentoElectronicoDePago);
            this.groupBox3.Controls.Add(this.ImportaPagarDocumentoReciboElectronicoDePago);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.FolioDocumentoPagarReciboElectronicoDePago);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.ConceptoDeDocumentoPagarReciboElectronicoDePago);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.ImporteReciboElectronicoPago);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CodigoClienteProveedorReciboElectronicoDePago);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.ConceptoReciboElectronicoPago);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(54, 290);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(693, 116);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documento Recibo Electronico de Pago";
            // 
            // TimbrarReciboElectronicoDePago
            // 
            this.TimbrarReciboElectronicoDePago.Location = new System.Drawing.Point(558, 61);
            this.TimbrarReciboElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.TimbrarReciboElectronicoDePago.Name = "TimbrarReciboElectronicoDePago";
            this.TimbrarReciboElectronicoDePago.Size = new System.Drawing.Size(121, 27);
            this.TimbrarReciboElectronicoDePago.TabIndex = 24;
            this.TimbrarReciboElectronicoDePago.Text = "Timbrar Documento";
            this.TimbrarReciboElectronicoDePago.UseVisualStyleBackColor = true;
            this.TimbrarReciboElectronicoDePago.Click += new System.EventHandler(this.TimbrarReciboElectronicoDePago_Click);
            // 
            // GenerardocumentoElectronicoDePago
            // 
            this.GenerardocumentoElectronicoDePago.Location = new System.Drawing.Point(558, 25);
            this.GenerardocumentoElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.GenerardocumentoElectronicoDePago.Name = "GenerardocumentoElectronicoDePago";
            this.GenerardocumentoElectronicoDePago.Size = new System.Drawing.Size(121, 27);
            this.GenerardocumentoElectronicoDePago.TabIndex = 29;
            this.GenerardocumentoElectronicoDePago.Text = "Generar Documento";
            this.GenerardocumentoElectronicoDePago.UseVisualStyleBackColor = true;
            this.GenerardocumentoElectronicoDePago.Click += new System.EventHandler(this.GenerardocumentoElectronicoDePago_Click);
            // 
            // ImportaPagarDocumentoReciboElectronicoDePago
            // 
            this.ImportaPagarDocumentoReciboElectronicoDePago.Location = new System.Drawing.Point(478, 49);
            this.ImportaPagarDocumentoReciboElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.ImportaPagarDocumentoReciboElectronicoDePago.Name = "ImportaPagarDocumentoReciboElectronicoDePago";
            this.ImportaPagarDocumentoReciboElectronicoDePago.Size = new System.Drawing.Size(63, 20);
            this.ImportaPagarDocumentoReciboElectronicoDePago.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(390, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Importe a pagar:";
            // 
            // FolioDocumentoPagarReciboElectronicoDePago
            // 
            this.FolioDocumentoPagarReciboElectronicoDePago.Location = new System.Drawing.Point(315, 49);
            this.FolioDocumentoPagarReciboElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.FolioDocumentoPagarReciboElectronicoDePago.Name = "FolioDocumentoPagarReciboElectronicoDePago";
            this.FolioDocumentoPagarReciboElectronicoDePago.Size = new System.Drawing.Size(63, 20);
            this.FolioDocumentoPagarReciboElectronicoDePago.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(273, 51);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Folio:";
            // 
            // ConceptoDeDocumentoPagarReciboElectronicoDePago
            // 
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago.Location = new System.Drawing.Point(163, 49);
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago.Name = "ConceptoDeDocumentoPagarReciboElectronicoDePago";
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago.Size = new System.Drawing.Size(99, 20);
            this.ConceptoDeDocumentoPagarReciboElectronicoDePago.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 49);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Concepto Documento a pagar:";
            // 
            // ImporteReciboElectronicoPago
            // 
            this.ImporteReciboElectronicoPago.Location = new System.Drawing.Point(341, 23);
            this.ImporteReciboElectronicoPago.Margin = new System.Windows.Forms.Padding(2);
            this.ImporteReciboElectronicoPago.Name = "ImporteReciboElectronicoPago";
            this.ImporteReciboElectronicoPago.Size = new System.Drawing.Size(55, 20);
            this.ImporteReciboElectronicoPago.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Importe:";
            // 
            // CodigoClienteProveedorReciboElectronicoDePago
            // 
            this.CodigoClienteProveedorReciboElectronicoDePago.Location = new System.Drawing.Point(213, 25);
            this.CodigoClienteProveedorReciboElectronicoDePago.Margin = new System.Windows.Forms.Padding(2);
            this.CodigoClienteProveedorReciboElectronicoDePago.Name = "CodigoClienteProveedorReciboElectronicoDePago";
            this.CodigoClienteProveedorReciboElectronicoDePago.Size = new System.Drawing.Size(76, 20);
            this.CodigoClienteProveedorReciboElectronicoDePago.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(117, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cliente/Proveedor:";
            // 
            // ConceptoReciboElectronicoPago
            // 
            this.ConceptoReciboElectronicoPago.Location = new System.Drawing.Point(59, 25);
            this.ConceptoReciboElectronicoPago.Margin = new System.Windows.Forms.Padding(2);
            this.ConceptoReciboElectronicoPago.Name = "ConceptoReciboElectronicoPago";
            this.ConceptoReciboElectronicoPago.Size = new System.Drawing.Size(55, 20);
            this.ConceptoReciboElectronicoPago.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 27);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Concepto:";
            // 
            // PruebaNotaCreditoRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 427);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CodigoClienteProveedorNotaDeCredito);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PruebaNotaCreditoRep";
            this.Text = "PruebaNotaCreditoRep";
            this.Load += new System.EventHandler(this.PruebaNotaCreditoRep_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CodigoClienteProveedorNotaDeCredito.ResumeLayout(false);
            this.CodigoClienteProveedorNotaDeCredito.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerarDocumento;
        private System.Windows.Forms.TextBox CodigoConcepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox CodigoClienteProveedorNotaDeCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Unidades;
        private System.Windows.Forms.TextBox CodigoProducto;
        private System.Windows.Forms.TextBox CodigoCliente;
        private System.Windows.Forms.Button TimbrarDocumento;
        private System.Windows.Forms.TextBox ClienteProveedorNotaCredito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ConceptoNotaCredito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ImporteNotaDeCredito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ConceptoPagarNotaDeCredito;
        private System.Windows.Forms.Button GenerarDocumentoNotaDeCredito;
        private System.Windows.Forms.Button TimbrarNotaDeCredito;
        private System.Windows.Forms.TextBox ImportePagarNotaDeCredito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FolioPagarNotaDeCredito;
        private System.Windows.Forms.Button TimbrarReciboElectronicoDePago;
        private System.Windows.Forms.Button GenerardocumentoElectronicoDePago;
        private System.Windows.Forms.TextBox ImportaPagarDocumentoReciboElectronicoDePago;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox FolioDocumentoPagarReciboElectronicoDePago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ConceptoDeDocumentoPagarReciboElectronicoDePago;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ImporteReciboElectronicoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoClienteProveedorReciboElectronicoDePago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ConceptoReciboElectronicoPago;
        private System.Windows.Forms.Label label14;
    }
}