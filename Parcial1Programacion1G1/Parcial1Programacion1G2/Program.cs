using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Programacion1G2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }

        public Vehiculo(string marca, string modelo, int anio)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Vehículo:");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Año: " + Anio);
        }

        public virtual void Encender()
        {
            Console.WriteLine("El vehículo se está encendiendo...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("   SISTEMA DE VEHICULOS - PARCIAL   ");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // 1. Crear una lista de tipo Vehiculo
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            // 2. Crear objetos de las clases hijas
            Carro miCarro = new Carro("Toyota", "Corolla", 2024, 4);
            Moto miMoto = new Moto("Honda", "CBR600RR", 2023, 600);

            // 3. Agregarlos a la lista
            listaVehiculos.Add(miCarro);
            listaVehiculos.Add(miMoto);

            // 4. Recorrer la lista usando foreach
            foreach (Vehiculo v in listaVehiculos)
            {
                // 5. Llamar a los métodos (Aquí ocurre el Polimorfismo)
                v.MostrarInformacion();
                v.Encender();
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("Programa finalizado.");
            Console.ReadKey();
        }
    }