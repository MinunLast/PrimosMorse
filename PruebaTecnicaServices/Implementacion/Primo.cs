using PruebaTecnicaServices.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaServices.Implementacion
{
    /// <summary>
    /// CONTIENE EL METODO PARA CALCULAR LOS NUMEROS PRIMOS DEL 1 AL 100 Y EL DE VERIFICAR SI EL NUMERO PASADO POR PARAMETRO ES PRIMO O NO
    /// </summary>
    public class Primo : IPrimo
    {
        /// <summary>
        /// Calcula los numeros primos del 1 al 100
        /// </summary>
        /// <returns></returns>
        public List<int> CalcularNumerosPrimos()
        {
            List<int> numerosPrimos = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (EsPrimo(i))
                {
                    numerosPrimos.Add(i);
                }
            }
            return numerosPrimos;
        }
        /// <summary>
        /// VERIFICA SI ES PRIMO O NO EL NUMERO PASADO POR PARAMETRO
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;
            if (numero == 2 || numero == 3)
                return true;
            if (numero % 2 == 0)
                return false;
            for (int i = 3; i * i <= numero; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }
            return true;
        }
    }
}
