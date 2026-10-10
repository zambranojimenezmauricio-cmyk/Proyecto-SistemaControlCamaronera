using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public class LoteProcesado_Certificado : LoteProcesado {
        private string codigoCertificado;

        public LoteProcesado_Certificado(string codigoCertificado, double tarifaProceso, string codigoLote, string piscina, double pesoLibras, double gramajePromedio, decimal precioBase, string tipo) : base(tarifaProceso, codigoLote, piscina, pesoLibras, gramajePromedio, precioBase, tipo)  {

            this.codigoCertificado = codigoCertificado;
        }

        public string CodigoCertificado { get => codigoCertificado; set => codigoCertificado = value; }

        public override decimal CalcularLiquidacion {
            get {
                decimal subtotalBase = (decimal)base.CalcularLiquidacion;
                return subtotalBase + (subtotalBase * 0.15m);

            }
        }

        public override string Imprimir() {
            return base.Imprimir() + $"Codigo Certificado: {CodigoCertificado}";
        }
    }
}
