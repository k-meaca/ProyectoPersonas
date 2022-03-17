using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoPersonas.Entidades;

namespace ProyectoPersonas.Datos
{
    public class RepositorioPersona
    {
        //ATRIBUTOS

        private List<Persona> personasAlmacenadas;
        private ManejadorDeArchivos manejadorArchivos;
        private static RepositorioPersona _instancia = null;

        //CONSTRUCTOR

        private RepositorioPersona()
        {
            manejadorArchivos = new ManejadorDeArchivos();
            personasAlmacenadas = manejadorArchivos.leerArchivo();
        }

        //METODOS

        //METODOS PUBLICOS

        public void agregarPersona(Persona persona)
        {
            if (!existePersona(persona))
            {
                manejadorArchivos.agregarPersona(persona);
                personasAlmacenadas.Add(persona);
            }
            else
            {
                throw new ExcepcionDatoEnRepositorio("No es posible agregar el persona. Ya esta en el repositorio.");
            }
        }

        public void editarPersona(Persona personaViejo, Persona personaEditado)
        {

            int indice = personasAlmacenadas.IndexOf(personaViejo);
            personasAlmacenadas.RemoveAt(indice);
            personasAlmacenadas.Add(personaEditado);
            manejadorArchivos.editarPersona(personaViejo, personaEditado);
            
        }

        public void eliminarPersona(Persona persona)
        {
            manejadorArchivos.eliminarPersona(persona);
            personasAlmacenadas.Remove(persona);
        }

        public List<Persona> filtrarPorSexo(Sexo sexo)
        {
            return personasAlmacenadas.Where(persona => persona.obtenerSexo() == sexo).ToList();
        }

        public List<Persona> filtrarPorLocalidad(Localidad localidad)
        {
            return personasAlmacenadas.Where(persona => persona.obtenerLocalidad() == localidad).ToList();
        }

        public int obtenerCantidadPersonas()
        {
            return personasAlmacenadas.Count;
        }

        public static RepositorioPersona obtenerInstancia()
        {
            if (_instancia == null)
                _instancia = new RepositorioPersona();

            return _instancia;
        }

        public List<Persona> obtenerPersonasPorIngreso()
        {
            return personasAlmacenadas;
        }

        public List<Persona> ordenarAscendentePorEdad()
        {
            return personasAlmacenadas.OrderBy(persona => persona.obtenerEdad()).ToList();
        }

        public List<Persona> ordenarDescendentePorEdad()
        {
            return personasAlmacenadas.OrderByDescending(persona => persona.obtenerEdad()).ToList();
        }

        public List<Persona> ordenarAscendentePorApellido()
        {
            return personasAlmacenadas.OrderBy(persona => persona.obtenerApellido()).ToList();
        }

        public List<Persona> ordenarDescendentePorApellido()
        {
            return personasAlmacenadas.OrderByDescending(persona => persona.obtenerApellido()).ToList();
        }

        //METODOS PRIVADOS

        private bool existePersona(Persona persona)
        {
            return personasAlmacenadas.Contains(persona);
        }
    }
}
