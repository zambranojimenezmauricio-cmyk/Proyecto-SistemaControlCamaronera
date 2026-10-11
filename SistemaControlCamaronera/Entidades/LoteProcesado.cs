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

        // Implementamos el metodo abstracto CalcularLiquidacion, que retorna el valor de la liquidacion del lote procesado, que es igual al peso en libras multiplicado por el precio base, mas el costo de proceso (peso en libras multiplicado por la tarifa de proceso), mas el bono de gramaje
        public override decimal CalcularLiquidacion {
            get {
                double costoProcesado = PesoLibras * (tarifaProceso / 100);
                return ((decimal)PesoLibras * (decimal)PrecioBase) + (decimal)costoProcesado + BonoGramaje();
            }
        }

        public override string Imprimir() {
            return base.Imprimir() + $"Tarifa Proceso: {tarifaProceso}";
        }
    }
}
