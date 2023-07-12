//3. Ingresar N valores, calcular e imprimir el promedio de positivos, de negativos y cantidad de ceros

bool Salir = false;

int Cantidad = 0;
int CantidadPositivos = 0;
int CantidadNegativos = 0;
int CantidadCeros = 0;

while (Salir == false)
{
    Console.WriteLine("Ingrese un valor");
    float Valor = float.Parse(Console.ReadLine());

    Cantidad++;
    if (Valor > 0) { CantidadPositivos++; }
    else if (Valor < 0) { CantidadNegativos++; }
    else { CantidadCeros++; }

    Console.WriteLine("Desea salir? (S/N)");
    char Opcion = char.Parse(Console.ReadLine());

    if (Opcion == 'S' || Opcion == 's') { Salir = true; }

}

float PromedioPositivos = (float)CantidadPositivos / (float)Cantidad;
float PromedioNegativos = (float)CantidadNegativos / (float)Cantidad;
float PromedioCeros = (float)CantidadCeros / (float)Cantidad;

Console.WriteLine("Se ingresaron " + Cantidad + " valores, con los siguientes resultados:");
Console.WriteLine("Promedio de números positivos " + PromedioPositivos);
Console.WriteLine("Promedio de números negativos " + PromedioNegativos);
Console.WriteLine("Promedio de ceros: " + PromedioCeros);
