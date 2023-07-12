//3. En una empresa los empleados cobran un sueldo según la categoria, son 50 empleados y 3 categorías
//• Categoría 1 = $ 1500
//• Categoría 2 = $ 2000
//• Categoría 3 = $ 2500

//Al sueldo se le suman $ 100 por cada año trabajado.

//Si se ingresa el nombre, categoría y antigüedad de cada empleado, calcular

//• Cuántos empleados hay por categoría
//• Total de sueldos pagados por categoría
//• Sueldo promedio general
//• Sueldo máximo y a quién pertenece
//• Qué porcentuel sobre el total de sueldos representa cada total de sueldos de las categorías

object[,] Empresa = new object[4, 3];

int EmpleadosCategoria1 = 0;
int EmpleadosCategoria2 = 0;
int EmpleadosCategoria3 = 0;

int SueldoCategoria1 = 0;
int SueldoCategoria2 = 0;
int SueldoCategoria3 = 0;

int Categoria1 = 0;
int Categoria2 = 0;
int Categoria3 = 0;

int SueldoPromedio = 0;
int SueldoMaximo = 0;
string EmpleadoMaximo = "a";
int SueldoTotal = 0;


for (int i = 0; i < Empresa.GetLength(1); i++)
{
    Console.WriteLine("Ingrese Nombre del empleado");
    Empresa[0, i] = Console.ReadLine();

    Console.WriteLine("Ingrese categoría del empleado (1 - 3)");
    int Categoria = int.Parse(Console.ReadLine());
    Empresa[1, i] = Categoria;
    int Sueldo = 0;
    if (Categoria == 1) { Sueldo = 1500; }
    if (Categoria == 2) { Sueldo = 2000; }
    if (Categoria == 3) { Sueldo = 2500; }    

    Console.WriteLine("Ingrese antiguedad del empleado");
    int Antiguedad = int.Parse(Console.ReadLine());
    Empresa[2, i] = Antiguedad;
    Empresa[3, i] = (Antiguedad * 100) + Sueldo;
}// 0. Nombre | 1. Categoría | 2. Antiguedad | 3. Sueldo

for  (int i = 0; i < Empresa.GetLength(1); i++)
{
    SueldoTotal += (int)Empresa[3, i]; //suma de sueldo total

    if ((int)Empresa[3, i] > SueldoMaximo || SueldoMaximo == 0) {
        SueldoMaximo = (int)Empresa[3, i];
        EmpleadoMaximo = (string)Empresa[0, i];
    } //asignación sueldo maximo

    if ((int)Empresa[1, i] == 1) {
        EmpleadosCategoria1++;
        SueldoCategoria1 += (int)Empresa[3, i];
    }//contadores de empleados por categoría

    if ((int)Empresa[1, i] == 2) {
        EmpleadosCategoria2++;
        SueldoCategoria2 += (int)Empresa[3, i];
    }//contadores de empleados por categoría

    if ((int)Empresa[1, i] == 3) {
        EmpleadosCategoria3++;
        SueldoCategoria3 += (int)Empresa[3, i];
    }//contadores de empleados por categoría
}

SueldoPromedio = SueldoTotal / Empresa.GetLength(1);

Categoria1 = (SueldoCategoria1 * 100) / SueldoTotal;
Categoria2 = (SueldoCategoria2 * 100) / SueldoTotal;
Categoria3 = (SueldoCategoria3 * 100) / SueldoTotal;

Console.WriteLine("Resumen de los datos ingresados:");

Console.WriteLine("El promedio de sueldo general es de: $" + SueldoPromedio);

Console.WriteLine("Empleados categoría 1: " + EmpleadosCategoria1 + " con un total de $" + SueldoCategoria1 + ". Representando un " + Categoria1 + "% del total");
Console.WriteLine("Empleados categoría 1: " + EmpleadosCategoria2 + " con un total de $" + SueldoCategoria2 + ". Representando un " + Categoria2 + "% del total");
Console.WriteLine("Empleados categoría 1: " + EmpleadosCategoria3 + " con un total de $" + SueldoCategoria3 + ". Representando un " + Categoria3 + "% del total");

Console.WriteLine("El sueldo máximo fue de: $" + SueldoMaximo + " perteneciente a " + EmpleadoMaximo);
