using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tarea2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 8;
            do //primero ejecuta y luego evalua
            {
                //Console.Clear();
                Console.WriteLine("1- Ejercicio 1");
                Console.WriteLine("2- Ejercicio 2");
                Console.WriteLine("3- Ejercicio 3");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion incorrecta");
                        Console.ReadLine();
                        break;

                }

            } while (opcion != 4);

        }
        // 1camisa sin descuento
        // de 2 a 5 con 15% descuento
        // mas de 5 con 28% > <
        public static void Ejercicio1()
        {
            float precio = 0f;
            int cantidad= 0;

           Console.WriteLine(" Digite el precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine(" Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad==1)// si la cantidad es 1
            {
                Console.WriteLine($"El precio de la camisa es de {cantidad * precio}");

            }else if (cantidad>=2 && cantidad<=5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio- (precio*0.15f))* cantidad)} con descuento de 15%");
            }else if (cantidad > 5)
            {
                Console.WriteLine($"El precio de la camisa es de {((precio - (precio * 0.20f)) * cantidad)} con descuento de 20%");
            }

            Console.ReadLine();
        }
        //para cada estudiante: carnet, nombre, quiz 1, quiz 2, quiz 3, tarea 1, tarea 2, tarea 3, examen 1, examen 2 y examen 3
        // calcular el porcentaje de quices (25%), porcentaje de tareas (30%), y el porcentaje de exámenes (45%)
        //Si el promedio final es mayor o igual a 70 “Aprobado”. Si el promedio final es mayor o igual a 50 y menor que 70 “Aplazado” y si el promedio final es menor que 50 “Reprobado”. 9. 

        public static void Ejercicio2()
        {
            {
                // Leer los datos del estudiante
                Console.Write("Ingrese el carnet del estudiante: ");
                string carnet = Console.ReadLine();
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                double[] quices = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Ingrese la nota del quiz {i + 1}: ");
                    quices[i] = double.Parse(Console.ReadLine());
                }

                double[] tareas = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Ingrese la nota de la tarea {i + 1}: ");
                    tareas[i] = double.Parse(Console.ReadLine());
                }

                double[] examenes = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Ingrese la nota del examen {i + 1}: ");
                    examenes[i] = double.Parse(Console.ReadLine());
                }

                // Calcular los porcentajes
                double porcentaje_quices = Sum(quices) / quices.Length * 0.25;
                double porcentaje_tareas = Sum(tareas) / tareas.Length * 0.30;
                double porcentaje_examenes = Sum(examenes) / examenes.Length * 0.45;

                // Calcular el promedio final
                double promedio_final = porcentaje_quices + porcentaje_tareas + porcentaje_examenes;

                // Determinar la condición del estudiante
                string condicion;
                if (promedio_final >= 70)
                    condicion = "Aprobado";
                else if (promedio_final >= 50)
                    condicion = "Aplazado";
                else
                    condicion = "Reprobado";

                // Reportar los resultados
                Console.WriteLine($"Carnet: {carnet}");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Porcentaje de Quices: {porcentaje_quices}");
                Console.WriteLine($"Porcentaje de Tareas: {porcentaje_tareas}");
                Console.WriteLine($"Porcentaje de Exámenes: {porcentaje_examenes}");
                Console.WriteLine($"Promedio Final: {promedio_final}");
                Console.WriteLine($"Condición del Estudiante: {condicion}");
            }
        }

        private static double Sum(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        //Si le compran 10 productos o menos, el precio por producto es de $20
        //Si le compran más de 10 artículos, el precio es de $15 por artículo
        //proporcionarle la cantidad de artículos dé como resultado el precio y el total.
        public static void Ejercicio3()
        {
            // Leer la cantidad de artículos
            Console.Write("Ingrese la cantidad de artículos: ");
            int cantidad = int.Parse(Console.ReadLine());

            // Definir los precios
            int precio = (cantidad > 10) ? 15 : 20;

            // Calcular el total
            int total = precio * cantidad;

            // Imprimir el precio y el total
            Console.WriteLine($"El precio por artículo es: ${precio}");
            Console.WriteLine($"El total a pagar es: ${total}");

        }
    }
}




