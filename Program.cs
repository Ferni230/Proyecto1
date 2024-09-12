using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora básica");

            // Inicializar variables
            double numero1, numero2, resultado;
            string operacion = "";

            // Solicitar números y operación al usuario
            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la operación (+, -, *, /): ");
            operacion = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            // Realizar cálculo según la operación
            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Error: Operación no válida");
                    return;
            }

            // Mostrar resultado
            Console.WriteLine($"Resultado: {numero1} {operacion} {numero2} = {resultado}");

            Console.ReadKey();
        }
    }
}
