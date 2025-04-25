namespace formproyecto2.UI
{
    partial class GestionarJugadoresForm
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



        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button dbtncrearb;

   
        private void InitializeComponent()
        {
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dbtncrearb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(12, 12);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.Size = new System.Drawing.Size(500, 300);
            this.dgvJugadores.TabIndex = 0;

            // 
            // GestionarJugadoresForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.dgvJugadores);
            this.Name = "GestionarJugadoresForm";
            this.Text = "Gestión de Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Location = new System.Drawing.Point(12, 12);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(500, 300);
            this.dgvJugadores.TabIndex = 0;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(530, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(530, 60);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 30);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // dbtncrearb
            // 
            this.dbtncrearb.Location = new System.Drawing.Point(530, 100);
            this.dbtncrearb.Name = "dbtncrearb";
            this.dbtncrearb.Size = new System.Drawing.Size(100, 30);
            this.dbtncrearb.TabIndex = 3;
            this.dbtncrearb.Text = "Crear";
            this.dbtncrearb.UseVisualStyleBackColor = true;
            this.dbtncrearb.Click += new System.EventHandler(this.dbtncrearb_Click);
            // 
            // GestionarJugadoresForm
            // 
            this.ClientSize = new System.Drawing.Size(650, 330);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dbtncrearb);
            this.Name = "GestionarJugadoresForm";
            this.Text = "Gestión de Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);

        }

    }
}

    #endregion
