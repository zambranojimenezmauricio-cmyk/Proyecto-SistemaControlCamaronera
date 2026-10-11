using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControlCamaronera.Entidades {
    public class ConsolidadoPorTipo {
        
            private string tipo;
            private int cantidad;
            private double pesoTotal;

            private double promedioGramaje;
            private decimal totalLiquidado;

            public string Tipo {
                get => tipo;
                set => tipo = value;
            }

            public int Cantidad {
                get => cantidad;
                set => cantidad = value;
            }

            public double PesoTotal {
                get => pesoTotal;
                set => pesoTotal = value;
            }
            public double PromedioGramaje {
                get => promedioGramaje;
                set => promedioGramaje = value;
            }
            public decimal TotalLiquidado {
                get => totalLiquidado;
                set => totalLiquidado = value;
            }
        
    }
}
