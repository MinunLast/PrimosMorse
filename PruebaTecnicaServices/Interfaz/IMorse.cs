using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaServices.Interfaz
{
    /// <summary>
    /// INTERFAZ DE MORSE
    /// </summary>
    public interface IMorse
    {
        string DecodificarMorse(string texto);
        string CodificarAMorse(string texto);
    }
}
