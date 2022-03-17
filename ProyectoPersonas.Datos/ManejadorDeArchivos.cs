using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProyectoPersonas.Entidades;

namespace ProyectoPersonas.Datos
{
    public class ManejadorDeArchivos
    {
        //ATRIBUTOS

        private readonly string _archivo = Environment.CurrentDirectory + @"\persona.txt";
        private readonly string _archivoBak = Environment.CurrentDirectory + @"\persona.bak";

        //METODOS

        //METODOS PUBLICOS

        public void agregarPersona(Persona persona)
        {
            string linea = construirLinea(persona);

            StreamWriter escritor = new StreamWriter(_archivo, true);

            escritor.WriteLine(linea);

            escritor.Close();

        }

        public void editarPersona(Persona personaViejo, Persona personaEditado)
        {
            string lineaVieja = construirLinea(personaViejo);
            string lineaEditada = construirLinea(personaEditado);

            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);

            while (!lector.EndOfStream)
            {
                string lineaLeida = lector.ReadLine();

                if (lineaLeida == lineaVieja)
                    lineaLeida = lineaEditada;

                escritor.WriteLine(lineaLeida);
            }

            lector.Close();
            escritor.Close();

            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);

        }

        public void eliminarPersona(Persona persona)
        {
            string lineaAEliminar = construirLinea(persona);

            StreamReader lector = new StreamReader(_archivo);
            StreamWriter escritor = new StreamWriter(_archivoBak);

            while (!lector.EndOfStream)
            {
                string lineaLeida = lector.ReadLine();

                if (lineaLeida != lineaAEliminar)
                    escritor.WriteLine(lineaLeida);
            }

            lector.Close();
            escritor.Close();

            File.Delete(_archivo);
            File.Move(_archivoBak, _archivo);
        }

        public List<Persona> leerArchivo()
        {
            List<Persona> lista = new List<Persona>();

            if (File.Exists(_archivo))
            {
                StreamReader lector = new StreamReader(_archivo);

                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();

                    Persona persona = construirPersona(linea);

                    lista.Add(persona);
                }

                lector.Close();
            }

            return lista;
        }

        //METODOS PRIVADOS

        private Persona construirPersona(string linea)
        {
            string[] datos = linea.Split('|');

            string DNI = datos[0];
            string apellido = datos[1];
            string primerNombre = datos[2];
            string segundoNombre = datos[3];
            DateTime fechaNacimiento = Convert.ToDateTime(datos[4]);
            Sexo sexo = (Sexo)Convert.ToInt32(datos[5]);
            Localidad localidad = (Localidad)Convert.ToInt32(datos[6]);            

            Persona persona = new Persona(DNI,apellido,primerNombre,segundoNombre,fechaNacimiento,sexo,localidad);

            return persona;
        }

        private string construirLinea(Persona persona)
        {
            StringBuilder constructor = new StringBuilder();

            constructor.Append(persona.obtenerDNI() + '|');
            constructor.Append(persona.obtenerApellido() + '|');
            constructor.Append(persona.obtenerPrimerNombre() + '|');
            constructor.Append(persona.obtenerSegundoNombre() + '|');
            constructor.Append(persona.obtenerFechaNacimiento().ToString() + '|');
            constructor.Append(persona.obtenerSexo().GetHashCode().ToString() + '|');
            constructor.Append(persona.obtenerLocalidad().GetHashCode().ToString());

            return constructor.ToString();

        }
    }
}
