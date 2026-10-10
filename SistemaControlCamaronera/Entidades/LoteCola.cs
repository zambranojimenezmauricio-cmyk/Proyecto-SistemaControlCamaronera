using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public class LoteCola : LoteCamaron {
        private double factorRendimiento;

        public LoteCola(double factorRendimiento, string codigoLote, string piscina, double pesoLibras, double gramajePromedio, decimal precioBase, string tipo) : base(codigoLote, piscina, pesoLibras, gramajePromedio, precioBase, tipo) {
            this.factorRendimiento = factorRendimiento;
        }

        public double FactorRendimiento { 
            get => factorRendimiento; 
            set => factorRendimiento = value;
        }

        //Se calcula el peso neto útil de colas eliminando el cefalotórax.
        //La libra útil recibe un sobreprecio compensatorio del 30 % sobre el precio base:

        public override decimal CalcularLiquidacion {
            get {
                double librasCola = PesoLibras * factorRendimiento;
                double precioCola = (double)PrecioBase * 1.30; // sobreprecio del 30%
                return ((decimal)librasCola * (decimal)(precioCola)) + BonoGramaje();
            }
        }

        public override string Imprimir() {
            return base.Imprimir() + $"Factor Rendimiento: {factorRendimiento}";
        }
        
    }
}
