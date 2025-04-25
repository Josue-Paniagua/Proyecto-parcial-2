namespace formproyecto2.UI
{
    partial class CrearJugadorForm
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
        /// 
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numNivel = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(296, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(131, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // numNivel
            // 
            this.numNivel.Location = new System.Drawing.Point(492, 39);
            this.numNivel.Name = "numNivel";
            this.numNivel.Size = new System.Drawing.Size(51, 20);
            this.numNivel.TabIndex = 1;
            this.numNivel.ValueChanged += new System.EventHandler(this.numNivel_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(465, 95);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 37);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(50, 157);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(412, 200);
            this.dgvInventario.TabIndex = 3;
            // 
            // CrearJugadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numNivel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvInventario);
            this.Name = "CrearJugadorForm";
            this.Text = "CrearJugadorForm";
            ((System.ComponentModel.ISupportInitialize)(this.numNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.pbBloque = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBloque)).BeginInit();
            this.SuspendLayout();

            // 
            // pbBloque
            // 
            this.pbBloque.Location = new System.Drawing.Point(500, 157); // Ajusta la posición según sea necesario
            this.pbBloque.Name = "pbBloque";
            this.pbBloque.Size = new System.Drawing.Size(150, 150); // Ajusta el tamaño según sea necesario
            this.pbBloque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage; // Ajusta la imagen al tamaño del PictureBox
            this.pbBloque.TabIndex = 4;
            this.pbBloque.TabStop = false;
            this.dgvInventario.SelectionChanged += new System.EventHandler(this.dgvInventario_SelectionChanged);
            // 
            // CrearJugadorForm
            // 
            this.Controls.Add(this.pbBloque);
            this.ResumeLayout(false);
            this.PerformLayout();
           
            this.btnExportarInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // btnExportarInventario
            // 
            this.btnExportarInventario.Location = new System.Drawing.Point(500, 320); // Ajusta la posición según sea necesario
            this.btnExportarInventario.Name = "btnExportarInventario";
            this.btnExportarInventario.Size = new System.Drawing.Size(150, 30);
            this.btnExportarInventario.TabIndex = 5;
            this.btnExportarInventario.Text = "Exportar Inventario";
            this.btnExportarInventario.UseVisualStyleBackColor = true;
            this.btnExportarInventario.Click += new System.EventHandler(this.btnExportarInventario_Click);

            // 
            // CrearJugadorForm
            // 
            this.Controls.Add(this.btnExportarInventario);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown numNivel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.PictureBox pbBloque;
        private System.Windows.Forms.Button btnExportarInventario;


    }
}