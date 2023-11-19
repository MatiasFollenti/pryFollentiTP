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
            this.tcDirContact = new System.Windows.Forms.TabControl();
            this.tpApe = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tpDir = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.tcDirContact.SuspendLayout();
            this.tpApe.SuspendLayout();
            this.tpDir.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tcDirContact
            // 
            this.tcDirContact.Controls.Add(this.tpApe);
            this.tcDirContact.Controls.Add(this.tpDir);
            this.tcDirContact.Location = new System.Drawing.Point(71, 12);
            this.tcDirContact.Name = "tcDirContact";
            this.tcDirContact.SelectedIndex = 0;
            this.tcDirContact.Size = new System.Drawing.Size(445, 113);
            this.tcDirContact.TabIndex = 7;
            // 
            // tpApe
            // 
            this.tpApe.BackColor = System.Drawing.Color.LightGray;
            this.tpApe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpApe.Controls.Add(this.label6);
            this.tpApe.Controls.Add(this.txtApellido);
            this.tpApe.Location = new System.Drawing.Point(4, 22);
            this.tpApe.Name = "tpApe";
            this.tpApe.Padding = new System.Windows.Forms.Padding(3);
            this.tpApe.Size = new System.Drawing.Size(437, 87);
            this.tpApe.TabIndex = 0;
            this.tpApe.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(123, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(191, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // tpDir
            // 
            this.tpDir.BackColor = System.Drawing.Color.LightGray;
            this.tpDir.Controls.Add(this.label1);
            this.tpDir.Controls.Add(this.txtCalle);
            this.tpDir.Location = new System.Drawing.Point(4, 22);
            this.tpDir.Name = "tpDir";
            this.tpDir.Padding = new System.Windows.Forms.Padding(3);
            this.tpDir.Size = new System.Drawing.Size(437, 87);
            this.tpDir.TabIndex = 1;
            this.tpDir.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(141, 37);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(191, 20);
            this.txtCalle.TabIndex = 10;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(421, 131);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(91, 26);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 278);
            this.panel1.TabIndex = 9;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMostrar.Location = new System.Drawing.Point(0, 0);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(594, 278);
            this.dgvMostrar.TabIndex = 0;
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.tcDirContact);
            this.Name = "frmListar";
            this.Text = "frmListar";
            this.tcDirContact.ResumeLayout(false);
            this.tpApe.ResumeLayout(false);
            this.tpApe.PerformLayout();
            this.tpDir.ResumeLayout(false);
            this.tpDir.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcDirContact;
        private System.Windows.Forms.TabPage tpApe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TabPage tpDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}