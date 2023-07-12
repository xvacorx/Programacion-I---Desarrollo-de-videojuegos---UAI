//5. Ingresar temperaturas hasta una temperatura igual a 1000, indicar e imprmir la mayor y menor

int Mayor = 0;
int Menor  = 0;

Console.WriteLine("Ingrese temperatura (Digite 1000 para salir)");
int Temperatura = int.Parse(Console.ReadLine());

while (Temperatura != 1000)
{
    if (Temperatura > Mayor || Mayor == 0) { Mayor = Temperatura; }
    else if (Temperatura < Menor || Menor == 0) { Menor = Temperatura; }

    Console.WriteLine("Ingrese temperatura (Digite 1000 para salir)");
    Temperatura = int.Parse(Console.ReadLine());
}

Console.WriteLine("La temperatura mayor registrada fue de: " +  Mayor);
Console.WriteLine("La temperatura menor registrada fue de: " +  Menor);
