
namespace Hemeroteca.Vistas
{
    partial class frmRevistaFacultad
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
            this.revistaFacultadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revistaFacultadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txNombre = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.revistaFacultadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaFacultadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // revistaFacultadDataGridView
            // 
            this.revistaFacultadDataGridView.AutoGenerateColumns = false;
            this.revistaFacultadDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.revistaFacultadDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.revistaFacultadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revistaFacultadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.revistaFacultadDataGridView.DataSource = this.revistaFacultadBindingSource;
            this.revistaFacultadDataGridView.Location = new System.Drawing.Point(12, 80);
            this.revistaFacultadDataGridView.Name = "revistaFacultadDataGridView";
            this.revistaFacultadDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.revistaFacultadDataGridView.Size = new System.Drawing.Size(960, 589);
            this.revistaFacultadDataGridView.TabIndex = 1;
            this.revistaFacultadDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revistaFacultadDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Revista";
            this.dataGridViewTextBoxColumn2.HeaderText = "Revista";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Facultad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Facultad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // revistaFacultadBindingSource
            // 
            this.revistaFacultadBindingSource.DataSource = typeof(Hemeroteca.Entidades.RevistaFacultad);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(116, 34);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(358, 20);
            this.txNombre.TabIndex = 52;
            this.txNombre.TextChanged += new System.EventHandler(this.txNombre_TextChanged);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(503, 23);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(111, 38);
            this.btBuscar.TabIndex = 51;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Facultad";
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.Location = new System.Drawing.Point(862, 25);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(110, 38);
            this.btCerrar.TabIndex = 53;
            this.btCerrar.Text = "Atrás";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // frmRevistaFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.revistaFacultadDataGridView);
            this.Name = "frmRevistaFacultad";
            ((System.ComponentModel.ISupportInitialize)(this.revistaFacultadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revistaFacultadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource revistaFacultadBindingSource;
        private System.Windows.Forms.DataGridView revistaFacultadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCerrar;
    }
}