namespace Hemeroteca.Vistas
{
    partial class frmEditarDireccion
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label calleLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label dptoLabel;
            System.Windows.Forms.Label codigopostalLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label continenteLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.direccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calleTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.dptoTextBox = new System.Windows.Forms.TextBox();
            this.codigopostalTextBox = new System.Windows.Forms.TextBox();
            this.ciudadComboBox = new System.Windows.Forms.ComboBox();
            this.provinciaComboBox = new System.Windows.Forms.ComboBox();
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.continenteComboBox = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            calleLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            dptoLabel = new System.Windows.Forms.Label();
            codigopostalLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            continenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            idLabel.ForeColor = System.Drawing.SystemColors.Control;
            idLabel.Location = new System.Drawing.Point(80, 24);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(24, 19);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // calleLabel
            // 
            calleLabel.AutoSize = true;
            calleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            calleLabel.ForeColor = System.Drawing.SystemColors.Control;
            calleLabel.Location = new System.Drawing.Point(61, 72);
            calleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            calleLabel.Name = "calleLabel";
            calleLabel.Size = new System.Drawing.Size(41, 19);
            calleLabel.TabIndex = 3;
            calleLabel.Text = "Calle:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            numeroLabel.ForeColor = System.Drawing.SystemColors.Control;
            numeroLabel.Location = new System.Drawing.Point(43, 175);
            numeroLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(63, 19);
            numeroLabel.TabIndex = 5;
            numeroLabel.Text = "Numero:";
            // 
            // dptoLabel
            // 
            dptoLabel.AutoSize = true;
            dptoLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            dptoLabel.ForeColor = System.Drawing.SystemColors.Control;
            dptoLabel.Location = new System.Drawing.Point(61, 123);
            dptoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dptoLabel.Name = "dptoLabel";
            dptoLabel.Size = new System.Drawing.Size(43, 19);
            dptoLabel.TabIndex = 7;
            dptoLabel.Text = "Dpto:";
            // 
            // codigopostalLabel
            // 
            codigopostalLabel.AutoSize = true;
            codigopostalLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            codigopostalLabel.ForeColor = System.Drawing.SystemColors.Control;
            codigopostalLabel.Location = new System.Drawing.Point(11, 229);
            codigopostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigopostalLabel.Name = "codigopostalLabel";
            codigopostalLabel.Size = new System.Drawing.Size(93, 19);
            codigopostalLabel.TabIndex = 9;
            codigopostalLabel.Text = "Codigopostal:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            ciudadLabel.ForeColor = System.Drawing.SystemColors.Control;
            ciudadLabel.Location = new System.Drawing.Point(277, 19);
            ciudadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(55, 19);
            ciudadLabel.TabIndex = 11;
            ciudadLabel.Text = "Ciudad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            provinciaLabel.ForeColor = System.Drawing.SystemColors.Control;
            provinciaLabel.Location = new System.Drawing.Point(262, 87);
            provinciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(68, 19);
            provinciaLabel.TabIndex = 12;
            provinciaLabel.Text = "Provincia:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            paisLabel.ForeColor = System.Drawing.SystemColors.Control;
            paisLabel.Location = new System.Drawing.Point(294, 147);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(36, 19);
            paisLabel.TabIndex = 14;
            paisLabel.Text = "Pais:";
            // 
            // continenteLabel
            // 
            continenteLabel.AutoSize = true;
            continenteLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            continenteLabel.ForeColor = System.Drawing.SystemColors.Control;
            continenteLabel.Location = new System.Drawing.Point(253, 209);
            continenteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            continenteLabel.Name = "continenteLabel";
            continenteLabel.Size = new System.Drawing.Size(80, 19);
            continenteLabel.TabIndex = 16;
            continenteLabel.Text = "Continente:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(113, 19);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(132, 25);
            this.idTextBox.TabIndex = 2;
            // 
            // direccionBindingSource
            // 
            this.direccionBindingSource.DataSource = typeof(Hemeroteca.Entidades.Direccion);
            // 
            // calleTextBox
            // 
            this.calleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Calle", true));
            this.calleTextBox.Location = new System.Drawing.Point(113, 68);
            this.calleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.calleTextBox.Name = "calleTextBox";
            this.calleTextBox.Size = new System.Drawing.Size(132, 25);
            this.calleTextBox.TabIndex = 4;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(113, 171);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(132, 25);
            this.numeroTextBox.TabIndex = 6;
            // 
            // dptoTextBox
            // 
            this.dptoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Dpto", true));
            this.dptoTextBox.Location = new System.Drawing.Point(113, 118);
            this.dptoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.dptoTextBox.Name = "dptoTextBox";
            this.dptoTextBox.Size = new System.Drawing.Size(132, 25);
            this.dptoTextBox.TabIndex = 8;
            // 
            // codigopostalTextBox
            // 
            this.codigopostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Codigopostal", true));
            this.codigopostalTextBox.Location = new System.Drawing.Point(113, 224);
            this.codigopostalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigopostalTextBox.Name = "codigopostalTextBox";
            this.codigopostalTextBox.Size = new System.Drawing.Size(132, 25);
            this.codigopostalTextBox.TabIndex = 10;
            // 
            // ciudadComboBox
            // 
            this.ciudadComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Ciudad", true));
            this.ciudadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudadComboBox.FormattingEnabled = true;
            this.ciudadComboBox.Location = new System.Drawing.Point(342, 15);
            this.ciudadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ciudadComboBox.Name = "ciudadComboBox";
            this.ciudadComboBox.Size = new System.Drawing.Size(160, 27);
            this.ciudadComboBox.TabIndex = 12;
            // 
            // provinciaComboBox
            // 
            this.provinciaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Ciudad.Provincia", true));
            this.provinciaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinciaComboBox.FormattingEnabled = true;
            this.provinciaComboBox.Location = new System.Drawing.Point(342, 82);
            this.provinciaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.provinciaComboBox.Name = "provinciaComboBox";
            this.provinciaComboBox.Size = new System.Drawing.Size(160, 27);
            this.provinciaComboBox.TabIndex = 13;
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Ciudad.Provincia.Pais", true));
            this.paisComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(342, 142);
            this.paisComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(160, 27);
            this.paisComboBox.TabIndex = 15;
            // 
            // continenteComboBox
            // 
            this.continenteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.direccionBindingSource, "Ciudad.Provincia.Pais.Continente", true));
            this.continenteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.continenteComboBox.FormattingEnabled = true;
            this.continenteComboBox.Location = new System.Drawing.Point(342, 205);
            this.continenteComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.continenteComboBox.Name = "continenteComboBox";
            this.continenteComboBox.Size = new System.Drawing.Size(160, 27);
            this.continenteComboBox.TabIndex = 17;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCancelar.Location = new System.Drawing.Point(322, 281);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 44);
            this.btCancelar.TabIndex = 30;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAceptar.Location = new System.Drawing.Point(95, 281);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(118, 44);
            this.btAceptar.TabIndex = 29;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // frmEditarDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(518, 375);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(continenteLabel);
            this.Controls.Add(this.continenteComboBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisComboBox);
            this.Controls.Add(provinciaLabel);
            this.Controls.Add(this.provinciaComboBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadComboBox);
            this.Controls.Add(codigopostalLabel);
            this.Controls.Add(this.codigopostalTextBox);
            this.Controls.Add(dptoLabel);
            this.Controls.Add(this.dptoTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(calleLabel);
            this.Controls.Add(this.calleTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEditarDireccion";
            this.Text = "frmEditarDireccion";
            ((System.ComponentModel.ISupportInitialize)(this.direccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource direccionBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox calleTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox dptoTextBox;
        private System.Windows.Forms.TextBox codigopostalTextBox;
        private System.Windows.Forms.ComboBox ciudadComboBox;
        private System.Windows.Forms.ComboBox provinciaComboBox;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.ComboBox continenteComboBox;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}