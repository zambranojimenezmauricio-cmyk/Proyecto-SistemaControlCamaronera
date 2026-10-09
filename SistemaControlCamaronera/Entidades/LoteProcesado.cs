using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public class LoteProcesado : LoteCamaron {
        private double tarifaProceso;

        public LoteProcesado(double tarifaProceso, string codigoLote, string piscina, double pesoLibras, double gramajePromedio, decimal precioBase, string tipo) : base(codigoLote, piscina, pesoLibras, gramajePromedio, precioBase, tipo) {
            this.tarifaProceso = tarifaProceso;
        }

        public double TarifaProceso { 
            get => tarifaProceso; 
            set => tarifaProceso = value; 
        }

        public override decimal CalcularLiquidacion() {
            return 0;
        }

        public override string Imprimir() {
            return base.Imprimir() + $"Tarifa Proceso: {tarifaProceso}";
        }
    }
}
