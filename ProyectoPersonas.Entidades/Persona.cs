using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonas.Entidades
{
     public class Persona : ICloneable
     {
        //ATRIBUTOS

        private string primerNombre, segundoNombre, apellido;
        private string DNI;
        private DateTime fechaNacimiento;
        private Sexo sexo;
        private Localidad localidad;

        //CONSTRUCTOR

        public Persona(string DNI, string apellido, string primerNombre, string segundoNombre, DateTime fechaNacimiento, Sexo sexo, Localidad localidad)
        {
            this.DNI = DNI;
            this.apellido = apellido;
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.localidad = localidad;
        }

        //METODOS

        //METODOS PRIVADOS

        private bool cumplioAnios()
        {
            bool cumplio = false;

            int diaActual = DateTime.Now.Day;
            int mesActual = DateTime.Now.Month;
            int diaCumpleanios = fechaNacimiento.Day;
            int mesCumpleanios = fechaNacimiento.Month;

            if (diaCumpleanios <= diaActual && mesCumpleanios <= mesActual)
                cumplio = true;

            return cumplio;

        }
        private int calcularEdad()
        {
            int edad = 0;

            if (cumplioAnios())
            {
                edad = DateTime.Now.Year - fechaNacimiento.Year;
            }
            else
            {
                edad = DateTime.Now.Year - fechaNacimiento.Year - 1;
            }

            return edad;
        }

        //METODOS PUBLICOS

        public string obtenerDNI() { return DNI; }

        public string obtenerPrimerNombre() { return primerNombre; }

        public string obtenerSegundoNombre() { return segundoNombre; }

        public DateTime obtenerFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public Sexo obtenerSexo() { return sexo; }
        public Localidad obtenerLocalidad() { return localidad; }

        public int obtenerEdad() 
        {
            return calcularEdad(); 
        }

        public string obtenerApellido() { return apellido; }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Persona))
                return false;
            else
                return DNI == ( (Persona)obj ).obtenerDNI();
        }

        public override int GetHashCode()
        {
            return DNI.GetHashCode();
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
