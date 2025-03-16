using System;
namespace Vehiculos
{
    public class Vehiculo
    {
        protected string marca = string.Empty;
        protected string modelo = string.Empty;
        protected string color = string.Empty;
        protected int anio;
        protected int velocidadMaxima;

        public Vehiculo(string marca, string modelo, string color, int anio, int velocidadMaxima)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.anio = anio;
            this.velocidadMaxima = velocidadMaxima;
        }

        protected void setMarca(string marca)
        {
            this.marca = marca;
        }

        protected void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        protected void setColor(string color)
        {
            this.color = color;
        }

        protected void setAnio(int anio)
        {
            this.anio = anio;
        }

        protected void setVelocidadMaxima(int velocidadMaxima)
        {
            this.velocidadMaxima = velocidadMaxima;
        }


        public virtual void mostrarDatos()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Año: " + anio);
            Console.WriteLine("Velocidad Maxima: " + velocidadMaxima);
        }



        public void acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando...");
        }
    }
}