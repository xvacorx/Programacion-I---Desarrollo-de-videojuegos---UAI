//2. Ingresar 10 sueldos y edades de una empresa y calcular
//• Sueldo promedio
//• Sueldo promedio de los empleados que tienen entre 23 y 40 años
//• Edad promedio
//• Cantidad de empleados mayores a 30 años y sueldo menor a $ 1000.
//• Cantidad de empleados con edades menor a la edad promedio

int[,] Empresa = new int[2, 10];

int SueldoTotal = 0;
int SueldoTotal23y40 = 0;
int EdadTotal = 0;
int MayoresA30 = 0;
int MenoresAlPromedio = 0;

for  (int i = 0; i < Empresa.GetLength(1); i++)
{
    Console.WriteLine("Ingrese edad y sueldo");

    for (int j = 0; j < Empresa.GetLength(0); j++)
    {
        Empresa[j, i] = int.Parse(Console.ReadLine());
    }

    EdadTotal += Empresa[0, i];
    SueldoTotal += Empresa[1, i];

    if (Empresa[0, i] >= 23 && Empresa[0, i] <= 40)
    {
        SueldoTotal23y40 += Empresa[1, i];
    }

    if (Empresa[0, i] >= 30 && Empresa[1, i] < 1000)
    {
        MayoresA30++;
    }
}

int SueldoPromedio = SueldoTotal / Empresa.GetLength(1);
int SueldoPromedio23y40 = SueldoTotal23y40 / Empresa.GetLength(1);
int EdadPromedio = EdadTotal / Empresa.GetLength(1);

for (int i = 0; i < Empresa.GetLength(1); i++)
{
    if (Empresa[0, i] < EdadPromedio) { MenoresAlPromedio++; }
}

Console.WriteLine("El sueldo promedio es de: $" + SueldoPromedio);
Console.WriteLine("El sueldo promedio de los empleados entre 23 y 40 años es de: $" + SueldoPromedio23y40);
Console.WriteLine("La edad promedio es de: " + EdadPromedio);
Console.WriteLine("La cantidad de empleados mayores a 30 y con sueldo menor a $1000 es de: " + MayoresA30);
Console.WriteLine("La cantidad de empleados con edad menor al promedio es de: " +  MenoresAlPromedio);
