using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaServices.Interfaz
{
    /// <summary>
    /// INTERFAZ DE PRIMO
    /// </summary>
    public interface IPrimo
    {
        List<int> CalcularNumerosPrimos();
        bool EsPrimo(int numero);
    }
}
