using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            int cantidad = 0;
            int opcion = 0;

            do
            {
                Console.WriteLine("1= Ejercicio 1");
                Console.WriteLine("2= Ejercicio 2");
                Console.WriteLine("3= Ejercicio 3");
                Console.WriteLine("4= Salir");
                Console.WriteLine(" ***************");
                Console.WriteLine(" Digite su opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Console.WriteLine($"Gracias"); break;


                    default: 
                        Console.Clear();
                        Console.WriteLine("Opcion es incorrecta");
                        Console.ReadLine();
                        break;
                }



            } while (opcion!=4);

            Console.ReadLine();
               


            }
        static void Ejercicio1()
        {
            Console.WriteLine("Ejercicio 1");
        }
        static void Ejercicio2()
        {
            Console.WriteLine("Ejercicio 2");
        }
        static void Ejercicio3()
        {
            Console.WriteLine("Ejercicio 3");
        }
       
    }
    }

