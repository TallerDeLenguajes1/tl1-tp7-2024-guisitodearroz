// See https://aka.ms/new-console-template for more information
using proyectoCalculadora;
Console.WriteLine("Hello, World!");
Calculadora nuevCalcu= new Calculadora();
nuevCalcu.Sumar(9);
nuevCalcu.Multiplicar(3);
nuevCalcu.Dividir(9);
Console.WriteLine(nuevCalcu.resultado);
nuevCalcu.Limpiar();
Console.WriteLine(nuevCalcu.resultado);