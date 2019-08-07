using FigurasGeometricas.Modelo;
using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Cuadrado(5);
            Console.WriteLine($"Area: {cuadrado.Area()}");
            Console.WriteLine($"Perimetro: {cuadrado.Perimetro()}");
            Console.ReadKey();
            var triangulo = new Triagulo(5, 5, 5, 5, 5);
            Console.WriteLine($"Area {triangulo.Area()}");
            Console.WriteLine($"Perimetro {triangulo.Perimetro()}");
            Console.ReadKey();
        }
    }
}
