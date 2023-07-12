//7. Ingresar el valor de la hora y el tiempo trabajado por un empleado,
//calcular su sueldo conociendo que recibe un premio de $ 100 si trabajo más de 50 hs
//y si trabajo más de 150 hs le dan otros $ 100 adicionales. Imprimir el sueldo

Console.WriteLine("Ingrese valor por hora");
int Valor = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de horas trabajadas");
int Horas = int.Parse(Console.ReadLine());

int Sueldo = Valor * Horas;

if (Horas > 50) { Sueldo += 100;
    if (Horas > 150) { Sueldo += 100; } }

Console.WriteLine("El empleado trabajó " + Horas + " horas");
Console.WriteLine("El sueldo del empleado es de: " +  Sueldo);
