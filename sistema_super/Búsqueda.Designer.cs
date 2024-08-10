namespace sistema_super
{
    partial class Búsqueda
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
            this.Buscar = new System.Windows.Forms.Button();
            this.idbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultadoBuscar = new System.Windows.Forms.DataGridView();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Buscar.Location = new System.Drawing.Point(485, 148);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // idbuscar
            // 
            this.idbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.idbuscar.Location = new System.Drawing.Point(150, 12);
            this.idbuscar.Name = "idbuscar";
            this.idbuscar.Size = new System.Drawing.Size(100, 24);
            this.idbuscar.TabIndex = 1;
            this.idbuscar.TextChanged += new System.EventHandler(this.idbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa el ID";
            // 
            // resultadoBuscar
            // 
            this.resultadoBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoBuscar.Location = new System.Drawing.Point(12, 55);
            this.resultadoBuscar.Name = "resultadoBuscar";
            this.resultadoBuscar.Size = new System.Drawing.Size(548, 76);
            this.resultadoBuscar.TabIndex = 3;
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.volver.Location = new System.Drawing.Point(385, 148);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Búsqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 183);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.resultadoBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idbuscar);
            this.Controls.Add(this.Buscar);
            this.Name = "Búsqueda";
            this.Text = "Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox idbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView resultadoBuscar;
        private System.Windows.Forms.Button volver;
    }
}