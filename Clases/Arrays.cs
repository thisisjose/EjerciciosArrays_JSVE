using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArrays_JSVE.Clases
{
    internal class Arrays
    {
        public void Arreglos()
        {
            //////////////////////////////////////////////////////////Nos apoyyamos del codigo del cuaderno//////////////////////////////////////////////////////////////////////////////////

            //int[] arreglos = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arreglos.Length; i++)
            //{
            //    Console.WriteLine(arreglos[i]);
            //}
            //Console.ReadKey();

            //////////////////////////////////////////////////////////Reutilizamos codigo de la anterior y de la actividad en el cuaderno////////////////////////////////////////////////////

            //int[] arreglos = new int[5];
            //for (int i = 0; i < arreglos.Length; i++)
            //{
            //    Console.WriteLine($"Ingresar el valor {i + 1}:");
            //    arreglos[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("los numeros son:");
            //for (int i = 0; i < arreglos.Length; i++)
            //{
            //    Console.WriteLine(arreglos[i]);
            //}

            ////////////////////////////////////////////////////Reutilizando codigo para poder sacar esto////////////////////////////////////////////////////////////////////////////////////

            //int[] arreglos = new int[10];
            //double suma = 0;
            //for(int i = 0; i < arreglos.Length; i++)
            //{
            //    Console.WriteLine($"Ingresa el valor {i+1}:");
            //    arreglos[i] = Convert.ToInt32(Console.ReadLine());
            //    suma += arreglos[i];
            //}
            //double media = suma / arreglos.Length;
            //Console.WriteLine("Los valores son:");
            //for( int i = 0; i < arreglos.Length; i++)
            //{
            //    Console.WriteLine(arreglos[i]);
            //}
            //Console.WriteLine($"La media es {media}");

            ////////////////////////////////////////////////////De igual forma nos apoyamos en el anterior codigo XD//////////////////////////////////////////////////////////////////////

            Console.WriteLine("ingresar tamaño:");
            int tamaño = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar numero para el multiplo:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int[] arreglos = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
            {
                arreglos[i] = numero * (i + 1);
            }
            Console.WriteLine("Los multiplos son");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine(arreglos[i]);
            }



        }
    }
}
