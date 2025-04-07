namespace MiPOSCSharpMySQL.Formularios
{
    partial class FormVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.txtbuscarcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.txtcantidaddeventa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btndeshabilitar = new System.Windows.Forms.Button();
            this.btnhabilitar = new System.Windows.Forms.Button();
            this.txtprecioventafinal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtstockproducto = new System.Windows.Forms.TextBox();
            this.txtprecioproducto = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtapmaternocliente = new System.Windows.Forms.TextBox();
            this.txtappaternocliente = new System.Windows.Forms.TextBox();
            this.txtnombrescliente = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.eliminarseleccionproducto = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvresumenventa = new System.Windows.Forms.DataGridView();
            this.lblultimafactura = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbltotalpagar = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresumenventa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dgvclientes);
            this.groupBox1.Controls.Add(this.txtbuscarcliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes Disponibles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Click para Seleccionar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(19, 98);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.RowHeadersWidth = 51;
            this.dgvclientes.RowTemplate.Height = 24;
            this.dgvclientes.Size = new System.Drawing.Size(586, 135);
            this.dgvclientes.TabIndex = 2;
            // 
            // txtbuscarcliente
            // 
            this.txtbuscarcliente.Location = new System.Drawing.Point(83, 37);
            this.txtbuscarcliente.Name = "txtbuscarcliente";
            this.txtbuscarcliente.Size = new System.Drawing.Size(522, 22);
            this.txtbuscarcliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvproductos);
            this.groupBox2.Controls.Add(this.txtbuscarproducto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(678, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 248);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos Disponibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click para Seleccionar";
            // 
            // dgvproductos
            // 
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(19, 98);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(612, 135);
            this.dgvproductos.TabIndex = 2;
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Location = new System.Drawing.Point(83, 37);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(548, 22);
            this.txtbuscarproducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1358, 236);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen de Selección";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnagregarproducto);
            this.groupBox6.Controls.Add(this.txtcantidaddeventa);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.btndeshabilitar);
            this.groupBox6.Controls.Add(this.btnhabilitar);
            this.groupBox6.Controls.Add(this.txtprecioventafinal);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(652, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(683, 183);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Precio y Cantidad";
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Location = new System.Drawing.Point(14, 103);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(647, 60);
            this.btnagregarproducto.TabIndex = 6;
            this.btnagregarproducto.Text = "Agregar Producto";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            // 
            // txtcantidaddeventa
            // 
            this.txtcantidaddeventa.Location = new System.Drawing.Point(570, 50);
            this.txtcantidaddeventa.Name = "txtcantidaddeventa";
            this.txtcantidaddeventa.Size = new System.Drawing.Size(91, 22);
            this.txtcantidaddeventa.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cantidad de Venta:";
            // 
            // btndeshabilitar
            // 
            this.btndeshabilitar.Location = new System.Drawing.Point(340, 48);
            this.btndeshabilitar.Name = "btndeshabilitar";
            this.btndeshabilitar.Size = new System.Drawing.Size(87, 23);
            this.btndeshabilitar.TabIndex = 3;
            this.btndeshabilitar.Text = "Deshabilitar";
            this.btndeshabilitar.UseVisualStyleBackColor = true;
            this.btndeshabilitar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhabilitar
            // 
            this.btnhabilitar.Location = new System.Drawing.Point(259, 49);
            this.btnhabilitar.Name = "btnhabilitar";
            this.btnhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnhabilitar.TabIndex = 2;
            this.btnhabilitar.Text = "Habilitar";
            this.btnhabilitar.UseVisualStyleBackColor = true;
            // 
            // txtprecioventafinal
            // 
            this.txtprecioventafinal.Location = new System.Drawing.Point(123, 49);
            this.txtprecioventafinal.Name = "txtprecioventafinal";
            this.txtprecioventafinal.Size = new System.Drawing.Size(109, 22);
            this.txtprecioventafinal.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Precio de Venta:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtstockproducto);
            this.groupBox5.Controls.Add(this.txtprecioproducto);
            this.groupBox5.Controls.Add(this.txtnombreproducto);
            this.groupBox5.Controls.Add(this.txtidproducto);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(335, 32);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox5.Size = new System.Drawing.Size(286, 183);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Producto";
            // 
            // txtstockproducto
            // 
            this.txtstockproducto.Location = new System.Drawing.Point(97, 141);
            this.txtstockproducto.Name = "txtstockproducto";
            this.txtstockproducto.Size = new System.Drawing.Size(173, 22);
            this.txtstockproducto.TabIndex = 7;
            // 
            // txtprecioproducto
            // 
            this.txtprecioproducto.Location = new System.Drawing.Point(97, 106);
            this.txtprecioproducto.Name = "txtprecioproducto";
            this.txtprecioproducto.Size = new System.Drawing.Size(173, 22);
            this.txtprecioproducto.TabIndex = 6;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(97, 67);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(173, 22);
            this.txtnombreproducto.TabIndex = 5;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(97, 31);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(173, 22);
            this.txtidproducto.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Precio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nombre:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id. Producto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtapmaternocliente);
            this.groupBox4.Controls.Add(this.txtappaternocliente);
            this.groupBox4.Controls.Add(this.txtnombrescliente);
            this.groupBox4.Controls.Add(this.txtidcliente);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(19, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(286, 183);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Cliente";
            // 
            // txtapmaternocliente
            // 
            this.txtapmaternocliente.Location = new System.Drawing.Point(97, 141);
            this.txtapmaternocliente.Name = "txtapmaternocliente";
            this.txtapmaternocliente.Size = new System.Drawing.Size(173, 22);
            this.txtapmaternocliente.TabIndex = 7;
            // 
            // txtappaternocliente
            // 
            this.txtappaternocliente.Location = new System.Drawing.Point(97, 106);
            this.txtappaternocliente.Name = "txtappaternocliente";
            this.txtappaternocliente.Size = new System.Drawing.Size(173, 22);
            this.txtappaternocliente.TabIndex = 6;
            // 
            // txtnombrescliente
            // 
            this.txtnombrescliente.Location = new System.Drawing.Point(97, 67);
            this.txtnombrescliente.Name = "txtnombrescliente";
            this.txtnombrescliente.Size = new System.Drawing.Size(173, 22);
            this.txtnombrescliente.TabIndex = 5;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(97, 31);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(173, 22);
            this.txtidcliente.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ap. Materno:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ap. Paterno:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id. Cliente:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.eliminarseleccionproducto);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.dgvresumenventa);
            this.groupBox7.Controls.Add(this.lblultimafactura);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(12, 568);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1358, 245);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resumen de la Venta";
            // 
            // eliminarseleccionproducto
            // 
            this.eliminarseleccionproducto.Location = new System.Drawing.Point(1177, 35);
            this.eliminarseleccionproducto.Name = "eliminarseleccionproducto";
            this.eliminarseleccionproducto.Size = new System.Drawing.Size(158, 31);
            this.eliminarseleccionproducto.TabIndex = 4;
            this.eliminarseleccionproducto.Text = "Eliminar";
            this.eliminarseleccionproducto.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1174, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(161, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Seleccionar para Eliminar";
            // 
            // dgvresumenventa
            // 
            this.dgvresumenventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvresumenventa.Location = new System.Drawing.Point(6, 90);
            this.dgvresumenventa.Name = "dgvresumenventa";
            this.dgvresumenventa.RowHeadersWidth = 51;
            this.dgvresumenventa.RowTemplate.Height = 24;
            this.dgvresumenventa.Size = new System.Drawing.Size(1335, 149);
            this.dgvresumenventa.TabIndex = 2;
            // 
            // lblultimafactura
            // 
            this.lblultimafactura.AutoSize = true;
            this.lblultimafactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblultimafactura.Location = new System.Drawing.Point(241, 46);
            this.lblultimafactura.Name = "lblultimafactura";
            this.lblultimafactura.Size = new System.Drawing.Size(51, 20);
            this.lblultimafactura.TabIndex = 1;
            this.lblultimafactura.Text = "------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Última Factura Creada:";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(1302, 826);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(51, 20);
            this.lbliva.TabIndex = 6;
            this.lbliva.Text = "------";
            this.lbliva.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1175, 826);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "IVA (18%):";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // lbltotalpagar
            // 
            this.lbltotalpagar.AutoSize = true;
            this.lbltotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpagar.Location = new System.Drawing.Point(1302, 864);
            this.lbltotalpagar.Name = "lbltotalpagar";
            this.lbltotalpagar.Size = new System.Drawing.Size(51, 20);
            this.lbltotalpagar.TabIndex = 8;
            this.lbltotalpagar.Text = "------";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(1175, 864);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 20);
            this.label21.TabIndex = 7;
            this.label21.Text = "Total a Pagar:";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 903);
            this.Controls.Add(this.lbltotalpagar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresumenventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtbuscarcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtstockproducto;
        private System.Windows.Forms.TextBox txtprecioproducto;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtapmaternocliente;
        private System.Windows.Forms.TextBox txtappaternocliente;
        private System.Windows.Forms.TextBox txtnombrescliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btndeshabilitar;
        private System.Windows.Forms.Button btnhabilitar;
        private System.Windows.Forms.TextBox txtprecioventafinal;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.TextBox txtcantidaddeventa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button eliminarseleccionproducto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvresumenventa;
        private System.Windows.Forms.Label lblultimafactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbltotalpagar;
        private System.Windows.Forms.Label label21;
    }
}