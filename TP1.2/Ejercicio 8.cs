//8.Dado el importe bruto de una factura, calcular el resultado de bonificar con un 4%.
//Luego, calcular el IVA. Finalmente informar el importe bruto, el valor de la
//bonificación, el importe bruto bonificado, el monto correspondiente al IVA y el importe neto resultante.

Console.WriteLine("Ingrese importe de la factura: ");
float Importe = float.Parse(Console.ReadLine());

double Bonificar = Importe * 0.04;
double IVA = (Importe + Bonificar) * 0.21;
double Total = Bonificar + IVA;

Console.WriteLine("El importe es de: " + Importe);
Console.WriteLine("La bonificación es de: " +  Bonificar);
Console.WriteLine("El IVA es de: " + IVA);
Console.WriteLine("El total es de: " + Total);
