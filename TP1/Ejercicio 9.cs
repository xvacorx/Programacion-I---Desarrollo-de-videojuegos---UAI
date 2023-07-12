//9.Ingresar el tiempo trabajado por un operario
//considerando que el valor de la hora es de $10 pesos,calcular su sueldo e imprimirlo.

Console.WriteLine("Ingresar cantidad de horas trabajadas:"); 
int Horas = int.Parse(Console.ReadLine()); 


int sueldo = Horas * 10; 

Console.WriteLine("Su sueldo es de :" + sueldo); 
