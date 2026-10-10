namespace SistemaControlCamaronera.Formularios {
    partial class FrmEstadistica {
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
            this.borde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsolidadoTipo = new System.Windows.Forms.Button();
            this.btnLotesConBono = new System.Windows.Forms.Button();
            this.btnLotesMasRentables = new System.Windows.Forms.Button();
            this.btnLotesPenalizados = new System.Windows.Forms.Button();
            this.gpBotones = new System.Windows.Forms.GroupBox();
            this.txtRegistros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalConsulta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMejorLote = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.gbResumenGlobal = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gpBotones.SuspendLayout();
            this.gbResumenGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // borde
            // 
            this.borde.BackColor = System.Drawing.Color.Black;
            this.borde.Location = new System.Drawing.Point(56, 92);
            this.borde.Name = "borde";
            this.borde.Size = new System.Drawing.Size(1350, 2);
            this.borde.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Analisis y Estadisticas De Cosechas";
            // 
            // dgvResultados
            // 
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(534, 165);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.RowHeadersWidth = 47;
            this.dgvResultados.Size = new System.Drawing.Size(522, 555);
            this.dgvResultados.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "[ Resultado De La Consulta ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "[ Seleccione Un Analisis ]";
            // 
            // btnConsolidadoTipo
            // 
            this.btnConsolidadoTipo.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsolidadoTipo.Location = new System.Drawing.Point(86, 135);
            this.btnConsolidadoTipo.Name = "btnConsolidadoTipo";
            this.btnConsolidadoTipo.Size = new System.Drawing.Size(263, 42);
            this.btnConsolidadoTipo.TabIndex = 41;
            this.btnConsolidadoTipo.Text = "Consolidado Por Tipo";
            this.btnConsolidadoTipo.UseVisualStyleBackColor = true;
            // 
            // btnLotesConBono
            // 
            this.btnLotesConBono.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesConBono.Location = new System.Drawing.Point(86, 210);
            this.btnLotesConBono.Name = "btnLotesConBono";
            this.btnLotesConBono.Size = new System.Drawing.Size(263, 42);
            this.btnLotesConBono.TabIndex = 42;
            this.btnLotesConBono.Text = "Lotes Con Bono ";
            this.btnLotesConBono.UseVisualStyleBackColor = true;
            // 
            // btnLotesMasRentables
            // 
            this.btnLotesMasRentables.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesMasRentables.Location = new System.Drawing.Point(86, 291);
            this.btnLotesMasRentables.Name = "btnLotesMasRentables";
            this.btnLotesMasRentables.Size = new System.Drawing.Size(263, 42);
            this.btnLotesMasRentables.TabIndex = 43;
            this.btnLotesMasRentables.Text = "Top 3 Lotes Mas Rentables";
            this.btnLotesMasRentables.UseVisualStyleBackColor = true;
            // 
            // btnLotesPenalizados
            // 
            this.btnLotesPenalizados.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesPenalizados.Location = new System.Drawing.Point(86, 364);
            this.btnLotesPenalizados.Name = "btnLotesPenalizados";
            this.btnLotesPenalizados.Size = new System.Drawing.Size(263, 42);
            this.btnLotesPenalizados.TabIndex = 44;
            this.btnLotesPenalizados.Text = "Lotes Penalizados";
            this.btnLotesPenalizados.UseVisualStyleBackColor = true;
            // 
            // gpBotones
            // 
            this.gpBotones.Controls.Add(this.btnLotesPenalizados);
            this.gpBotones.Controls.Add(this.btnLotesMasRentables);
            this.gpBotones.Controls.Add(this.btnLotesConBono);
            this.gpBotones.Controls.Add(this.btnConsolidadoTipo);
            this.gpBotones.Controls.Add(this.label4);
            this.gpBotones.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBotones.Location = new System.Drawing.Point(59, 120);
            this.gpBotones.Name = "gpBotones";
            this.gpBotones.Size = new System.Drawing.Size(444, 463);
            this.gpBotones.TabIndex = 45;
            this.gpBotones.TabStop = false;
            this.gpBotones.Text = "[ Consultas Disponibles ]";
            // 
            // txtRegistros
            // 
            this.txtRegistros.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistros.Location = new System.Drawing.Point(128, 126);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(87, 28);
            this.txtRegistros.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Total Lotes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Libras Cosechadas:";
            // 
            // txtTotalConsulta
            // 
            this.txtTotalConsulta.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalConsulta.Location = new System.Drawing.Point(63, 233);
            this.txtTotalConsulta.Name = "txtTotalConsulta";
            this.txtTotalConsulta.Size = new System.Drawing.Size(223, 28);
            this.txtTotalConsulta.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Facturacion Total:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(63, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 28);
            this.textBox1.TabIndex = 50;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(59, 704);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(138, 49);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "[ Resumen Global ]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 405);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 28);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mejor Rendimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(82, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "Lote:";
            // 
            // txtMejorLote
            // 
            this.txtMejorLote.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMejorLote.Location = new System.Drawing.Point(160, 469);
            this.txtMejorLote.Name = "txtMejorLote";
            this.txtMejorLote.Size = new System.Drawing.Size(87, 28);
            this.txtMejorLote.TabIndex = 54;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(70, 527);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(84, 28);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(160, 527);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(87, 28);
            this.txtTotal.TabIndex = 56;
            // 
            // gbResumenGlobal
            // 
            this.gbResumenGlobal.Controls.Add(this.lblTotal);
            this.gbResumenGlobal.Controls.Add(this.txtTotal);
            this.gbResumenGlobal.Controls.Add(this.label9);
            this.gbResumenGlobal.Controls.Add(this.txtMejorLote);
            this.gbResumenGlobal.Controls.Add(this.label8);
            this.gbResumenGlobal.Controls.Add(this.label7);
            this.gbResumenGlobal.Controls.Add(this.textBox1);
            this.gbResumenGlobal.Controls.Add(this.label6);
            this.gbResumenGlobal.Controls.Add(this.txtTotalConsulta);
            this.gbResumenGlobal.Controls.Add(this.label5);
            this.gbResumenGlobal.Controls.Add(this.txtRegistros);
            this.gbResumenGlobal.Controls.Add(this.label3);
            this.gbResumenGlobal.Location = new System.Drawing.Point(1086, 112);
            this.gbResumenGlobal.Name = "gbResumenGlobal";
            this.gbResumenGlobal.Size = new System.Drawing.Size(347, 608);
            this.gbResumenGlobal.TabIndex = 58;
            this.gbResumenGlobal.TabStop = false;
            this.gbResumenGlobal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 788);
            this.Controls.Add(this.gbResumenGlobal);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gpBotones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.borde);
            this.Controls.Add(this.label2);
            this.Name = "FrmEstadistica";
            this.Text = "FrmEstadistica";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gpBotones.ResumeLayout(false);
            this.gpBotones.PerformLayout();
            this.gbResumenGlobal.ResumeLayout(false);
            this.gbResumenGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsolidadoTipo;
        private System.Windows.Forms.Button btnLotesConBono;
        private System.Windows.Forms.Button btnLotesMasRentables;
        private System.Windows.Forms.Button btnLotesPenalizados;
        private System.Windows.Forms.GroupBox gpBotones;
        private System.Windows.Forms.TextBox txtRegistros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalConsulta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMejorLote;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox gbResumenGlobal;
    }
}