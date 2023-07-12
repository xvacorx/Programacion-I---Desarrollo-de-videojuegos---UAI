//4. Un restaurant tiene 6 mozos y 12 mesas, cada vez que cobran una mesa se anotan los siguientes datos,
//que terminan con número de factura = 0
//• Número de factura
//• Número de mozo
//• Número de mesa
//• Cantidad de personas que comieron
//• Monto de la cuenta

//Se desea saber lo siguiente

//Cantidad de personas atendidas por cada mozo
//Cantidad de facturas realizadas
//Caja diaria realizada
//Monto facturado por cada mesa en total
//Porcentual facturado por cada mozo sobre el total
//Si a cada mozo se le da el 5% de su venta cuánto le corresponde a cada uno
//Cuál mozo atendió más personas en total
//Cuántas facturas superaron $ 45
//Mesa a la que se facturó más veces, o sea que más recambio de clientes tuvo

double[,] Mozos = new double[4, 6]; //Mozos | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado | 3. Sueldo
int[,] Mesas = new int[3, 12]; //Mesas | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado
int MontoTotal = 0;
int MozoMax = 0;
int CantidadMax = 0;
int CantidadFacturas = 0;
int MasDe45 = 0;
int MesaMax = 0;

Console.WriteLine("Ingrese número de factura:");
int Factura = int.Parse(Console.ReadLine());

while(Factura != 0)
{
    CantidadFacturas++;

    Console.WriteLine("Ingrese número de mozo (1-6)");
    int NumeroMozo = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese número de mesa (1-12)");
    int NumeroMesa = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese cantidad de personas atendidas");
    int CantidadPersonas = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese monto de la cuenta");
    int MontoCuenta = int.Parse(Console.ReadLine());
    if (MontoCuenta > 45) { MasDe45++; }
    MontoTotal += MontoCuenta;

    //Mozos | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado | 3. Sueldo
    //Mesas | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado

    Mozos[0, NumeroMozo-1]++; Mozos[1, NumeroMozo - 1] += CantidadPersonas; Mozos[2, NumeroMozo - 1] += MontoCuenta; Mozos[3, NumeroMozo - 1] += MontoCuenta * 0.05;
    Mesas[0, NumeroMesa-1]++; Mesas[1, NumeroMesa - 1] += CantidadPersonas; Mesas[2, NumeroMesa - 1] += MontoCuenta;

    Console.WriteLine("Ingrese número de factura:");
    Factura = int.Parse(Console.ReadLine());
}

for (int i = 0; i < Mozos.GetLength(1); i++)
{
    if (Mozos[1, i] > CantidadMax) { CantidadMax = (int)Mozos[1, i]; MozoMax = i + 1; }
} //Calculo de mozo con mayor cantidad de personas

for (int i = 0; i < Mesas.GetLength(1); i++)
{
    if (Mesas[0, i] > MesaMax) { MesaMax = i + 1; }
}//Calculo de mesa con mayor cantidad de facturas

Console.WriteLine("Resumen del final del día:");

Console.WriteLine("se emitieron un total de {0} facturas por un total de ${1}", CantidadFacturas , MontoTotal);
Console.WriteLine("Se recaudó un total de {0} facturas superiores a $45", MasDe45);
Console.WriteLine("La mesa que mas veces facturó fue la mesa nro {0} con un total de {1} facturas", MesaMax, Mesas[0, MesaMax - 1]);
Console.WriteLine("El mozo que más personas atendió fue el nro " + MozoMax + " con un total de " + CantidadMax + " personas");

//Mozos | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado | 3. Sueldo
Console.WriteLine("Resumen de los mozos:");
for  (int i = 0; i < Mozos.GetLength(1); i++)
{
    int PorcentajeDelTotal = (int)((Mozos[3, i] * 100) / MontoTotal);
    Console.WriteLine("Mozo Nro {0}:", i + 1);
    Console.WriteLine("El mozo nro {0} atendió {1} personas", i+1, Mozos[1, i]);
    Console.WriteLine("Facturó un total de: ${0}, lo cual representa un %{1} del total", Mozos[2, i], PorcentajeDelTotal);
    Console.WriteLine("Le corresponde un total de $" + Mozos[3, i]);
}

//Mesas | 0. Cant Facturas | 1. Cant Personas | 2. Total Facturado
Console.WriteLine("Resumen de las mesas:");
for (int i = 0; i < Mesas.GetLength(1); i++)
{
    Console.WriteLine("La mesa nro {0} realizó {1} facturas por un total de ${2}",i + 1, Mesas[0, i], Mesas[2, i]);
}
