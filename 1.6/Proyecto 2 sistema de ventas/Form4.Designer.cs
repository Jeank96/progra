namespace Proyecto_2_sistema_de_ventas
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaVentasDataSet = new Proyecto_2_sistema_de_ventas.SistemaVentasDataSet();
            this.cLIENTESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.condicion_de_pago = new System.Windows.Forms.Label();
            this.fecha_de_inicio_relacion = new System.Windows.Forms.Label();
            this.correo_electronico = new System.Windows.Forms.Label();
            this.direccion_fisica_entrega = new System.Windows.Forms.Label();
            this.limite_de_credito = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.codigo_postal = new System.Windows.Forms.Label();
            this.direccion_fisica = new System.Windows.Forms.Label();
            this.pais = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.codigo_cliente = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.cLIENTESTableAdapter = new Proyecto_2_sistema_de_ventas.SistemaVentasDataSetTableAdapters.CLIENTESTableAdapter();
            this.cLIENTESBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionfisicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitedecreditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionfisicaentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoelectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadeiniciorelacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condiciondepagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.codigoclienteDataGridViewTextBoxColumn,
            this.paisDataGridViewTextBoxColumn,
            this.direccionfisicaDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.limitedecreditoDataGridViewTextBoxColumn,
            this.direccionfisicaentregaDataGridViewTextBoxColumn,
            this.correoelectronicoDataGridViewTextBoxColumn,
            this.fechadeiniciorelacionDataGridViewTextBoxColumn,
            this.condiciondepagoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(11, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(246, 150);
            this.dataGridView1.TabIndex = 53;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.sistemaVentasDataSet;
            // 
            // sistemaVentasDataSet
            // 
            this.sistemaVentasDataSet.DataSetName = "SistemaVentasDataSet";
            this.sistemaVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource2
            // 
            this.cLIENTESBindingSource2.DataMember = "CLIENTES";
            this.cLIENTESBindingSource2.DataSource = this.sistemaVentasDataSet;
            // 
            // cLIENTESBindingSource1
            // 
            this.cLIENTESBindingSource1.DataMember = "CLIENTES";
            this.cLIENTESBindingSource1.DataSource = this.sistemaVentasDataSet;
            // 
            // condicion_de_pago
            // 
            this.condicion_de_pago.AutoSize = true;
            this.condicion_de_pago.Location = new System.Drawing.Point(440, 252);
            this.condicion_de_pago.Name = "condicion_de_pago";
            this.condicion_de_pago.Size = new System.Drawing.Size(88, 13);
            this.condicion_de_pago.TabIndex = 52;
            this.condicion_de_pago.Text = "Condicn de pago";
            // 
            // fecha_de_inicio_relacion
            // 
            this.fecha_de_inicio_relacion.AutoSize = true;
            this.fecha_de_inicio_relacion.Location = new System.Drawing.Point(440, 205);
            this.fecha_de_inicio_relacion.Name = "fecha_de_inicio_relacion";
            this.fecha_de_inicio_relacion.Size = new System.Drawing.Size(37, 13);
            this.fecha_de_inicio_relacion.TabIndex = 51;
            this.fecha_de_inicio_relacion.Text = "Fecha";
            // 
            // correo_electronico
            // 
            this.correo_electronico.AutoSize = true;
            this.correo_electronico.Location = new System.Drawing.Point(440, 158);
            this.correo_electronico.Name = "correo_electronico";
            this.correo_electronico.Size = new System.Drawing.Size(45, 13);
            this.correo_electronico.TabIndex = 50;
            this.correo_electronico.Text = "CCorreo";
            // 
            // direccion_fisica_entrega
            // 
            this.direccion_fisica_entrega.AutoSize = true;
            this.direccion_fisica_entrega.Location = new System.Drawing.Point(440, 110);
            this.direccion_fisica_entrega.Name = "direccion_fisica_entrega";
            this.direccion_fisica_entrega.Size = new System.Drawing.Size(100, 13);
            this.direccion_fisica_entrega.TabIndex = 49;
            this.direccion_fisica_entrega.Text = "Direccion de ntrega";
            // 
            // limite_de_credito
            // 
            this.limite_de_credito.AutoSize = true;
            this.limite_de_credito.Location = new System.Drawing.Point(440, 62);
            this.limite_de_credito.Name = "limite_de_credito";
            this.limite_de_credito.Size = new System.Drawing.Size(40, 13);
            this.limite_de_credito.TabIndex = 48;
            this.limite_de_credito.Text = "Credito";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Location = new System.Drawing.Point(440, 21);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(49, 13);
            this.telefono.TabIndex = 47;
            this.telefono.Text = "Telefono";
            // 
            // codigo_postal
            // 
            this.codigo_postal.AutoSize = true;
            this.codigo_postal.Location = new System.Drawing.Point(30, 199);
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(71, 13);
            this.codigo_postal.TabIndex = 46;
            this.codigo_postal.Text = "Codigo postal";
            // 
            // direccion_fisica
            // 
            this.direccion_fisica.AutoSize = true;
            this.direccion_fisica.Location = new System.Drawing.Point(30, 152);
            this.direccion_fisica.Name = "direccion_fisica";
            this.direccion_fisica.Size = new System.Drawing.Size(79, 13);
            this.direccion_fisica.TabIndex = 45;
            this.direccion_fisica.Text = "Direccion fisica";
            // 
            // pais
            // 
            this.pais.AutoSize = true;
            this.pais.Location = new System.Drawing.Point(30, 107);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(27, 13);
            this.pais.TabIndex = 44;
            this.pais.Text = "Pais";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(30, 68);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(44, 13);
            this.nombre.TabIndex = 43;
            this.nombre.Text = "Nombre";
            // 
            // codigo_cliente
            // 
            this.codigo_cliente.AutoSize = true;
            this.codigo_cliente.Location = new System.Drawing.Point(30, 18);
            this.codigo_cliente.Name = "codigo_cliente";
            this.codigo_cliente.Size = new System.Drawing.Size(74, 13);
            this.codigo_cliente.TabIndex = 42;
            this.codigo_cliente.Text = "Codigo cliente";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(568, 245);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(203, 20);
            this.textBox11.TabIndex = 41;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(568, 202);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(203, 20);
            this.textBox10.TabIndex = 40;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(568, 152);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(203, 20);
            this.textBox9.TabIndex = 39;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(568, 103);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(203, 20);
            this.textBox8.TabIndex = 38;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(568, 59);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(203, 20);
            this.textBox7.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(568, 15);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 20);
            this.textBox6.TabIndex = 36;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 192);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(131, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(196, 20);
            this.textBox4.TabIndex = 34;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 20);
            this.textBox3.TabIndex = 33;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 31;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(682, 292);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 30;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(568, 292);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 29;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(437, 292);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 28;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(299, 292);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 27;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTESBindingSource3
            // 
            this.cLIENTESBindingSource3.DataMember = "CLIENTES";
            this.cLIENTESBindingSource3.DataSource = this.sistemaVentasDataSet;
            // 
            // cLIENTESBindingSource4
            // 
            this.cLIENTESBindingSource4.DataMember = "CLIENTES";
            this.cLIENTESBindingSource4.DataSource = this.sistemaVentasDataSet;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // codigoclienteDataGridViewTextBoxColumn
            // 
            this.codigoclienteDataGridViewTextBoxColumn.DataPropertyName = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.HeaderText = "codigo_cliente";
            this.codigoclienteDataGridViewTextBoxColumn.Name = "codigoclienteDataGridViewTextBoxColumn";
            // 
            // paisDataGridViewTextBoxColumn
            // 
            this.paisDataGridViewTextBoxColumn.DataPropertyName = "pais";
            this.paisDataGridViewTextBoxColumn.HeaderText = "pais";
            this.paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            // 
            // direccionfisicaDataGridViewTextBoxColumn
            // 
            this.direccionfisicaDataGridViewTextBoxColumn.DataPropertyName = "direccion_fisica";
            this.direccionfisicaDataGridViewTextBoxColumn.HeaderText = "direccion_fisica";
            this.direccionfisicaDataGridViewTextBoxColumn.Name = "direccionfisicaDataGridViewTextBoxColumn";
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // limitedecreditoDataGridViewTextBoxColumn
            // 
            this.limitedecreditoDataGridViewTextBoxColumn.DataPropertyName = "limite_de_credito";
            this.limitedecreditoDataGridViewTextBoxColumn.HeaderText = "limite_de_credito";
            this.limitedecreditoDataGridViewTextBoxColumn.Name = "limitedecreditoDataGridViewTextBoxColumn";
            // 
            // direccionfisicaentregaDataGridViewTextBoxColumn
            // 
            this.direccionfisicaentregaDataGridViewTextBoxColumn.DataPropertyName = "direccion_fisica_entrega";
            this.direccionfisicaentregaDataGridViewTextBoxColumn.HeaderText = "direccion_fisica_entrega";
            this.direccionfisicaentregaDataGridViewTextBoxColumn.Name = "direccionfisicaentregaDataGridViewTextBoxColumn";
            // 
            // correoelectronicoDataGridViewTextBoxColumn
            // 
            this.correoelectronicoDataGridViewTextBoxColumn.DataPropertyName = "correo_electronico";
            this.correoelectronicoDataGridViewTextBoxColumn.HeaderText = "correo_electronico";
            this.correoelectronicoDataGridViewTextBoxColumn.Name = "correoelectronicoDataGridViewTextBoxColumn";
            // 
            // fechadeiniciorelacionDataGridViewTextBoxColumn
            // 
            this.fechadeiniciorelacionDataGridViewTextBoxColumn.DataPropertyName = "fecha_de_inicio_relacion";
            this.fechadeiniciorelacionDataGridViewTextBoxColumn.HeaderText = "fecha_de_inicio_relacion";
            this.fechadeiniciorelacionDataGridViewTextBoxColumn.Name = "fechadeiniciorelacionDataGridViewTextBoxColumn";
            // 
            // condiciondepagoDataGridViewTextBoxColumn
            // 
            this.condiciondepagoDataGridViewTextBoxColumn.DataPropertyName = "condicion_de_pago";
            this.condiciondepagoDataGridViewTextBoxColumn.HeaderText = "condicion_de_pago";
            this.condiciondepagoDataGridViewTextBoxColumn.Name = "condiciondepagoDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.condicion_de_pago);
            this.Controls.Add(this.fecha_de_inicio_relacion);
            this.Controls.Add(this.correo_electronico);
            this.Controls.Add(this.direccion_fisica_entrega);
            this.Controls.Add(this.limite_de_credito);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.codigo_postal);
            this.Controls.Add(this.direccion_fisica);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo_cliente);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.Agregar);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label condicion_de_pago;
        private System.Windows.Forms.Label fecha_de_inicio_relacion;
        private System.Windows.Forms.Label correo_electronico;
        private System.Windows.Forms.Label direccion_fisica_entrega;
        private System.Windows.Forms.Label limite_de_credito;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label codigo_postal;
        private System.Windows.Forms.Label direccion_fisica;
        private System.Windows.Forms.Label pais;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label codigo_cliente;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Agregar;
        private SistemaVentasDataSet sistemaVentasDataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private SistemaVentasDataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource1;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource2;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionfisicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitedecreditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionfisicaentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoelectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeiniciorelacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condiciondepagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource4;
    }
}