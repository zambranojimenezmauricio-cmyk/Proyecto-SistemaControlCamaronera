using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControlCamaronera.Entidades; // importo la clase abstracta LoteCamaron, ConsolidadoPorTipo


namespace SistemaControlCamaronera.Controladores {
    public class TListaLote {
        public static List<LoteCamaron> listaLotes = new List<LoteCamaron>();

        public static int VerificarLote(string codigo, int pos) {
            
            for (int i = 0; i < listaLotes.Count; i++) {
                if(i != pos && listaLotes[i].CodigoLote.Equals(codigo, StringComparison.OrdinalIgnoreCase)) {
                    return i; // si encuentra duplicado, retorna la posición 
                }
            }

            return -1; // si no encuentra duplicado, retorna -1
            
        }

        //  Operaciones CRUD

        public static void Insertar(LoteCamaron lote) {
            listaLotes.Add(lote);
        }

        public static void Modificar(int pos, LoteCamaron lote) {
            listaLotes[pos] = lote; // remplaza el lote en la posicion especifica
        }

        public static void Eliminar(int pos) {
            listaLotes.RemoveAt(pos);
        }

        // Consultas Analiticas

        public static decimal RecaudacionTotal() {
            decimal sum  = listaLotes.Sum(lote => lote.CalcularLiquidacion); // almacena la suma de todas las liquidaciones
            return sum;
        }

        // Consulta sin LINQ

        public static decimal RecaudacionPorTipo(string tipo) {
            decimal sum = 0.0m;

            foreach(LoteCamaron l in listaLotes) {
                if(l.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)) {
                    sum = sum + l.CalcularLiquidacion;
                }
            }

            return sum;
        }

        // Consulta con LINQ
        public static decimal RecaudacionPorTipoLINQ(string tipo) {

            var consulta = listaLotes.Where(l => l.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)).Sum(l => l.CalcularLiquidacion);

            return consulta;
        }

        public  static decimal RecaudacionPorTipoL(string tipo) {
            var consulta = from l in listaLotes
                           where l.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)
                           select l.CalcularLiquidacion;

            return consulta.Sum();
        }

        public IEnumerable<ConsolidadoPorTipo> ConsolidadoPorTipo() {
            var consulta = listaLotes.GroupBy(l => l.Tipo).Select(
                group => new ConsolidadoPorTipo {
                    Tipo = group.Key,
                    Cantidad = group.Count(),
                    PesoTotal = group.Sum(l => l.PesoLibras),
                    PromedioGramaje = group.Average(l => l.GramajePromedio),
                    TotalLiquidado  = group.Sum(l => l.CalcularLiquidacion)

                });
            
            return consulta;
        }

        public IEnumerable<LoteCamaron> LotesConBono() {
            var consulta = listaLotes.Where(l => l.BonoGramaje() >= 20);
            return consulta;
        }
    }

}
