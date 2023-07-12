//7. Dada la distancia en kilómetros recorrida por un automóvil y la cantidad de litros de
//combustible consumidos en el trayecto, determinar el rendimiento promedio en Kms por litro.

Console.WriteLine("Cantidad de KM recorridas: ");
float KM = float.Parse(Console.ReadLine());

Console.WriteLine("Cantidad de L consumidas: ");
float Litros = float.Parse(Console.ReadLine());


float Rendimiento = KM / Litros;


Console.WriteLine("La cantidad de KM por litro es de: " + Rendimiento);
