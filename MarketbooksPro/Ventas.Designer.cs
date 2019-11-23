namespace MarketbooksPro
{
    partial class Ventas
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
            this.texto1 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.CodigoEmpleado = new System.Windows.Forms.TextBox();
            this.idCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idBiblioteca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecioLibro = new System.Windows.Forms.TextBox();
            this.CantDisponible = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.codigoventa = new System.Windows.Forms.TextBox();
            this.agregar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Itbis = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.Visual = new System.Windows.Forms.DataGridView();
            this.Total1 = new System.Windows.Forms.Label();
            this.Total2 = new System.Windows.Forms.Label();
            this.Total3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.imprime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual)).BeginInit();
            this.SuspendLayout();
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(12, 9);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(109, 31);
            this.texto1.TabIndex = 10;
            this.texto1.Text = "Ventas";
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(743, 527);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(104, 28);
            this.salir.TabIndex = 20;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cliente);
            this.groupBox1.Controls.Add(this.CodigoEmpleado);
            this.groupBox1.Controls.Add(this.idCliente);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 154);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(150, 107);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(123, 26);
            this.fecha.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(17, 37);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(57, 18);
            this.Cliente.TabIndex = 3;
            this.Cliente.Text = "Cliente";
            // 
            // CodigoEmpleado
            // 
            this.CodigoEmpleado.Location = new System.Drawing.Point(150, 72);
            this.CodigoEmpleado.Name = "CodigoEmpleado";
            this.CodigoEmpleado.Size = new System.Drawing.Size(123, 26);
            this.CodigoEmpleado.TabIndex = 1;
            // 
            // idCliente
            // 
            this.idCliente.Location = new System.Drawing.Point(123, 38);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(150, 26);
            this.idCliente.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.idBiblioteca);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.PrecioLibro);
            this.groupBox2.Controls.Add(this.CantDisponible);
            this.groupBox2.Controls.Add(this.Descripcion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Estado);
            this.groupBox2.Controls.Add(this.codigoventa);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(344, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(503, 154);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "idBiblioteca";
            // 
            // idBiblioteca
            // 
            this.idBiblioteca.Location = new System.Drawing.Point(386, 37);
            this.idBiblioteca.Name = "idBiblioteca";
            this.idBiblioteca.Size = new System.Drawing.Size(102, 26);
            this.idBiblioteca.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(291, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad";
            // 
            // PrecioLibro
            // 
            this.PrecioLibro.Location = new System.Drawing.Point(386, 110);
            this.PrecioLibro.Name = "PrecioLibro";
            this.PrecioLibro.Size = new System.Drawing.Size(102, 26);
            this.PrecioLibro.TabIndex = 8;
            // 
            // CantDisponible
            // 
            this.CantDisponible.Location = new System.Drawing.Point(386, 74);
            this.CantDisponible.Name = "CantDisponible";
            this.CantDisponible.Size = new System.Drawing.Size(102, 26);
            this.CantDisponible.TabIndex = 7;
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(150, 109);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(123, 26);
            this.Descripcion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Codigo";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(150, 72);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(123, 26);
            this.Estado.TabIndex = 1;
            // 
            // codigoventa
            // 
            this.codigoventa.Location = new System.Drawing.Point(150, 38);
            this.codigoventa.Name = "codigoventa";
            this.codigoventa.Size = new System.Drawing.Size(123, 26);
            this.codigoventa.TabIndex = 0;
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(730, 255);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(117, 28);
            this.agregar.TabIndex = 24;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // limpiar
            // 
            this.limpiar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiar.Location = new System.Drawing.Point(730, 289);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(117, 28);
            this.limpiar.TabIndex = 25;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.Location = new System.Drawing.Point(730, 323);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(117, 28);
            this.actualizar.TabIndex = 26;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(730, 358);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(117, 28);
            this.eliminar.TabIndex = 27;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Total";
            // 
            // Itbis
            // 
            this.Itbis.AutoSize = true;
            this.Itbis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Itbis.Location = new System.Drawing.Point(587, 486);
            this.Itbis.Name = "Itbis";
            this.Itbis.Size = new System.Drawing.Size(36, 18);
            this.Itbis.TabIndex = 28;
            this.Itbis.Text = "Itbis";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(743, 485);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(104, 28);
            this.buscar.TabIndex = 29;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Visual
            // 
            this.Visual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visual.Location = new System.Drawing.Point(12, 255);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(697, 180);
            this.Visual.TabIndex = 30;
            // 
            // Total1
            // 
            this.Total1.AutoSize = true;
            this.Total1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total1.Location = new System.Drawing.Point(668, 452);
            this.Total1.Name = "Total1";
            this.Total1.Size = new System.Drawing.Size(39, 18);
            this.Total1.TabIndex = 31;
            this.Total1.Text = "0.00";
            // 
            // Total2
            // 
            this.Total2.AutoSize = true;
            this.Total2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total2.Location = new System.Drawing.Point(668, 486);
            this.Total2.Name = "Total2";
            this.Total2.Size = new System.Drawing.Size(39, 18);
            this.Total2.TabIndex = 32;
            this.Total2.Text = "0.00";
            // 
            // Total3
            // 
            this.Total3.AutoSize = true;
            this.Total3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total3.Location = new System.Drawing.Point(668, 518);
            this.Total3.Name = "Total3";
            this.Total3.Size = new System.Drawing.Size(39, 18);
            this.Total3.TabIndex = 34;
            this.Total3.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(585, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 33;
            this.label12.Text = "Total Neto";
            // 
            // imprime
            // 
            this.imprime.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprime.Location = new System.Drawing.Point(730, 392);
            this.imprime.Name = "imprime";
            this.imprime.Size = new System.Drawing.Size(117, 28);
            this.imprime.TabIndex = 35;
            this.imprime.Text = "Imprimir";
            this.imprime.UseVisualStyleBackColor = true;
            this.imprime.Click += new System.EventHandler(this.imprime_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 567);
            this.Controls.Add(this.imprime);
            this.Controls.Add(this.Total3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Total2);
            this.Controls.Add(this.Total1);
            this.Controls.Add(this.Visual);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.Itbis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.texto1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.TextBox CodigoEmpleado;
        private System.Windows.Forms.TextBox idCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PrecioLibro;
        private System.Windows.Forms.TextBox CantDisponible;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.TextBox codigoventa;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Itbis;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.DataGridView Visual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBiblioteca;
        private System.Windows.Forms.Label Total1;
        private System.Windows.Forms.Label Total2;
        private System.Windows.Forms.Label Total3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button imprime;
    }
}