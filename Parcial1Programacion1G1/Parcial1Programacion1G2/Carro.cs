using System;

namespace Parcial1Programacion1G2
{
    // Aplicamos Herencia usando ':'
    public class Carro : Vehiculo
    {
        public int NumeroPuertas { get; set; }

        // Constructor que llama al constructor de la base (base)
        public Carro(string marca, string modelo, int anio, int numeroPuertas)
            : base(marca, modelo, anio)
        {
            NumeroPuertas = numeroPuertas;
        }

        // Sobrescritura de métodos usando 'override'
        public override void MostrarInformacion()
        {
            base.MostrarInformacion(); // Llama al método de la base para no repetir código
            Console.WriteLine("Número de puertas: " + NumeroPuertas);
        }

        public override void Encender()
        {
            Console.WriteLine($"El carro {Marca} {Modelo} está encendiendo el motor con llave/botón...");
        }
    }
}