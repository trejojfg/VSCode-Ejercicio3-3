using System;

namespace Ejercicio3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y 
            // luego muestre por pantalla el importe final con el descuento que corresponda.
            
            float PrecioVenta, PrecioFinal;

            Console.WriteLine("Introduce el Precio de Venta");
            PrecioVenta = float.Parse(Console.ReadLine());

            if (PrecioVenta >= 1000 && PrecioVenta < 5000){
                PrecioFinal = PrecioVenta * 0.90F;
            }else{
                if (PrecioVenta >= 5000){
                    PrecioFinal = PrecioVenta * 0.82F;
                }else{
                    PrecioFinal = PrecioVenta;
                }
            }
            Console.WriteLine("El precio final es: " + PrecioFinal.ToString("0.00"));
            Console.WriteLine("Fin del programa");

        }
    }
}
