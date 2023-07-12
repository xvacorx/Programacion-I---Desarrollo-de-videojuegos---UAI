/*
//1.a) Ingresar las notas del examen final, oral y trabajo práctico de 3 alumnos distintos utilizando un arreglo correspondiente para cada alumno.
//Y calcular el promedio de las notas totales.

int[] Alumno1 = new int[3];
int[] Alumno2 = new int[3];
int[] Alumno3 = new int[3];
int[] Promedio = new int[3];
int NotaTotal = 0;

Console.WriteLine("Ingrese notas del alumno 1");
for (int i = 0; i < 3; i++)
{
    Alumno1[i] = int.Parse(Console.ReadLine());
    NotaTotal += Alumno1[i];
}
Promedio[0] = NotaTotal / 3;
NotaTotal = 0;

Console.WriteLine("Ingrese notas del alumno 2");
for (int i = 0; i < 3; i++)
{
    Alumno2[i] = int.Parse(Console.ReadLine());
    NotaTotal += Alumno2[i];
}
Promedio[1] = NotaTotal / 3;
NotaTotal = 0;

Console.WriteLine("Ingrese notas del alumno 3");
for (int i = 0; i < 3; i++)
{
    Alumno2[i] = int.Parse(Console.ReadLine());
    NotaTotal += Alumno2[i];
}
Promedio[2] = NotaTotal / 3;
NotaTotal = 0;

//1.b) Si el promedio de las notas es mayor a 13 se debe mostrar un mensaje de APROBADOS por pantalla, caso contrario deberá mostrar un mensaje de DESAPROBADOS.

if (Promedio[0] < 13) { Console.WriteLine("El alumno 1 está DESAPROBADO"); }
else { Console.WriteLine("El alumno 1 está APROBADO"); }
Console.WriteLine();

if (Promedio[1] < 13) { Console.WriteLine("El alumno 2 está DESAPROBADO"); }
else { Console.WriteLine("El alumno 2 está APROBADO"); }
Console.WriteLine();

if (Promedio[2] < 13) { Console.WriteLine("El alumno 3 está DESAPROBADO"); }
else { Console.WriteLine("El alumno 3 está APROBADO"); }
*/

/*
//2) Ingresar 3 números mediante un arreglo e indicar cual es el número mayor, el número menor y si se ingresa números repetidos mostrar un mensaje que se ha ingresado números iguales.

int[] Numeros = new int[3];
int Anterior = 0;
int Mayor = 0;
int Menor = 0;

Console.WriteLine("Ingrese 3 números");

for (int i = 0; i < Numeros.Length; i++)
{
    Numeros[i] = int.Parse(Console.ReadLine());
    while (Numeros[i] == Anterior)
    {
        Console.WriteLine("El número ingresado es igual al antrerior, ingrese otro");
        Numeros[i] = int.Parse(Console.ReadLine());
    }
    Anterior = Numeros[i];
    if (Numeros[i] > Mayor) { Mayor = Numeros[i]; }
    if (Numeros[i] < Menor || Menor == 0) { Menor = Numeros[i]; }
}

Console.WriteLine("El número mayor fue {0}, mientras que el menor fue {1}",Mayor, Menor);
*/


/*
//3) Realiza un programa en C#, que muestre un menú en pantalla con las opciones:
//1.Sumar
//2. Restar
//3. Multiplicar
//4. Dividir
//5) Salir
//El usuario debe seleccionar una opción. y a continuación, el programa deberá solicitar el ingreso de 2 números enteros.
//Una vez ingresados los números, se deberá realizar la operación correspondiente a la opción seleccionada.
//La ejecución debe realizarse una y otra vez, hasta que el usuario seleccione la opción # 5.

int Opcion = 0;

Menu();

while (Opcion != 5)
{
    Console.Clear();
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
    if (Opcion == 3)
    {
        Console.WriteLine("Ingrese primer valor");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo valor");
        int Numero2 = int.Parse(Console.ReadLine());

        int Resta = Numero1 * Numero2;

        Console.WriteLine("La resta de ambos valores es de " + Resta);
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
    }
    if (Opcion == 4)
    {
        Console.WriteLine("Ingrese primer valor");
        int Numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo valor");
        int Numero2 = int.Parse(Console.ReadLine());

        int Resta = Numero1 / Numero2;

        Console.WriteLine("La resta de ambos valores es de " + Resta);
        Console.WriteLine("Presione Enter para continuar");
        Console.ReadLine();
    }
    else { Console.WriteLine("Ingrese opción válida"); }
    Menu();
}

void Menu()
{
    Console.WriteLine("Ingrese opción:");
    Console.WriteLine("1) Sumar");
    Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
    Console.WriteLine("4) Dividir");
    Console.WriteLine("5) Salir");

    Opcion = int.Parse(Console.ReadLine());
}
*/


/*
//4) Crear un arreglo donde contenga todos los meses del año.
//Hacer un programa que indique el mes y la estaciones del año correspondiente según el número de mes que ingrese el usuario, sabiendo la siguiente información:
//*Diciembre, Enero, Febrero es Verano
//*Marzo, Abril, Mayo es Otoño
//*Junio, Julio, Agosto es Invierno
//*Septiembre, Octubre, Noviembre es Primavera

string[] Año = new string[12] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

Console.WriteLine("Ingrese número de mes (1-12)");
int Mes = int.Parse(Console.ReadLine());

while (Mes < 1 || Mes > 12)
{
    Console.WriteLine("Mes inválido, elija el correcto (1-12)");
    Mes = int.Parse(Console.ReadLine());
}

if (Mes == 1 || Mes == 2 || Mes == 12)
{
    Console.WriteLine("Ingresó el mes de {0}, que corresponde a VERANO", Año[Mes - 1]);
}
if (Mes == 3 || Mes == 4 || Mes == 5)
{
    Console.WriteLine("Ingresó el mes de {0}, que corresponde a OTOÑO", Año[Mes - 1]);
}
if (Mes == 6 || Mes == 7 || Mes == 8)
{
    Console.WriteLine("Ingresó el mes de {0}, que corresponde a INVIERNO", Año[Mes - 1]);
}
if (Mes == 9 || Mes == 10 || Mes == 11)
{
    Console.WriteLine("Ingresó el mes de {0}, que corresponde a PRIMAVERA", Año[Mes - 1]);
}
*/
