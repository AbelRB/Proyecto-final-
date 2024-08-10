namespace sistema_super
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabla_productos = new System.Windows.Forms.Button();
            this.tabla_cate = new System.Windows.Forms.Button();
            this.tabla_prove = new System.Windows.Forms.Button();
            this.tabla_ventas = new System.Windows.Forms.Button();
            this.tabla_ventas_detalles = new System.Windows.Forms.Button();
            this.tabla_clientes = new System.Windows.Forms.Button();
            this.salido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabla_productos
            // 
            this.tabla_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_productos.Image = ((System.Drawing.Image)(resources.GetObject("tabla_productos.Image")));
            this.tabla_productos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_productos.Location = new System.Drawing.Point(268, 31);
            this.tabla_productos.Name = "tabla_productos";
            this.tabla_productos.Size = new System.Drawing.Size(123, 101);
            this.tabla_productos.TabIndex = 1;
            this.tabla_productos.Text = "Productos";
            this.tabla_productos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_productos.UseVisualStyleBackColor = true;
            this.tabla_productos.Click += new System.EventHandler(this.tabla_productos_Click);
            // 
            // tabla_cate
            // 
            this.tabla_cate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_cate.ForeColor = System.Drawing.Color.Black;
            this.tabla_cate.Image = ((System.Drawing.Image)(resources.GetObject("tabla_cate.Image")));
            this.tabla_cate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_cate.Location = new System.Drawing.Point(434, 31);
            this.tabla_cate.Name = "tabla_cate";
            this.tabla_cate.Size = new System.Drawing.Size(118, 101);
            this.tabla_cate.TabIndex = 2;
            this.tabla_cate.Text = "Categorías";
            this.tabla_cate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_cate.UseVisualStyleBackColor = true;
            this.tabla_cate.Click += new System.EventHandler(this.tabla_cate_Click);
            // 
            // tabla_prove
            // 
            this.tabla_prove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_prove.Image = ((System.Drawing.Image)(resources.GetObject("tabla_prove.Image")));
            this.tabla_prove.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_prove.Location = new System.Drawing.Point(80, 148);
            this.tabla_prove.Name = "tabla_prove";
            this.tabla_prove.Size = new System.Drawing.Size(141, 100);
            this.tabla_prove.TabIndex = 3;
            this.tabla_prove.Text = "Proveedores";
            this.tabla_prove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_prove.UseVisualStyleBackColor = true;
            this.tabla_prove.Click += new System.EventHandler(this.tabla_prove_Click);
            // 
            // tabla_ventas
            // 
            this.tabla_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_ventas.Image = ((System.Drawing.Image)(resources.GetObject("tabla_ventas.Image")));
            this.tabla_ventas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_ventas.Location = new System.Drawing.Point(268, 148);
            this.tabla_ventas.Name = "tabla_ventas";
            this.tabla_ventas.Size = new System.Drawing.Size(123, 100);
            this.tabla_ventas.TabIndex = 4;
            this.tabla_ventas.Text = "Ventas";
            this.tabla_ventas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_ventas.UseVisualStyleBackColor = true;
            this.tabla_ventas.Click += new System.EventHandler(this.tabla_ventas_Click);
            // 
            // tabla_ventas_detalles
            // 
            this.tabla_ventas_detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_ventas_detalles.Image = ((System.Drawing.Image)(resources.GetObject("tabla_ventas_detalles.Image")));
            this.tabla_ventas_detalles.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_ventas_detalles.Location = new System.Drawing.Point(434, 148);
            this.tabla_ventas_detalles.Name = "tabla_ventas_detalles";
            this.tabla_ventas_detalles.Size = new System.Drawing.Size(118, 100);
            this.tabla_ventas_detalles.TabIndex = 5;
            this.tabla_ventas_detalles.Text = "Detalles ";
            this.tabla_ventas_detalles.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_ventas_detalles.UseVisualStyleBackColor = true;
            this.tabla_ventas_detalles.Click += new System.EventHandler(this.tabla_ventas_detalles_Click);
            // 
            // tabla_clientes
            // 
            this.tabla_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_clientes.Image = ((System.Drawing.Image)(resources.GetObject("tabla_clientes.Image")));
            this.tabla_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_clientes.Location = new System.Drawing.Point(80, 31);
            this.tabla_clientes.Name = "tabla_clientes";
            this.tabla_clientes.Size = new System.Drawing.Size(141, 101);
            this.tabla_clientes.TabIndex = 6;
            this.tabla_clientes.Text = "Clientes";
            this.tabla_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_clientes.UseVisualStyleBackColor = true;
            this.tabla_clientes.Click += new System.EventHandler(this.tabla_clientes_Click);
            // 
            // salido
            // 
            this.salido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.salido.Image = ((System.Drawing.Image)(resources.GetObject("salido.Image")));
            this.salido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salido.Location = new System.Drawing.Point(477, 284);
            this.salido.Name = "salido";
            this.salido.Size = new System.Drawing.Size(128, 31);
            this.salido.TabIndex = 7;
            this.salido.Text = "Cerrar sesión";
            this.salido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salido.UseVisualStyleBackColor = true;
            this.salido.Click += new System.EventHandler(this.salido_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 327);
            this.Controls.Add(this.salido);
            this.Controls.Add(this.tabla_clientes);
            this.Controls.Add(this.tabla_ventas_detalles);
            this.Controls.Add(this.tabla_ventas);
            this.Controls.Add(this.tabla_prove);
            this.Controls.Add(this.tabla_cate);
            this.Controls.Add(this.tabla_productos);
            this.Name = "Form1";
            this.Text = "Super ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tabla_productos;
        private System.Windows.Forms.Button tabla_cate;
        private System.Windows.Forms.Button tabla_prove;
        private System.Windows.Forms.Button tabla_ventas;
        private System.Windows.Forms.Button tabla_ventas_detalles;
        private System.Windows.Forms.Button tabla_clientes;
        private System.Windows.Forms.Button salido;
    }
}

