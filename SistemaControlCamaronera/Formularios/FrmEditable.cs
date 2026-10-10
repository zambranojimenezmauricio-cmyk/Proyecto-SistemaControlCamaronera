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

        }

        private void lblPiscina_Click(object sender, EventArgs e) {

        }

        private void txtPiscina_TextChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void txtGramajePromedio_TextChanged(object sender, EventArgs e) {

        }

        private void lblTipo1_Click(object sender, EventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }
    }
}
