using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   public  class CCine
    {
        public string nombre;
        public string telefono;
        public string pagweb;
        public string direccionFacebook;

        public CCine(string nombre, string telefono, string pagweb, string direccionFacebook)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.pagweb = pagweb;
            this.direccionFacebook = direccionFacebook;
        }

        public void mostrarDatos()
        {
            Console.WriteLine("El nombre es :" + nombre);
            Console.WriteLine("El telefono es :" + telefono);
            Console.WriteLine("El pagweb es: " + pagweb);
            Console.WriteLine("La direccion es: " + direccionFacebook);
        }

    }

