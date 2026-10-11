using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControlCamaronera.Entidades; // importo la clase abstracta LoteCamaron, ConsolidadoPorTipo


namespace SistemaControlCamaronera.Controladores {
    public class TListaLote {
        // Lista de lotes de camaron, se inicializa como una lista vacia
        public static List<LoteCamaron> listaLotes = new List<LoteCamaron>();

        // Verifica si el codigo del lote ya existe en la lista, si es asi retorna la posicion del lote duplicado, sino retorna -1
        public static int VerificarLote(string codigo, int pos) {
            
            for (int i = 0; i < listaLotes.Count; i++) {
                if(i != pos && listaLotes[i].CodigoLote.Equals(codigo, StringComparison.OrdinalIgnoreCase)) {
                    return i; // si encuentra duplicado, retorna la posición 
                }
            }

            return -1; // si no encuentra duplicado, retorna -1
            
        }

        //  Operaciones CRUD

        // Inserta un lote en la lista
        public static void Insertar(LoteCamaron lote) {
            listaLotes.Add(lote);
        }

        // Modifica un lote en la lista, remplazando el lote en la posicion especifica
        public static void Modificar(int pos, LoteCamaron lote) {
            listaLotes[pos] = lote; // remplaza el lote en la posicion especifica
        }

        // Elimina un lote de la lista en la posicion especifica
        public static void Eliminar(int pos) {
            listaLotes.RemoveAt(pos);
        }

        // Consultas Analiticas

        // Consulta con LINQ para obtener la recaudacion total de todos los lotes
        public static decimal RecaudacionTotal() {
            decimal sum  = listaLotes.Sum(lote => lote.CalcularLiquidacion); // almacena la suma de todas las liquidaciones
            return sum;
        }

        // Consulta sin LINQ

        // Consulta para obtener la recaudacion total de todos los lotes por tipo, sin usar LINQ
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

        // Consulta para obtener la recaudacion total de todos los lotes por tipo, usando LINQ
        public static decimal RecaudacionPorTipoLINQ(string tipo) {

            var consulta = listaLotes.Where(c => c.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)).Sum(c => c.CalcularLiquidacion);

            return consulta;
        }

        // Consulta para obtener la recaudacion total de todos los lotes por tipo, usando LINQ con query syntax
        public static decimal RecaudacionPorTipoLQuery(string tipo) {
            var consulta = from c in listaLotes
                           where c.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)
                           select c.CalcularLiquidacion;

            return consulta.Sum();
        }


        //  Consulta para tomar el resumen de los lotes agrupados por tipo, con la cantidad de lotes, peso total, promedio de gramaje y total liquidado
        public IEnumerable<ConsolidadoPorTipo> ConsolidadoPorTipo() {

            // usamos groupBy para agrupar los lotes por tipo, y luego usamos select para proyectar cada grupo en un objeto ConsolidadoPorTipo
            var consulta = listaLotes.GroupBy(c => c.Tipo).Select(
                group => new ConsolidadoPorTipo { // se instancia un objeto ConsolidadoPorTipo por cada grupo de lotes, y se asignan las propiedades del objeto con los valores calculados.
                    Tipo = group.Key,
                    Cantidad = group.Count(),
                    PesoTotal = group.Sum(c => c.PesoLibras),
                    PromedioGramaje = group.Average(c => c.GramajePromedio),
                    TotalLiquidado  = group.Sum(c => c.CalcularLiquidacion)

                });
            
            return consulta;
        }

        // Consulta para obtener los lotes que tienen bono de gramaje mayor o igual a 20
        public IEnumerable<LoteCamaron> LotesConBono() {
            var consulta = listaLotes.Where(c => c.BonoGramaje() >= 20);
            return consulta;
        }

        // OrderByDescending: Mayor A Menor
        // OrderBy: Menor A Mayor
        // Take: Toma los primeros n elementos de la lista

        // usamos OrderByDescending para ordenar de mayor a menor y take(3) para tomar los primeros 3 mejores lotes rentableses wher
        public IEnumerable<LoteCamaron> Top3Rentables() {
            // take(3) toma los primeros 3 elementos de la lista Ordenada despues de OrderByDescending
            var consulta = listaLotes.OrderByDescending(l => l.CalcularLiquidacion).Take(3);
            return consulta;
        }

        // Consulta para obtener los lotes que tienen defecto de cabeza mayor a 3.0, usando OfType para filtrar solo los lotes de tipo LoteEntero
        public IEnumerable<LoteCamaron> LotesPenalizados() {
            var consulta = listaLotes.OfType<LoteEntero>().Where(c => c.DefectoCabeza > 3.0);
            return consulta;
        }

        // Consulta para obtener el lote con mayor liquidacion
        public LoteCamaron ObtenerMejorLote() {
            var consulta = listaLotes.OrderByDescending(c => c.CalcularLiquidacion).FirstOrDefault(); // obtenemos el lote con mayor liquidacion
            return consulta;
        }
    }

}
