//2. Ingresar facturas hasta nro de factura = 0,
//sumar sus importes y cuantas superan los $1000. imprimir los resultados

using System.ComponentModel.Design;

int CantidadFacturas = 0;
int Total = 0;
int MasDe1k = 0;
int Entre400y700 = 0;

Console.WriteLine("Ingrese número de factura (ingrese 0 para salir):");
int NumeroFactura = int.Parse(Console.ReadLine());

while (NumeroFactura != 0)
{
    Console.WriteLine("Ingrese importe de factura");
    int Importe = int.Parse(Console.ReadLine());
    CantidadFacturas++;
    Total += Importe;

    if (Importe > 1000) { MasDe1k++; }

    //a. Sobre el ejercicio anterior indicar cuántas estan entre $ 400 y $ 700 inclusive. imprimir el resultado

    else if (Importe >= 400 && Importe <= 700) { Entre400y700++; }

    Console.WriteLine("Ingrese número de factura (ingrese 0 para salir):");
    NumeroFactura = int.Parse(Console.ReadLine());
    
}

Console.WriteLine("Se ingresaron un total de " + CantidadFacturas + " facturas, por un importe total de $" + Total);

Console.WriteLine("Se cargaron " + MasDe1k + " facturas de importe superior a $1000");

//a. Sobre el ejercicio anterior indicar cuántas estan entre $ 400 y $ 700 inclusive. imprimir el resultado

Console.WriteLine("Se cargaron " + Entre400y700 + " facturas de importe entre $400 y $700");
