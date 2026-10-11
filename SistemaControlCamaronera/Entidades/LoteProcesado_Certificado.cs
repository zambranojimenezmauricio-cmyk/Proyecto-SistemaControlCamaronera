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

        // Implementamos la propiedad CodigoCertificado, que retorna el codigo del certificado del lote procesado certificado
        public string CodigoCertificado { get => codigoCertificado; set => codigoCertificado = value; }

        // Implementamos el metodo abstracto CalcularLiquidacion, que retorna el valor de la liquidacion del lote procesado certificado, que es igual al valor de la liquidacion del lote procesado mas un 15% adicional
        public override decimal CalcularLiquidacion {
            get {
                decimal subtotalBase = (decimal)base.CalcularLiquidacion;
                return subtotalBase + (subtotalBase * 0.15m);

            }
        }

        // Implementamos el metodo Imprimir, que retorna un string con los datos del lote procesado certificado, incluyendo el codigo del certificado
        public override string Imprimir() {
            return base.Imprimir() + $"Codigo Certificado: {CodigoCertificado}";
        }
    }
}
