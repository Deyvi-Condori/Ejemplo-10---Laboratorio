using System;

namespace Restaurante_Descuento_Ejemplo_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el consumo total: ");
            decimal consumo = Convert.ToDecimal(Console.ReadLine());

            decimal descuento = 0;
            if (consumo <= 100)
            {
                descuento = consumo * 0.10m; 
            }
            else
            {
                descuento = consumo * 0.20m; 
            }

            decimal subtotal = consumo - descuento;

            decimal impuesto = subtotal * 0.18m;

            decimal totalAPagar = subtotal + impuesto;

            Console.WriteLine($"Consumo: S/ {consumo}");
            Console.WriteLine($"Descuento: S/ {descuento}");
            Console.WriteLine($"Subtotal (sin impuesto): S/ {subtotal}");
            Console.WriteLine($"Impuesto (18%): S/ {impuesto}");
            Console.WriteLine($"Total a pagar: S/ {totalAPagar}");

           Console.ReadLine();
        }
    }
}
