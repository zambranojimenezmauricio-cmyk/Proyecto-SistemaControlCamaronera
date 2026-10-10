using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaControlCamaronera.Entidades; // importo la clase abstracta LoteCamaron

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

        public static void Insertar(LoteCamaron lote) {
            listaLotes.Add(lote);
        }

        public static void Modificar(int pos, LoteCamaron lote) {
            listaLotes[pos] = lote; // remplaza el lote en la posicion especifica
        }

        public static void Eliminar(int pos) {
            listaLotes.RemoveAt(pos);
        }
    }
}
