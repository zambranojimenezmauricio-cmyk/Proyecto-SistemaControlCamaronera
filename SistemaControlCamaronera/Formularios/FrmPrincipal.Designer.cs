namespace SistemaControlCamaronera {
    partial class FrmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.dvgLotes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLotes = new System.Windows.Forms.TextBox();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLiquidacionTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarLote = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.borde = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfoLote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgLotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(492, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema De Gestion Y Control  Camaronero";
            // 
            // dvgLotes
            // 
            this.dvgLotes.BackgroundColor = System.Drawing.Color.White;
            this.dvgLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgLotes.Location = new System.Drawing.Point(31, 107);
            this.dvgLotes.Name = "dvgLotes";
            this.dvgLotes.RowHeadersWidth = 47;
            this.dvgLotes.Size = new System.Drawing.Size(853, 652);
            this.dvgLotes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(904, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registros:";
            // 
            // txtLotes
            // 
            this.txtLotes.Location = new System.Drawing.Point(1048, 393);
            this.txtLotes.Multiline = true;
            this.txtLotes.Name = "txtLotes";
            this.txtLotes.Size = new System.Drawing.Size(102, 29);
            this.txtLotes.TabIndex = 4;
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(1048, 440);
            this.txtPesoTotal.Multiline = true;
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(102, 29);
            this.txtPesoTotal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(904, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Total:";
            // 
            // txtLiquidacionTotal
            // 
            this.txtLiquidacionTotal.Location = new System.Drawing.Point(1182, 440);
            this.txtLiquidacionTotal.Multiline = true;
            this.txtLiquidacionTotal.Name = "txtLiquidacionTotal";
            this.txtLiquidacionTotal.Size = new System.Drawing.Size(250, 29);
            this.txtLiquidacionTotal.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1190, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liquidacion Total:";
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLote.Location = new System.Drawing.Point(923, 194);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(216, 42);
            this.btnAgregarLote.TabIndex = 9;
            this.btnAgregarLote.Text = "+ Nuevo Lote";
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(923, 265);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 42);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar Lote";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1178, 194);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(216, 42);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar  Lote";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1178, 265);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(216, 42);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar Lote";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cboTipos
            // 
            this.cboTipos.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Items.AddRange(new object[] {
            "Todos los tipos",
            "Entero",
            "Cola",
            "Procesado",
            "Procesado Certificado"});
            this.cboTipos.Location = new System.Drawing.Point(1113, 131);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(253, 32);
            this.cboTipos.TabIndex = 13;
            // 
            // borde
            // 
            this.borde.BackColor = System.Drawing.Color.Black;
            this.borde.Location = new System.Drawing.Point(34, 74);
            this.borde.Name = "borde";
            this.borde.Size = new System.Drawing.Size(1300, 2);
            this.borde.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(969, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Informacion";
            // 
            // txtInfoLote
            // 
            this.txtInfoLote.Location = new System.Drawing.Point(905, 492);
            this.txtInfoLote.Multiline = true;
            this.txtInfoLote.Name = "txtInfoLote";
            this.txtInfoLote.Size = new System.Drawing.Size(523, 240);
            this.txtInfoLote.TabIndex = 17;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1461, 786);
            this.Controls.Add(this.txtInfoLote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.borde);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarLote);
            this.Controls.Add(this.txtLiquidacionTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgLotes);
            this.Controls.Add(this.label2);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema Camaronera";
            ((System.ComponentModel.ISupportInitialize)(this.dvgLotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgLotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLotes;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLiquidacionTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarLote;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label borde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfoLote;
    }
}

