//4. Ingresar los datos de facturación de una empresa.
//Se conoce Número de factura, Número de artículo, Cantidad vendida y Precio unitario
//Los datos finalizan con numero de factura = 0,
//cada factura sólo tiene un número de artículo,y existen sólo tres artículos.

Console.WriteLine("Ingrese número de factura:");
int NroFactura = int.Parse(Console.ReadLine());

while (NroFactura != 0)
{
    Console.WriteLine("Ingrese número de artículo:");
    int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cantidad vendida:");
    int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese precio unitario");
    int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese número de factura:");
    NroFactura = int.Parse(Console.ReadLine());
}
