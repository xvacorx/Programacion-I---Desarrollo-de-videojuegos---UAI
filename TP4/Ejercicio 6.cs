//6. En una carrera de autos se ingresan el número de auto y su tiempo,
//indicar e imprimir cuál ganó y cúal fue el último

int Tiempo = 0;
int MejorAuto = 0;
int MejorTiempo = 0;
int PeorAuto = 0;
int PeorTiempo = 0;

Console.WriteLine("Ingrese número de auto (ingrese 0 para finalizar)");
int NumeroAuto = int.Parse(Console.ReadLine());

while (NumeroAuto != 0)
{
    Console.WriteLine("Ingrese tiempo");
    Tiempo = int.Parse(Console.ReadLine());

    if (Tiempo > PeorTiempo || PeorTiempo == 0)
    {
        PeorTiempo = Tiempo;
        PeorAuto = NumeroAuto;
    }
    if (Tiempo < MejorTiempo || MejorTiempo == 0)
    {
        MejorTiempo = Tiempo;
        MejorAuto = NumeroAuto;
    }

    Console.WriteLine("Ingrese número de auto (ingrese 0 para finalizar)");
    NumeroAuto = int.Parse(Console.ReadLine());
}

Console.WriteLine("El auto más rápido fue el número " + MejorAuto);
Console.WriteLine("Con un tiempo de: " + MejorTiempo);

Console.WriteLine("El auto más lento fue el número: " + PeorAuto);
Console.WriteLine("Con un tiempo de: " + PeorTiempo);
