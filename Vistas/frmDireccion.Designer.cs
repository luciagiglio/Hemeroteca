namespace Hemeroteca.Vistas
{
    partial class frmDireccion
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
            this.txNombre = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.direccionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.direccionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(108, 34);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(358, 20);
            this.txNombre.TabIndex = 42;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(516, 23);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(111, 38);
            this.btBuscar.TabIndex = 41;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Calle";
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(1131, 25);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(110, 38);
            this.btCerrar.TabIndex = 39;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(1004, 25);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(110, 38);
            this.btEliminar.TabIndex = 38;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(877, 25);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 38);
            this.btEditar.TabIndex = 37;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(751, 25);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(111, 38);
            this.btNuevo.TabIndex = 36;
            this.btNuevo.Text = "Nueva";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // direccionDataGridView
            // 
            this.direccionDataGridView.AutoGenerateColumns = false;
            this.direccionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.direccionDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.direccionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.direccionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.direccionDataGridView.DataSource = this.direccionBindingSource;
            this.direccionDataGridView.Location = new System.Drawing.Point(21, 81);
            this.direccionDataGridView.Name = "direccionDataGridView";
            this.direccionDataGridView.Size = new System.Drawing.Size(1232, 588);
            this.direccionDataGridView.TabIndex = 1;
            this.direccionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.direccionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Calle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Calle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Dpto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Dpto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Codigopostal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigopostal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataSource = typeof(Hemeroteca.Entidades.Direccion);
            // 
            // frmDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.direccionDataGridView);
            this.Name = "frmDireccion";
            this.Text = "fmDireccion";
            ((System.ComponentModel.ISupportInitialize)(this.direccionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource direccionBindingSource;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DataGridView direccionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}