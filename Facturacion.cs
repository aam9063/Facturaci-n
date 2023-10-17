using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Bienvenido al sistema de facturación");
        Console.Write("Ingrese el nombre del cliente: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la dirección del cliente: ");
        string direccion = Console.ReadLine();

        Console.Write("Ingrese el CIF del cliente: ");
        string cif = Console.ReadLine();

        Console.Write("Ingrese el importe de la factura: ");
        decimal importeFactura = decimal.Parse(Console.ReadLine());

        decimal descuento = 0;
        string mensajeDescuento = "";

        // Calcular el descuento o penalización según la fecha de pago.
        Console.Write("Ingrese el día de pago (1-31): ");
        int diaPago = int.Parse(Console.ReadLine());

        if (diaPago >= 1 && diaPago <= 10)
        {
            descuento = Math.Max(0.5m, importeFactura * 0.10m);
            mensajeDescuento = "Tiene un descuento de 10% o 0.50€, el que sea mayor.";
        }
        else if (diaPago >= 21)
        {
            descuento = Math.Max(1.0m, importeFactura * 0.05m);
            mensajeDescuento = "Se le aplica una penalización de 5% o 1.00€, el que sea mayor.";
        }
        else
        {
            mensajeDescuento = "No se le aplica ningún descuento o penalización.";
        }

        decimal importePagar = importeFactura - descuento;

        Console.WriteLine("\n*** Carta al cliente ***");
        Console.WriteLine($"Nombre del cliente: {nombre}");
        Console.WriteLine($"Dirección del cliente: {direccion}");
        Console.WriteLine($"CIF del cliente: {cif}");
        Console.WriteLine($"Importe de la factura: {importeFactura:C}");
        Console.WriteLine($"Fecha de pago: {diaPago}");
        Console.WriteLine($"Descuento/penalización: {mensajeDescuento}");
        Console.WriteLine($"Importe a pagar: {importePagar:C}");
    }
}
