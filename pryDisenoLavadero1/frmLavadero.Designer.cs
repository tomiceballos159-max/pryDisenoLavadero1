namespace pryDisenoLavadero1
{
    partial class frmLavadero
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
            lblLavaderos = new Label();
            lblCLientes = new Label();
            lblServicio = new Label();
            lblCantidad = new Label();
            lblPatente = new Label();
            txtCliente = new TextBox();
            txtPatente = new TextBox();
            txtCantidad = new TextBox();
            lblEntrega = new Label();
            comboBox1 = new ComboBox();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            btnCalcular = new Button();
            lblTituloSubTotal = new Label();
            lblSubtotal = new Label();
            lblRecargo = new Label();
            lblTituloRecargo = new Label();
            lblDescuento = new Label();
            lblTituloDescuento = new Label();
            lblTotal = new Label();
            lblTituloTotal = new Label();
            gpbLavadosDelDia = new GroupBox();
            lstLavadosDelDia = new ListBox();
            grbRecaudacion = new GroupBox();
            lblEncerado = new Label();
            lblRecEncerado = new Label();
            lblCompleto = new Label();
            lblRecCompleto = new Label();
            lblExterior = new Label();
            lblRecExterior = new Label();
            grbBuscarPatente = new GroupBox();
            btnConsultar = new Button();
            txtBuscarPatente = new TextBox();
            lblBuscarPatente = new Label();
            cmbServicio = new ComboBox();
            gpbLavadosDelDia.SuspendLayout();
            grbRecaudacion.SuspendLayout();
            grbBuscarPatente.SuspendLayout();
            SuspendLayout();
            // 
            // lblLavaderos
            // 
            lblLavaderos.AutoSize = true;
            lblLavaderos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLavaderos.Location = new Point(211, 44);
            lblLavaderos.Name = "lblLavaderos";
            lblLavaderos.Size = new Size(126, 37);
            lblLavaderos.TabIndex = 0;
            lblLavaderos.Text = "Lavadero";
            // 
            // lblCLientes
            // 
            lblCLientes.AutoSize = true;
            lblCLientes.Location = new Point(48, 125);
            lblCLientes.Name = "lblCLientes";
            lblCLientes.Size = new Size(52, 15);
            lblCLientes.TabIndex = 1;
            lblCLientes.Text = "CLientes";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(47, 183);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(48, 15);
            lblServicio.TabIndex = 2;
            lblServicio.Text = "Servicio";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(12, 221);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(119, 15);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "CantidadDeVehiculos";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(48, 153);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 4;
            lblPatente.Text = "Patente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(158, 117);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 5;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(158, 146);
            txtPatente.MaxLength = 7;
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(100, 23);
            txtPatente.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(158, 213);
            txtCantidad.MaxLength = 5;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            // 
            // lblEntrega
            // 
            lblEntrega.AutoSize = true;
            lblEntrega.Location = new Point(48, 259);
            lblEntrega.Name = "lblEntrega";
            lblEntrega.Size = new Size(47, 15);
            lblEntrega.TabIndex = 9;
            lblEntrega.Text = "Entrega";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Express", "Normal" });
            comboBox1.Location = new Point(158, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(113, 23);
            comboBox1.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(288, 639);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 22);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(363, 639);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 22);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Resgitrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(438, 639);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 22);
            btnCalcular.TabIndex = 13;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblTituloSubTotal
            // 
            lblTituloSubTotal.AutoSize = true;
            lblTituloSubTotal.Location = new Point(29, 329);
            lblTituloSubTotal.Name = "lblTituloSubTotal";
            lblTituloSubTotal.Size = new Size(51, 15);
            lblTituloSubTotal.TabIndex = 14;
            lblTituloSubTotal.Text = "Subtotal";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BorderStyle = BorderStyle.Fixed3D;
            lblSubtotal.Location = new Point(97, 329);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(36, 17);
            lblSubtotal.TabIndex = 15;
            lblSubtotal.Text = "$0.00";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.BorderStyle = BorderStyle.Fixed3D;
            lblRecargo.Location = new Point(97, 373);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(36, 17);
            lblRecargo.TabIndex = 17;
            lblRecargo.Text = "$0.00";
            // 
            // lblTituloRecargo
            // 
            lblTituloRecargo.AutoSize = true;
            lblTituloRecargo.Location = new Point(29, 373);
            lblTituloRecargo.Name = "lblTituloRecargo";
            lblTituloRecargo.Size = new Size(50, 15);
            lblTituloRecargo.TabIndex = 16;
            lblTituloRecargo.Text = "Recargo";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BorderStyle = BorderStyle.Fixed3D;
            lblDescuento.Location = new Point(97, 420);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(36, 17);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "$0.00";
            // 
            // lblTituloDescuento
            // 
            lblTituloDescuento.AutoSize = true;
            lblTituloDescuento.Location = new Point(29, 420);
            lblTituloDescuento.Name = "lblTituloDescuento";
            lblTituloDescuento.Size = new Size(63, 15);
            lblTituloDescuento.TabIndex = 18;
            lblTituloDescuento.Text = "Descuento";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.Fixed3D;
            lblTotal.Location = new Point(97, 455);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 17);
            lblTotal.TabIndex = 21;
            lblTotal.Text = "$0.00";
            // 
            // lblTituloTotal
            // 
            lblTituloTotal.AutoSize = true;
            lblTituloTotal.Location = new Point(29, 455);
            lblTituloTotal.Name = "lblTituloTotal";
            lblTituloTotal.Size = new Size(33, 15);
            lblTituloTotal.TabIndex = 20;
            lblTituloTotal.Text = "Total";
            // 
            // gpbLavadosDelDia
            // 
            gpbLavadosDelDia.Controls.Add(lstLavadosDelDia);
            gpbLavadosDelDia.Location = new Point(328, 117);
            gpbLavadosDelDia.Name = "gpbLavadosDelDia";
            gpbLavadosDelDia.Size = new Size(185, 168);
            gpbLavadosDelDia.TabIndex = 22;
            gpbLavadosDelDia.TabStop = false;
            gpbLavadosDelDia.Text = "Lavados Del Dia";
            // 
            // lstLavadosDelDia
            // 
            lstLavadosDelDia.FormattingEnabled = true;
            lstLavadosDelDia.Location = new Point(19, 22);
            lstLavadosDelDia.Name = "lstLavadosDelDia";
            lstLavadosDelDia.Size = new Size(148, 109);
            lstLavadosDelDia.TabIndex = 0;
            // 
            // grbRecaudacion
            // 
            grbRecaudacion.Controls.Add(lblEncerado);
            grbRecaudacion.Controls.Add(lblRecEncerado);
            grbRecaudacion.Controls.Add(lblCompleto);
            grbRecaudacion.Controls.Add(lblRecCompleto);
            grbRecaudacion.Controls.Add(lblExterior);
            grbRecaudacion.Controls.Add(lblRecExterior);
            grbRecaudacion.Location = new Point(180, 329);
            grbRecaudacion.Name = "grbRecaudacion";
            grbRecaudacion.Size = new Size(200, 143);
            grbRecaudacion.TabIndex = 23;
            grbRecaudacion.TabStop = false;
            grbRecaudacion.Text = "Recaudacion";
            // 
            // lblEncerado
            // 
            lblEncerado.AutoSize = true;
            lblEncerado.BorderStyle = BorderStyle.Fixed3D;
            lblEncerado.Location = new Point(108, 91);
            lblEncerado.Name = "lblEncerado";
            lblEncerado.Size = new Size(36, 17);
            lblEncerado.TabIndex = 6;
            lblEncerado.Text = "$0.00";
            // 
            // lblRecEncerado
            // 
            lblRecEncerado.AutoSize = true;
            lblRecEncerado.Location = new Point(20, 91);
            lblRecEncerado.Name = "lblRecEncerado";
            lblRecEncerado.Size = new Size(56, 15);
            lblRecEncerado.TabIndex = 5;
            lblRecEncerado.Text = "Encerado";
            // 
            // lblCompleto
            // 
            lblCompleto.AutoSize = true;
            lblCompleto.BorderStyle = BorderStyle.Fixed3D;
            lblCompleto.Location = new Point(108, 64);
            lblCompleto.Name = "lblCompleto";
            lblCompleto.Size = new Size(36, 17);
            lblCompleto.TabIndex = 4;
            lblCompleto.Text = "$0.00";
            // 
            // lblRecCompleto
            // 
            lblRecCompleto.AutoSize = true;
            lblRecCompleto.Location = new Point(20, 64);
            lblRecCompleto.Name = "lblRecCompleto";
            lblRecCompleto.Size = new Size(60, 15);
            lblRecCompleto.TabIndex = 3;
            lblRecCompleto.Text = "Completo";
            // 
            // lblExterior
            // 
            lblExterior.AutoSize = true;
            lblExterior.BorderStyle = BorderStyle.Fixed3D;
            lblExterior.Location = new Point(108, 34);
            lblExterior.Name = "lblExterior";
            lblExterior.Size = new Size(36, 17);
            lblExterior.TabIndex = 2;
            lblExterior.Text = "$0.00";
            // 
            // lblRecExterior
            // 
            lblRecExterior.AutoSize = true;
            lblRecExterior.Location = new Point(20, 34);
            lblRecExterior.Name = "lblRecExterior";
            lblRecExterior.Size = new Size(46, 15);
            lblRecExterior.TabIndex = 0;
            lblRecExterior.Text = "Exterior";
            // 
            // grbBuscarPatente
            // 
            grbBuscarPatente.Controls.Add(btnConsultar);
            grbBuscarPatente.Controls.Add(txtBuscarPatente);
            grbBuscarPatente.Controls.Add(lblBuscarPatente);
            grbBuscarPatente.Location = new Point(399, 329);
            grbBuscarPatente.Name = "grbBuscarPatente";
            grbBuscarPatente.Size = new Size(227, 143);
            grbBuscarPatente.TabIndex = 24;
            grbBuscarPatente.TabStop = false;
            grbBuscarPatente.Text = "BuscarPatente";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(135, 85);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPatente
            // 
            txtBuscarPatente.Location = new Point(110, 44);
            txtBuscarPatente.Name = "txtBuscarPatente";
            txtBuscarPatente.Size = new Size(100, 23);
            txtBuscarPatente.TabIndex = 1;
            // 
            // lblBuscarPatente
            // 
            lblBuscarPatente.AutoSize = true;
            lblBuscarPatente.Location = new Point(19, 47);
            lblBuscarPatente.Name = "lblBuscarPatente";
            lblBuscarPatente.Size = new Size(85, 15);
            lblBuscarPatente.TabIndex = 0;
            lblBuscarPatente.Text = "Buscar Patente";
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Lavado Exterior", "Lavado Completo", "Lavado Con Encerado" });
            cmbServicio.Location = new Point(150, 183);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(121, 23);
            cmbServicio.TabIndex = 3;
            // 
            // frmLavadero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 684);
            Controls.Add(cmbServicio);
            Controls.Add(grbBuscarPatente);
            Controls.Add(grbRecaudacion);
            Controls.Add(gpbLavadosDelDia);
            Controls.Add(lblTotal);
            Controls.Add(lblTituloTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblTituloDescuento);
            Controls.Add(lblRecargo);
            Controls.Add(lblTituloRecargo);
            Controls.Add(lblSubtotal);
            Controls.Add(lblTituloSubTotal);
            Controls.Add(btnCalcular);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLimpiar);
            Controls.Add(comboBox1);
            Controls.Add(lblEntrega);
            Controls.Add(txtCantidad);
            Controls.Add(txtPatente);
            Controls.Add(txtCliente);
            Controls.Add(lblPatente);
            Controls.Add(lblCantidad);
            Controls.Add(lblServicio);
            Controls.Add(lblCLientes);
            Controls.Add(lblLavaderos);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmLavadero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLavadero";
            gpbLavadosDelDia.ResumeLayout(false);
            grbRecaudacion.ResumeLayout(false);
            grbRecaudacion.PerformLayout();
            grbBuscarPatente.ResumeLayout(false);
            grbBuscarPatente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLavaderos;
        private Label lblCLientes;
        private Label lblServicio;
        private Label lblCantidad;
        private Label lblPatente;
        private TextBox txtCliente;
        private TextBox txtPatente;
        private TextBox txtCantidad;
        private Label lblEntrega;
        private ComboBox comboBox1;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnCalcular;
        private Label lblTituloSubTotal;
        private Label lblSubtotal;
        private Label lblRecargo;
        private Label lblTituloRecargo;
        private Label lblDescuento;
        private Label lblTituloDescuento;
        private Label lblTotal;
        private Label lblTituloTotal;
        private GroupBox gpbLavadosDelDia;
        private ListBox lstLavadosDelDia;
        private GroupBox grbRecaudacion;
        private Label lblEncerado;
        private Label lblRecEncerado;
        private Label lblCompleto;
        private Label lblRecCompleto;
        private Label lblExterior;
        private Label lblRecExterior;
        private GroupBox grbBuscarPatente;
        private Button btnConsultar;
        private TextBox txtBuscarPatente;
        private Label lblBuscarPatente;
        private ComboBox cmbServicio;
    }
}