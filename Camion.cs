using System;

namespace Vehiculos
{
    public class Camion : Vehiculo
    {
        private double capacidadCarga;

        public Camion(string marca, string modelo, string color, int anio, int velocidadMaxima, int capacidadCarga) : base(marca, modelo, color, anio, velocidadMaxima)
        {
            this.capacidadCarga = capacidadCarga;
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Capacidad de carga: " + capacidadCarga);
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