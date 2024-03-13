using PruebaTecnicaServices.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaServices.Implementacion
{
    /// <summary>
    /// CONTIENE LOS METODOS PARA CODIFICAR Y DECODIFICAR TEXTO EN MORSE Y ESCRITURA CONVENCIONAL
    /// </summary>
    public class Morse : IMorse
    {
        /// <summary>
        /// DECODIFICA EL TEXTO PASADO DE MORSE A TEXTO CONVENCIONAL
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public string DecodificarMorse(string texto)
        {
            Dictionary<string, char> morseDict = new Dictionary<string, char>()
    {
        {".-", 'A'},
        {"-...", 'B'},
        {"-.-.", 'C'},
        {"-..", 'D'},
        {".", 'E'},
        {"..-.", 'F'},
        {"--.", 'G'},
        {"....", 'H'},
        {"..", 'I'},
        {".---", 'J'},
        {"-.-", 'K'},
        {".-..", 'L'},
        {"--", 'M'},
        {"-.", 'N'},
        {"---", 'O'},
        {".--.", 'P'},
        {"--.-", 'Q'},
        {".-.", 'R'},
        {"...", 'S'},
        {"-", 'T'},
        {"..-", 'U'},
        {"...-", 'V'},
        {".--", 'W'},
        {"-..-", 'X'},
        {"-.--", 'Y'},
        {"--..", 'Z'},
        {"-----", '0'},
        {".----", '1'},
        {"..---", '2'},
        {"...--", '3'},
        {"....-", '4'},
        {".....", '5'},
        {"-....", '6'},
        {"--...", '7'},
        {"---..", '8'},
        {"----.", '9'},
        {".-.-.-", '.'},
        {"--..--", ','},
        {"..--..", '?'},
        {"-..-.", '/'},
        {"-....-", '-'}
    };

            string[] palabrasMorse = texto.Split(new[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palabrasDecodificadas = new List<string>();

            foreach (string palabraMorse in palabrasMorse)
            {
                palabrasDecodificadas.Add(DecodificarPalabraMorse(palabraMorse, morseDict));
            }
            return string.Join(" ", palabrasDecodificadas);
        }
        /// <summary>
        /// CODIFICA CADA PALABRA QUE SE LE PASA POR PARAMETRO Y EL DICCIONARIO PARA DECODIFICAR
        /// </summary>
        /// <param name="palabraMorse"></param>
        /// <param name="morseDict"></param>
        /// <returns></returns>
        private string DecodificarPalabraMorse(string palabraMorse, Dictionary<string, char> morseDict)
        {
            string[] letrasMorse = palabraMorse.Split(' ');
            StringBuilder palabraDecodificada = new StringBuilder();

            foreach (string letraMorse in letrasMorse)
            {
                if (morseDict.TryGetValue(letraMorse, out char caracterDecodificado))
                {
                    palabraDecodificada.Append(caracterDecodificado);
                }
            }
            return palabraDecodificada.ToString();
        }
        /// <summary>
        /// CODIFICAR EL TEXTO PASADO DE ESCRITURA CONVENCIONAL A MORSE
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public string CodificarAMorse(string texto)
        {
            Dictionary<char, string> morseDictado = new Dictionary<char, string>()
    {
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."},
        {'0', "-----"},
        {'1', ".----"},
        {'2', "..---"},
        {'3', "...--"},
        {'4', "....-"},
        {'5', "....."},
        {'6', "-...."},
        {'7', "--..."},
        {'8', "---.."},
        {'9', "----."},
        {'.', ".-.-.-"},
        {',', "--..--"},
        {'?', "..--.."},
        {'/', "-..-."},
        {'-', "-....-"}
    };

            texto = texto.ToUpper();
            StringBuilder codigoMorseBuilder = new StringBuilder();

            foreach (char caracter in texto)
            {
                if (morseDictado.ContainsKey(caracter))
                {
                    codigoMorseBuilder.Append(morseDictado[caracter] + " ");
                }
                else
                {
                    codigoMorseBuilder.Append(" ");
                }
            }

            return codigoMorseBuilder.ToString().Trim();
        }

    }
}
