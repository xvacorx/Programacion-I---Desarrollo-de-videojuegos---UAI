//6. Desarrolle un programa que almacene en un vector el número de días que tiene cada mes
//(supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre)
//y muestre en pantalla el número de días que tiene ese mes.

int[] Año = new int[13] {0, 31, 27, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

Console.WriteLine("Ingrese número de mes, ingrese 0 para salir");
int Mes = int.Parse(Console.ReadLine());

while (Mes != 0)
{
    Console.WriteLine("El mes elegido dispone de " + Año[Mes] + " días");
    Console.WriteLine("Ingrese número de mes o 0 para salir");
    Mes = int.Parse(Console.ReadLine());
}
