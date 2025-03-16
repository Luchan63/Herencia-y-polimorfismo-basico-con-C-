using System;
using Vehiculos;

class Program
{
    static void Main(string[] args)
    {

        List<Vehiculo> vehiculos = new List<Vehiculo>
        {
            new Coche("Ford", "Fiesta", "Rojo", 2010, 180, 4),
            new Moto("Yamaha", "FZ", "Negro", 2015, 200, 150),
            new Camion("Scania", "R500", "Blanco", 2018, 120, 20000)
        };


        foreach (var vehiculo in vehiculos)
        {
            Console.WriteLine("------------------------------------------");
            vehiculo.mostrarDatos();
            vehiculo.acelerar();
        }
        Console.WriteLine("------------------------------------------");

    }
}