# Herencia y Polimorfismo en C#

Este repositorio contiene un proyecto en C# donde se aplican los conceptos de **herencia** y **polimorfismo** en la programación orientada a objetos (POO). Estos conceptos permiten reutilizar código y modificar el comportamiento de las clases de manera flexible.

---

## 📌 Conceptos Clave

### 🔹 Herencia

La **herencia** permite crear una nueva clase basada en otra existente, reutilizando sus atributos y métodos, evitando la repetición de código.

#### **Ejemplo de Herencia:**
```csharp
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
```

---

### 🔹 Polimorfismo

El **polimorfismo** permite que una clase derivada modifique el comportamiento de un método de la clase base usando `override`, permitiendo personalizar su funcionalidad.

#### **Ejemplo de Polimorfismo:**
```csharp
   public class Camion : Vehiculo
    {
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Capacidad de carga: " + capacidadCarga);
        }
    }
 public class Coche : Vehiculo
    {

        public override void mostrarDatos()
        {
            
            base.mostrarDatos();
            Console.WriteLine("Numero de puertas: " + numeroPuertas);
        }
    }

public class Moto : Vehiculo
    {
      
        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Cilindrada: " + cilindrada);
        }
    }
```

---

## 📂 Contenido del Proyecto

✔️ `Herencia.cs` → Ejemplo de herencia en C#  
✔️ `Polimorfismo.cs` → Implementación de polimorfismo con `override`  
✔️ `Program.cs` → Código principal que ejecuta los ejemplos  

---

## ⚙ Requisitos para Ejecutar el Proyecto

1️⃣ **Visual Studio 2022** o **Visual Studio Code** con la extensión de C#.  
2️⃣ **.NET SDK (versión 6.0 o superior)** → [Descargar aquí](https://dotnet.microsoft.com/en-us/download).  

---

## 📥 Cómo Descargar y Ejecutar el Proyecto

### **1️⃣ Clonar el Repositorio**
```sh
git clone https://github.com/luchan63/herencia-polimorfismo-csharp.git
cd herencia-polimorfismo-csharp
```

### **2️⃣ Restaurar Dependencias**
```sh
dotnet restore
```

### **3️⃣ Compilar y Ejecutar**
```sh
dotnet run
```

---

## 📌 Notas Importantes

- El proyecto es una aplicación de consola que muestra ejemplos de **herencia** y **polimorfismo**.  
- Puede ser usado como base para desarrollar aplicaciones más avanzadas con arquitectura orientada a objetos.  

---

## 👨‍💻 Autor

- **Luis Figuereo**  
- [GitHub](https://www.github.com/luchan63)  

🚀 ¡Espero que te sea útil! Si tienes alguna sugerencia, abre un **issue** o haz un **fork** y contribuye. 😊

