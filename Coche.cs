using System;
namespace Vehiculos
{
    public class Coche : Vehiculo
    {
        private int numeroPuertas;

        public Coche(string marca, string modelo, string color, int anio, int velocidadMaxima, int numeroPuertas) : base(marca, modelo, color, anio, velocidadMaxima)
        {
            this.numeroPuertas = numeroPuertas;
        }

        public override void mostrarDatos()
        {
            
            base.mostrarDatos();
            Console.WriteLine("Numero de puertas: " + numeroPuertas);
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }

        public string getMarca()
        {
            return marca;
        }


    }
}