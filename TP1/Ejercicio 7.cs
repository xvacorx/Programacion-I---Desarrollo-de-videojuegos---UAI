//7.Ingresar el valor de la hora y el tiempo trabajado por un operario
//calcular su sueldo e imprimirlo.

Console.WriteLine("Ingrese valor de la hora: ");
int Valor = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
int Hora = int.Parse(Console.ReadLine());

int Sueldo = Valor * Hora;

Console.WriteLine("Su sueldo es de: " + Sueldo);
