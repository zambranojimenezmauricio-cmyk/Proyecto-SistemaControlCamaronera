using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public abstract class LoteCamaron {
        private String codigoLote;
        private String piscina;

        private double pesoLibras;

        private double gramajePromedio;

        private decimal precioBase;

        private String tipo;

        protected LoteCamaron(string codigoLote, string piscina, double pesoLibras, double gramajePromedio, decimal precioBase, string tipo) {
            this.codigoLote = codigoLote;
            this.piscina = piscina;
            this.pesoLibras = pesoLibras;
            this.gramajePromedio = gramajePromedio;
            this.precioBase = precioBase;
            this.tipo = tipo;
        }

        public string CodigoLote { get => codigoLote; set => codigoLote = value; }
        public string Piscina { get => piscina; set => piscina = value; }
        public double PesoLibras { get => pesoLibras; set => pesoLibras = value; }
        public double GramajePromedio { get => gramajePromedio; set => gramajePromedio = value; }
        public decimal PrecioBase { get => precioBase; set => precioBase = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        // creamos el metodo abstracto pedido por la clase padre y su getter
        public abstract Decimal CalcularLiquidacion { get; }

        // creamos el metodo BonoGramaje, que retorna un bono de 150.00 si el gramaje promedio es mayor o igual a 20.0, sino retorna 0.00
        public decimal BonoGramaje() {

            if (gramajePromedio >= 20.0) {
                return 150.00m;
            }
            else {
                return 0.00m;
            }
        }

        // metodo para imprimir los datos del lote de camaron, que retorna un string con los datos del lote
        public virtual String Imprimir() {
            return $"Codigo Lote: {CodigoLote} {Environment.NewLine} " +
                $"Piscina: {Piscina} {Environment.NewLine} " +
                $"Peso (libras): {PesoLibras} {Environment.NewLine} " +
                $"Gramaje Promedio: {GramajePromedio} {Environment.NewLine} " +
                $"Precio Base: {PrecioBase} {Environment.NewLine} " +
                $"Tipo: {Tipo} {Environment.NewLine}";
        }
    }
}
