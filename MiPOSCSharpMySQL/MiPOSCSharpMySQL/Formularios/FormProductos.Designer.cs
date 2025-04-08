namespace MiPOSCSharpMySQL.Formularios
{
    partial class FormProductos
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.txtstockproducto = new System.Windows.Forms.TextBox();
            this.txtprecioproducto = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccionar registro para modificar o eliminar";
            // 
            // dgvproductos
            // 
            this.dgvproductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(428, 42);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.ReadOnly = true;
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 24;
            this.dgvproductos.Size = new System.Drawing.Size(470, 338);
            this.dgvproductos.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.txtstockproducto);
            this.groupBox1.Controls.Add(this.txtprecioproducto);
            this.groupBox1.Controls.Add(this.txtnombreproducto);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Producto";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(198, 275);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(143, 39);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(198, 221);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(143, 35);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(24, 275);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(148, 39);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(24, 221);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(148, 35);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // txtstockproducto
            // 
            this.txtstockproducto.Location = new System.Drawing.Point(122, 147);
            this.txtstockproducto.Name = "txtstockproducto";
            this.txtstockproducto.Size = new System.Drawing.Size(212, 22);
            this.txtstockproducto.TabIndex = 7;
            // 
            // txtprecioproducto
            // 
            this.txtprecioproducto.Location = new System.Drawing.Point(122, 108);
            this.txtprecioproducto.Name = "txtprecioproducto";
            this.txtprecioproducto.Size = new System.Drawing.Size(212, 22);
            this.txtprecioproducto.TabIndex = 6;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(122, 64);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(212, 22);
            this.txtnombreproducto.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(122, 27);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(212, 22);
            this.txtid.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "N. Producto: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ld:";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 405);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FormProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.TextBox txtstockproducto;
        private System.Windows.Forms.TextBox txtprecioproducto;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}