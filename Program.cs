
using Ccine;
namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            string nombre1 = "hdla";
            string telefono1 = " hdla";
            string pagweb1 = "hdla ";
            string direccionFacebook1 = "hdla ";


            CCine cine  = new Ccine(nombre1, telefono1, pagweb1, direccionFacebook1);

            cine.nombre = nombre1;
            cine.telefono = telefono1;
            cine.pagweb = pagweb1;
            cine.direccionFacebook = direccionFacebook1; cine.nombre = nombre1;

            Console.WriteLine("Ingrese el nombre del cine");
            nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono");
            telefono1 = Console.ReadLine();

            Console.WriteLine("Ingrese la pagweb ");
            pagweb1 = Console.ReadLine();

            Console.WriteLine("Ingrese la direccion de facebook");
            direccionFacebook1 = Console.ReadLine();



            cine.mostrarDatos();

        }
    }
}
