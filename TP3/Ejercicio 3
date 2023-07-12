//3. Ingresar 8 valores por teclado, y a partir de esto sacar el promedio general,
//sacar el promedio de lo valores pares y el promedio de los valores impares.
//Luego, mostrar por pantalla cuantos números superaron el valor 15.

Console.WriteLine("Ingrese 8 valores");

float SumaTotal = 0;
float SumaPar = 0;
float SumaImpar = 0;
float TotalImpar = 0;
float TotalPar = 0;
int Mayor15 = 0;

for (float i = 0; i < 8; i++)
{
    float Numero = float.Parse(Console.ReadLine());
    SumaTotal += Numero;
    if (Numero > 15) { Mayor15++; }
    if (Numero % 2 == 0) { SumaPar += Numero; TotalPar++; }
    else { SumaImpar += Numero; TotalImpar++; }
}

float PromedioGeneral = SumaTotal / 8;
float PromedioPar = SumaPar / TotalPar;
float PromedioImpar = SumaImpar / TotalImpar;

Console.WriteLine("El promedio general es de: " + PromedioGeneral);
Console.WriteLine("El promedio de los números pares es de: " + PromedioPar);
Console.WriteLine("El promedio de los números impares es de: " + PromedioImpar);
Console.WriteLine("La cantidad de números mayores a 15 es de: " + Mayor15);
