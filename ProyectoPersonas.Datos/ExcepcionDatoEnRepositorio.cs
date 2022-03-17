using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonas.Datos
{
    public class ExcepcionDatoEnRepositorio : Exception
    {
        //ATRIBUTOS

        string mensaje;

        //CONSTRUCTOR
        public ExcepcionDatoEnRepositorio(string mensaje)
        {
            this.mensaje = mensaje;
        }

        //METODOS

        //METODOS PUBLICOS
        public string mostrarError()
        {
            return mensaje;
        }
    }
}
