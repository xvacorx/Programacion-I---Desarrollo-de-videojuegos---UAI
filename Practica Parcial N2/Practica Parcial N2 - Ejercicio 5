//5. Realiza un programa en C#, que muestre un menú en pantalla con las opciones:
//1) Sumar
//2) Restar
//3) Salir
//El usuario debe seleccionar una opción. y a continuación,
//el programa deber solicitar el ingreso de 2 números enteros.
//Una vez ingresados los números, se deberá evaluar con if,
//realizando la operación correspondiente a la opción seleccionada.
//La ejecución debe realizarse una y otra vez, hasta que el usuario seleccione la opción 3.

Console.WriteLine("Ingrese opción:");
Console.WriteLine("1) Sumar");
Console.WriteLine("2) Restar");
Console.WriteLine("3) Salir");

int Opcion = int.Parse(Console.ReadLine());

while (Opcion != 3)
{
    if (Opcion == 1)
    {
        Console.WriteLine("Ingrese primer valor");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo valor");
        int Numero2 = int.Parse(Console.ReadLine());

        int Suma = Numero1 + Numero2;

        Console.WriteLine("La suma de ambos valores es de " + Suma);
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
    }
    if (Opcion == 2)
    {
        Console.WriteLine("Ingrese primer valor");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo valor");
        int Numero2 = int.Parse(Console.ReadLine());

        int Resta = Numero1 - Numero2;

        Console.WriteLine("La resta de ambos valores es de " + Resta);
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
    }
    Menu();
}

void Menu()
{
    Console.WriteLine("Ingrese opción:");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Salir");

    Opcion = int.Parse(Console.ReadLine());
}
