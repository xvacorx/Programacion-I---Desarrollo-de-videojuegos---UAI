//3. Mostrar la suma de los precios de n cantidades de productos,
//hasta que el usurario presione el numero 0 por consola.

int Contador = 0;
int Total = 0;

Console.WriteLine("Ingrese precio del producto o 0 para salir:");
int Precio = int.Parse(Console.ReadLine());

while (Precio != 0)
{
    Contador++;
    Total += Precio;

    Console.WriteLine("Ingrese precio del producto o 0 para salir:");
    Precio = int.Parse(Console.ReadLine());
}

Console.WriteLine("Se ingresaron {0} productos por un total de {1}", Contador, Total);
