using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public class LoteEntero : LoteCamaron {
        private double defectoCabeza;

        public LoteEntero(double defectoCabeza, string codigoLote, string piscina, double pesoLibras, double gramajePromedio, decimal precioBase, string tipo) : base(codigoLote, piscina, pesoLibras, gramajePromedio, precioBase, tipo) {
            this.defectoCabeza = defectoCabeza;
        }

        public double DefectoCabeza { get => defectoCabeza; set => defectoCabeza = value; }

        //Se calcula el precio de liquidación considerando el defecto de cabeza.

        public override decimal CalcularLiquidacion {
            get {

                //Si DefectoCabeza ≤ 3.0%, no se aplica castigo(tolerancia comercial).
                //Si DefectoCabeza > 3.0%, cada punto porcentual excedente penaliza un 5% directo sobre el precio base por libra

                if (DefectoCabeza > 3.0) {
                    double Exceso = DefectoCabeza - 3.0;
                    double Penalizacion = Exceso * 0.05 * (double)(PrecioBase);
                    double precioAjustado = Math.Max(0, (double)PrecioBase - (double)(Penalizacion));

                    return ((decimal)PesoLibras * (decimal)(precioAjustado)) + (BonoGramaje());
                }

                return ((decimal)PesoLibras * PrecioBase) + (BonoGramaje());


            }
        }

        public override string Imprimir() {
            return base.Imprimir() + $"Defecto Cabeza: {DefectoCabeza}";
        }

    }
}
