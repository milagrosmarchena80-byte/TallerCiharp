using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCiharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje 
            Console.WriteLine("Bienvenido a C#");

            //-- Definir Variables--
            int a, b, producto;

            // Entrada Datos
            Console.WriteLine("Ingrese Primer Numero:");
            //Guardar valor de la consola
            a= int.Parse(Console.ReadLine());
            a=Convert.ToInt32(Console.ReadLine());
            //a = int.TryParse(consale. Readline())); //Boolean True o False

            Console.WriteLine("Ingrese Segundo Numero:");
            //Guardar valor de la consola
            b = Convert.ToInt32(Console.ReadLine());
            //b = int.TryParse(consale. Readline())); //Boolean True o False

            //--Proceso--
            producto = a * b;
            Console.WriteLine("El producto es: " + (producto));
            Console.WriteLine($"El producto de  {a} *  {b}  es igual {producto}"); 
          
            //Detener pantalla para mostrar el resultado
            Console.ReadKey();
           
        }
    }
}
