using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_es06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para A");
            double numeroA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um numero para B ");
            double numeroB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite um numero para C");
            double numeroC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            double areaTriagulo = numeroA * numeroC / 2.0;
            double areaCirculo = numeroC * numeroC * 3.14159;
            double areaTrapezio = (numeroA + numeroB) * numeroC / 2.0;
            double areaQuadrado = numeroB * numeroB;
            double areaRetangulo = numeroA * numeroB;

            Console.WriteLine($"TRIANGULO = {areaTriagulo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO = {areaCirculo.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO = {areaTrapezio.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO = {areaQuadrado.ToString("f3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO = {areaRetangulo.ToString("f3", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
