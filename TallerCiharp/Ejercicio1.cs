using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCiharp
{
    public class Ejercicio1
    {
        public void areatriangulo() {

            //Definir Variables
             

            Console.WriteLine("Ingrese lado a: ");
            var a= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado b: ");
            //Guardar datos
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado b: ");
            //Solicitar Datos
            Console.WriteLine("Ingrese lado c: ");
            //Guardar Datos 
            var c = int.Parse(Console.ReadLine());

            //Proceso
            //s = (a + b + c) / 2;  //s = Semiperimetro
            var s = (a + b + c) / 2; //s = Semiperimetro
            //area = Math.Sqrt(s - a) * (s - b) * (s - c));
            var area = Math.Sqrt (s * (s - a) * (s - b) * (s - c));

            Console.WriteLine(); //Salto de linea
            Console.WriteLine("Algoritmo Area Triangulo");
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.areatriangulo();
          
            Console.WriteLine($"El Area del Triangulo segun lados {a}, {b}, {c} es: {area} m2");


            //Detener pantalla para ver resultados
            Console.ReadKey();
    }
