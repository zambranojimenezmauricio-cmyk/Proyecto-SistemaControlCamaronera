using SistemaControlCamaronera.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlCamaronera.Formularios {
    public partial class FrmEditable : Form {
        
        public FrmEditable() {
            InitializeComponent();
            CenterToScreen();
            cboTipos.DropDownStyle = ComboBoxStyle.DropDownList; // evita escribir dentro del comoBox
            txtBonoEstado.ReadOnly = true;
            txtPenalizacion.ReadOnly = true;
            txtPrevisualizacionTotal.ReadOnly = true;

            txtBonoEstado.BackColor = Color.White;
            txtPenalizacion.BackColor = Color.White;
            txtPrevisualizacionTotal.BackColor = Color.White;
            lblParametro1.Text = "";
            lblParametro2.Text = "";
            txtParametro1.Enabled = false;
            txtParametro2.Enabled = false;
        }

        public LoteCamaron CrearObjeto() {
            try {
                String codigo = "L" + txtCodigo.Text;
                String piscina = txtPiscina.Text;
                double pesoLibras = double.Parse(txtPeso.Text);
                decimal precioBase = decimal.Parse(txtPrecioBase.Text);
                double gramajePromedio = double.Parse(txtGramajePromedio.Text);


                LoteCamaron cosecha = null;

                if (cboTipos.SelectedItem.ToString().Equals("Entero", StringComparison.OrdinalIgnoreCase)) {
                    double defectoCabeza = double.Parse(txtParametro1.Text);
                    cosecha = new LoteEntero(defectoCabeza, codigo, piscina, pesoLibras, gramajePromedio, precioBase, "Entero");
                }
                else if (cboTipos.SelectedItem.ToString().Equals("Cola", StringComparison.OrdinalIgnoreCase)) {
                    double factorRendimiento = double.Parse(txtParametro1.Text);
                    cosecha = new LoteCola(factorRendimiento, codigo, piscina, pesoLibras, gramajePromedio, precioBase, "Cola");
                }
                else if (cboTipos.SelectedItem.ToString().Equals("Procesado", StringComparison.OrdinalIgnoreCase)) {
                    double tarifaProceso = double.Parse(txtParametro1.Text);
                    cosecha = new LoteProcesado(tarifaProceso, codigo, piscina, pesoLibras, gramajePromedio, precioBase, "Procesado");

                }
                else if (cboTipos.SelectedItem.ToString().Equals("Procesado_Certificado", StringComparison.OrdinalIgnoreCase)) {
                    String codigoCertificado = txtParametro1.Text;
                    double tarifaProceso = double.Parse(txtParametro2.Text);
                    cosecha = new LoteProcesado_Certificado(codigoCertificado, tarifaProceso, codigo, piscina, pesoLibras, gramajePromedio, precioBase, "Procesado_Certificado");
                }

                return cosecha;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al crear el objeto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Actualiza la previsualización de los resultados en los TextBox correspondientes
        private void ActualizarPreview() {
            LoteCamaron cosecha = CrearObjeto();

            if(cosecha  != null) {
                txtBonoEstado.Text = cosecha.BonoGramaje().ToString();
                txtPrevisualizacionTotal.Text = cosecha.CalcularLiquidacion.ToString();
            }

        }


        private void label11_Click(object sender, EventArgs e) {

        }

        private void cboTipos_SelectedIndexChanged(object sender, EventArgs e) {

            if (cboTipos.SelectedItem.ToString().Equals("Entero", StringComparison.OrdinalIgnoreCase)) {
                lblParametro1.Text = "Defecto de Cabeza";
                txtParametro1.Enabled = true;
                apagarParametro2();
            }
            else if (cboTipos.SelectedItem.ToString().Equals("Cola", StringComparison.OrdinalIgnoreCase)) {
                lblParametro1.Text = "Factor de Rendimiento";
                txtParametro1.Enabled = true;
                apagarParametro2();
            }
            else if (cboTipos.SelectedItem.ToString().Equals("Procesado", StringComparison.OrdinalIgnoreCase)) {
                lblParametro1.Text = "Tarifa de Proceso";
                txtParametro1.Enabled = true;
                apagarParametro2();
            }
            else if (cboTipos.SelectedItem.ToString().Equals("Procesado_Certificado", StringComparison.OrdinalIgnoreCase)) {
                lblParametro1.Text = "Codigo Certificado";
                txtParametro1.Enabled = true;
                lblParametro2.Text = "Tarifa Proceso";
                txtParametro2.Enabled = true;
            }
        }

        private void apagarParametro2() {
            lblParametro2.Text = "";
            txtParametro2.Enabled = false;
        }

        private void lblParametro2_Click(object sender, EventArgs e) {

        }
    }
}
