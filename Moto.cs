using System;
namespace Vehiculos
{
    public class Moto : Vehiculo
    {
        private int cilindrada;

        public Moto(string marca, string modelo, string color, int anio, int velocidadMaxima, int cilindrada) : base(marca, modelo, color, anio, velocidadMaxima)
        {
            this.cilindrada = cilindrada;
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Cilindrada: " + cilindrada);
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