namespace SistemaControlCamaronera.Formularios {
    partial class FrmEditable {
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtPiscina = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.txtGramajePromedio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPiscina = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBonoEstado = new System.Windows.Forms.TextBox();
            this.txtPenalizacion = new System.Windows.Forms.TextBox();
            this.txtPrevisualizacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gpTipo = new System.Windows.Forms.GroupBox();
            this.lblParametro1 = new System.Windows.Forms.Label();
            this.txtParametro1 = new System.Windows.Forms.TextBox();
            this.lblParametro2 = new System.Windows.Forms.Label();
            this.txtParametro2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarLote = new System.Windows.Forms.Button();
            this.gpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // borde
            // 
            this.borde.BackColor = System.Drawing.Color.Black;
            this.borde.Location = new System.Drawing.Point(32, 88);
            this.borde.Name = "borde";
            this.borde.Size = new System.Drawing.Size(896, 2);
            this.borde.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Edicion De Datos - Lote";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 249);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(156, 29);
            this.txtCodigo.TabIndex = 17;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(132, 310);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(156, 29);
            this.txtPeso.TabIndex = 18;
            // 
            // txtPiscina
            // 
            this.txtPiscina.Location = new System.Drawing.Point(36, 460);
            this.txtPiscina.Multiline = true;
            this.txtPiscina.Name = "txtPiscina";
            this.txtPiscina.Size = new System.Drawing.Size(252, 29);
            this.txtPiscina.TabIndex = 20;
            this.txtPiscina.TextChanged += new System.EventHandler(this.txtPiscina_TextChanged);
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(186, 367);
            this.txtPrecioBase.Multiline = true;
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(102, 29);
            this.txtPrecioBase.TabIndex = 19;
            // 
            // txtGramajePromedio
            // 
            this.txtGramajePromedio.Location = new System.Drawing.Point(35, 538);
            this.txtGramajePromedio.Multiline = true;
            this.txtGramajePromedio.Name = "txtGramajePromedio";
            this.txtGramajePromedio.Size = new System.Drawing.Size(253, 29);
            this.txtGramajePromedio.TabIndex = 21;
            this.txtGramajePromedio.TextChanged += new System.EventHandler(this.txtGramajePromedio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo Producto";
            // 
            // cboTipos
            // 
            this.cboTipos.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Items.AddRange(new object[] {
            "Entero",
            "Cola",
            "Procesado",
            "Procesado Certificado"});
            this.cboTipos.Location = new System.Drawing.Point(35, 177);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(253, 32);
            this.cboTipos.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Precio Base:";
            // 
            // lblPiscina
            // 
            this.lblPiscina.AutoSize = true;
            this.lblPiscina.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiscina.Location = new System.Drawing.Point(104, 429);
            this.lblPiscina.Name = "lblPiscina";
            this.lblPiscina.Size = new System.Drawing.Size(108, 28);
            this.lblPiscina.TabIndex = 27;
            this.lblPiscina.Text = "Piscina:";
            this.lblPiscina.Click += new System.EventHandler(this.lblPiscina_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Gramaje Promedio:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(380, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 2);
            this.label6.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(508, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Aplica Bono [ > 20]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(324, 28);
            this.label9.TabIndex = 31;
            this.label9.Text = "Penalizacion / Sobreprecio";
            // 
            // txtBonoEstado
            // 
            this.txtBonoEstado.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonoEstado.Location = new System.Drawing.Point(502, 201);
            this.txtBonoEstado.Name = "txtBonoEstado";
            this.txtBonoEstado.Size = new System.Drawing.Size(246, 32);
            this.txtBonoEstado.TabIndex = 32;
            // 
            // txtPenalizacion
            // 
            this.txtPenalizacion.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenalizacion.Location = new System.Drawing.Point(502, 333);
            this.txtPenalizacion.Name = "txtPenalizacion";
            this.txtPenalizacion.Size = new System.Drawing.Size(246, 32);
            this.txtPenalizacion.TabIndex = 33;
            // 
            // txtPrevisualizacion
            // 
            this.txtPrevisualizacion.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrevisualizacion.Location = new System.Drawing.Point(502, 520);
            this.txtPrevisualizacion.Name = "txtPrevisualizacion";
            this.txtPrevisualizacion.Size = new System.Drawing.Size(246, 32);
            this.txtPrevisualizacion.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(470, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 28);
            this.label10.TabIndex = 34;
            this.label10.Text = "Total Estimado A Liquidar:";
            // 
            // gpTipo
            // 
            this.gpTipo.Controls.Add(this.lblParametro2);
            this.gpTipo.Controls.Add(this.txtParametro2);
            this.gpTipo.Controls.Add(this.lblParametro1);
            this.gpTipo.Controls.Add(this.txtParametro1);
            this.gpTipo.Font = new System.Drawing.Font("Cascadia Code SemiBold", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTipo.Location = new System.Drawing.Point(35, 588);
            this.gpTipo.Name = "gpTipo";
            this.gpTipo.Size = new System.Drawing.Size(306, 220);
            this.gpTipo.TabIndex = 38;
            this.gpTipo.TabStop = false;
            this.gpTipo.Text = "Producto";
            // 
            // lblParametro1
            // 
            this.lblParametro1.AutoSize = true;
            this.lblParametro1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro1.Location = new System.Drawing.Point(99, 36);
            this.lblParametro1.Name = "lblParametro1";
            this.lblParametro1.Size = new System.Drawing.Size(84, 28);
            this.lblParametro1.TabIndex = 40;
            this.lblParametro1.Text = "Tipo 1";
            // 
            // txtParametro1
            // 
            this.txtParametro1.Location = new System.Drawing.Point(22, 68);
            this.txtParametro1.Multiline = true;
            this.txtParametro1.Name = "txtParametro1";
            this.txtParametro1.Size = new System.Drawing.Size(252, 29);
            this.txtParametro1.TabIndex = 39;
            // 
            // lblParametro2
            // 
            this.lblParametro2.AutoSize = true;
            this.lblParametro2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametro2.Location = new System.Drawing.Point(97, 130);
            this.lblParametro2.Name = "lblParametro2";
            this.lblParametro2.Size = new System.Drawing.Size(84, 28);
            this.lblParametro2.TabIndex = 42;
            this.lblParametro2.Text = "Tipo 2";
            // 
            // txtParametro2
            // 
            this.txtParametro2.Location = new System.Drawing.Point(22, 162);
            this.txtParametro2.Multiline = true;
            this.txtParametro2.Name = "txtParametro2";
            this.txtParametro2.Size = new System.Drawing.Size(252, 29);
            this.txtParametro2.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(375, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(500, 2);
            this.label11.TabIndex = 39;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(532, 718);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(216, 42);
            this.btnBuscar.TabIndex = 41;
            this.btnBuscar.Text = "Cancelar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarLote
            // 
            this.btnAgregarLote.Font = new System.Drawing.Font("Cascadia Code", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLote.Location = new System.Drawing.Point(532, 643);
            this.btnAgregarLote.Name = "btnAgregarLote";
            this.btnAgregarLote.Size = new System.Drawing.Size(216, 42);
            this.btnAgregarLote.TabIndex = 40;
            this.btnAgregarLote.Text = "Guardar";
            this.btnAgregarLote.UseVisualStyleBackColor = true;
            // 
            // FrmEditable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 820);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregarLote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gpTipo);
            this.Controls.Add(this.txtPrevisualizacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPenalizacion);
            this.Controls.Add(this.txtBonoEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPiscina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGramajePromedio);
            this.Controls.Add(this.txtPiscina);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.borde);
            this.Controls.Add(this.label2);
            this.Name = "FrmEditable";
            this.Text = "FrmEditable";
            this.gpTipo.ResumeLayout(false);
            this.gpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label borde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtPiscina;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.TextBox txtGramajePromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPiscina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBonoEstado;
        private System.Windows.Forms.TextBox txtPenalizacion;
        private System.Windows.Forms.TextBox txtPrevisualizacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpTipo;
        private System.Windows.Forms.Label lblParametro2;
        private System.Windows.Forms.TextBox txtParametro2;
        private System.Windows.Forms.Label lblParametro1;
        private System.Windows.Forms.TextBox txtParametro1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarLote;
    }
}