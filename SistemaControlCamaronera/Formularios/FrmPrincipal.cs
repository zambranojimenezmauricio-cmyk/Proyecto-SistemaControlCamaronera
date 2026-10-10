using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaControlCamaronera {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
            CenterToScreen();
            configurarTabla();
            borde.Width = 1400;
        }


        private void configurarTabla() {
            dvgLotes.BorderStyle = BorderStyle.None;
            dvgLotes.Columns.Add("Codigo", "Codigo");
            dvgLotes.Columns.Add("Piscina", "Piscina");
            dvgLotes.Columns.Add("Categoria", "Categoria");
            dvgLotes.Columns.Add("Peso", "Peso");
            dvgLotes.Columns.Add("Gramaje", "Gramaje");
            dvgLotes.Columns.Add("Condicion", "Condicion");
            dvgLotes.Columns.Add("Bono", "Bono");
            dvgLotes.Columns.Add("Total", "Total");

        }
    }
}
