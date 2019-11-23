namespace MarketbooksPro
{
    partial class Biblioteca
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
            this.label1 = new System.Windows.Forms.Label();
            this.idLibro = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.texto1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.Visual2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Visual2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo Libro";
            // 
            // idLibro
            // 
            this.idLibro.Location = new System.Drawing.Point(126, 62);
            this.idLibro.Name = "idLibro";
            this.idLibro.Size = new System.Drawing.Size(150, 20);
            this.idLibro.TabIndex = 4;
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(301, 371);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(104, 28);
            this.salir.TabIndex = 21;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto1.Location = new System.Drawing.Point(12, 9);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(300, 31);
            this.texto1.TabIndex = 22;
            this.texto1.Text = "Gestion de Biblioteca";
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(301, 54);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(104, 28);
            this.buscar.TabIndex = 30;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // Visual2
            // 
            this.Visual2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Visual2.Location = new System.Drawing.Point(23, 102);
            this.Visual2.Name = "Visual2";
            this.Visual2.Size = new System.Drawing.Size(382, 263);
            this.Visual2.TabIndex = 31;
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 411);
            this.Controls.Add(this.Visual2);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.texto1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLibro);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.Visual2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idLibro;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView Visual2;
    }
}