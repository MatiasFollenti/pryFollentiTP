namespace pryFollentiTP
{
    partial class frmListar
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListadoC = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(351, 96);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 26);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 327);
            this.panel1.TabIndex = 9;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostrar.Location = new System.Drawing.Point(0, 0);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(789, 327);
            this.dgvMostrar.TabIndex = 0;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "APELLIDO",
            "CIUDAD"});
            this.cmbBuscar.Location = new System.Drawing.Point(162, 34);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(192, 21);
            this.cmbBuscar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elija parámetro de búsqueda:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(510, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingrese Apellido/Ciudad";
            // 
            // btnListadoC
            // 
            this.btnListadoC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListadoC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListadoC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoC.Location = new System.Drawing.Point(457, 96);
            this.btnListadoC.Name = "btnListadoC";
            this.btnListadoC.Size = new System.Drawing.Size(213, 26);
            this.btnListadoC.TabIndex = 14;
            this.btnListadoC.Text = "Mostrar listado completo";
            this.btnListadoC.UseVisualStyleBackColor = false;
            this.btnListadoC.Click += new System.EventHandler(this.btnListadoC_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(686, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 26);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 468);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListadoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.ComboBox cmbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListadoC;
        private System.Windows.Forms.Button btnBuscar;
    }
}