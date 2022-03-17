using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonas.Utilidades
{
    public class Verificador
    {
        public bool soloLetras(char caracter) 
        {
            return (char.IsLetter(caracter) && (caracter != 'º' && caracter != 'ç') ) || char.IsControl(caracter) || char.IsWhiteSpace(caracter);
        }

        public bool soloNumeros(char caracter) 
        {
            return char.IsDigit(caracter) || char.IsControl(caracter);
        }

        public bool longitudCorrecta(string dato, int longitud) 
        {
            return dato.Length == longitud;
        }

    }
}
