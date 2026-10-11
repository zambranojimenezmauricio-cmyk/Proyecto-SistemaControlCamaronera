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

            var consulta = listaLotes.Where(l => l.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)).Sum(l => l.CalcularLiquidacion);

            return consulta;
        }

        // Consulta para obtener la recaudacion total de todos los lotes por tipo, usando LINQ con query syntax
        public static decimal RecaudacionPorTipoL(string tipo) {
            var consulta = from l in listaLotes
                           where l.Tipo.Equals(tipo, StringComparison.OrdinalIgnoreCase)
                           select l.CalcularLiquidacion;

            return consulta.Sum();
        }


        //  Consulta para tomar el resumen de los lotes agrupados por tipo, con la cantidad de lotes, peso total, promedio de gramaje y total liquidado
        public IEnumerable<ConsolidadoPorTipo> ConsolidadoPorTipo() {

            // usamos groupBy para agrupar los lotes por tipo, y luego usamos select para proyectar cada grupo en un objeto ConsolidadoPorTipo
            var consulta = listaLotes.GroupBy(l => l.Tipo).Select(
                group => new ConsolidadoPorTipo { // se instancia un objeto ConsolidadoPorTipo por cada grupo de lotes, y se asignan las propiedades del objeto con los valores calculados.
                    Tipo = group.Key,
                    Cantidad = group.Count(),
                    PesoTotal = group.Sum(l => l.PesoLibras),
                    PromedioGramaje = group.Average(l => l.GramajePromedio),
                    TotalLiquidado  = group.Sum(l => l.CalcularLiquidacion)

                });
            
            return consulta;
        }

        // Consulta para obtener los lotes que tienen bono de gramaje mayor o igual a 20
        public IEnumerable<LoteCamaron> LotesConBono() {
            var consulta = listaLotes.Where(l => l.BonoGramaje() >= 20);
            return consulta;
        }

        // usamos OrderByDescending para ordenar de mayor a menor y take(3) para tomar los primeros 3 mejores lotes rentables
        public IEnumerable<LoteCamaron> MejoresTresRentables() {
            var consulta = listaLotes.OrderByDescending(l => l.CalcularLiquidacion).Take(3);
            return consulta;
        }
    }

}
