namespace Hemeroteca.Vistas
{
    partial class frmRevista
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
            this.revistaDataGridView = new System.Windows.Forms.DataGridView();
            this.txNombreRevista = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btUso = new System.Windows.Forms.Button();
            this.btFacultad = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.revistaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // revistaDataGridView
            // 
            this.revistaDataGridView.AutoGenerateColumns = false;
            this.revistaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revistaDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.revistaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revistaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.revistaDataGridView.DataSource = this.revistaBindingSource;
            this.revistaDataGridView.Location = new System.Drawing.Point(12, 123);
            this.revistaDataGridView.Name = "revistaDataGridView";
            this.revistaDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.revistaDataGridView.Size = new System.Drawing.Size(1241, 546);
            this.revistaDataGridView.TabIndex = 1;
            this.revistaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RevistaDataGridView_CellContentClick);
            // 
            // txNombreRevista
            // 
            this.txNombreRevista.Location = new System.Drawing.Point(116, 46);
            this.txNombreRevista.Name = "txNombreRevista";
            this.txNombreRevista.Size = new System.Drawing.Size(358, 20);
            this.txNombreRevista.TabIndex = 49;
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(519, 34);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(111, 38);
            this.btBuscar.TabIndex = 48;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Titulo";
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(1143, 12);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(110, 38);
            this.btCerrar.TabIndex = 46;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(1016, 12);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(110, 38);
            this.btEliminar.TabIndex = 45;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(889, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(110, 38);
            this.btEditar.TabIndex = 44;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(763, 12);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(111, 38);
            this.btNuevo.TabIndex = 43;
            this.btNuevo.Text = "Nueva";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.BtNuevo_Click);
            // 
            // btUso
            // 
            this.btUso.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUso.Location = new System.Drawing.Point(763, 56);
            this.btUso.Name = "btUso";
            this.btUso.Size = new System.Drawing.Size(111, 51);
            this.btUso.TabIndex = 50;
            this.btUso.Text = "Uso de Revista";
            this.btUso.UseVisualStyleBackColor = true;
            // 
            // btFacultad
            // 
            this.btFacultad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFacultad.Location = new System.Drawing.Point(889, 56);
            this.btFacultad.Name = "btFacultad";
            this.btFacultad.Size = new System.Drawing.Size(110, 51);
            this.btFacultad.TabIndex = 51;
            this.btFacultad.Text = "Facultad Asociada";
            this.btFacultad.UseVisualStyleBackColor = true;
            this.btFacultad.Click += new System.EventHandler(this.btFacultad_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tema";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tema";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Editor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Editor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn7.HeaderText = "Area";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Edicion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Edicion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Tituloanterior";
            this.dataGridViewTextBoxColumn9.HeaderText = "Tituloanterior";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Otrainfo";
            this.dataGridViewTextBoxColumn10.HeaderText = "Otrainfo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Anotaciones";
            this.dataGridViewTextBoxColumn11.HeaderText = "Anotaciones";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn13.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "FondoLocal";
            this.dataGridViewTextBoxColumn14.HeaderText = "FondoLocal";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // revistaBindingSource
            // 
            this.revistaBindingSource.DataSource = typeof(Hemeroteca.Entidades.Revista);
            // 
            // frmRevista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.btFacultad);
            this.Controls.Add(this.btUso);
            this.Controls.Add(this.txNombreRevista);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.revistaDataGridView);
            this.Name = "frmRevista";
            this.Text = "frmRevista";
            ((System.ComponentModel.ISupportInitialize)(this.revistaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource revistaBindingSource;
        private System.Windows.Forms.DataGridView revistaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox txNombreRevista;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btUso;
        private System.Windows.Forms.Button btFacultad;
    }
}