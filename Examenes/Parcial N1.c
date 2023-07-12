//1.Calcular el sueldo de una persona conociendo la cantidad de horas que trabajó en el mes
//y el valor de la hora trabajada.


Console.WriteLine("Ingrese valor de la hora:");
int Valor = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de horas:");
int Horas = int.Parse(Console.ReadLine());

int Sueldo = Valor * Horas;

Console.WriteLine("El sueldo es de: $" + Sueldo);




//2.Dados dos números enteros distintos, mostrarlos ordenados de forma creciente.


Console.WriteLine("Ingrese primer número:");
int Numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo número:");
int Numero2 = int.Parse(Console.ReadLine());

if (Numero1 > Numero2) { Console.WriteLine("Ordenando de forma creciente quedaría: " + Numero2 + ", " + Numero1); }
else if (Numero2 > Numero1) { Console.WriteLine("Ordenando de forma creciente quedaría: " + Numero1 + ", " + Numero2); }
else { Console.WriteLine("Los números ingresados son iguales"); }




//3.a)Un profesor desea saber cuál será la calificación final de un alumno.
//La calificación final se calcula sabiendo los siguientes datos:
//60 % corresponde al examen escrito.
//25% corresponde a trabajos prácticos.
//15% corresponde a las tareas.
//Se sabe que la calificación ingresada de cada evaluación, es un valor entre 1 y 10


Console.WriteLine("Ingrese nota del examen escrito:");
double Examen = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese nota promedio de los trabajos prácticos:");
double Trabajos = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese nota promedio de las tareas:");
double Tareas = double.Parse(Console.ReadLine());

double NotaFinal = (Examen * 0.6) + (Trabajos * 0.25) + (Tareas * 0.15);

Console.WriteLine("La nota final del alumno es de: " + NotaFinal);


//3.b)Mostrar por consola si el alumno aprobó la materia.
//Para eso, el alumno deberá sacar una nota mayor o igual a 6.

if (NotaFinal >= 6) { Console.WriteLine("El alumno aprobó la asignatura"); }
else { Console.WriteLine("El alumno reprobó la materia"); }




//4.Una verdulería ofrece descuentos en base a la siguiente tabla:
//Kilos                 Descuento
//2-3                   10%
//4-6                   20%
//7 o más               35%


Console.WriteLine("Ingrese precio del producto:");
int Precio = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese cantidad de Kilos");
int Kilos = int.Parse(Console.ReadLine());

if (Kilos > 1 && Kilos < 4)
{
    int Total = (Precio * Kilos) * 0.9;
    Console.WriteLine("El descuento aplicado es del 10%");
    Console.WriteLine("El precio total es de: " + Total);
}

else if (Kilos > 3 && Kilos < 7)
{
    int Total = (Precio * Kilos) * 0.8;
    Console.WriteLine("El descuento aplicado es del 20%");
    Console.WriteLine("El precio total es de: " + Total);
}

else if (Kilos > 6)
{
    int Total = (Precio * Kilos) * 0.65;
    Console.WriteLine("El descuento aplicado es del 35%");
    Console.WriteLine("El precio total es de: " + Total);
}

else
{
    int Total = Precio * Kilos;
    Console.WriteLine("No es aplicable para un descuento");
    Console.WriteLine("El precio total es de: " + Total);
}




//5.En un circuito eléctrico hay tres interruptores, los cuales pueden estar prendidos(1) o apagados(0).
//Para que un equipo funcione, se requiere que al menos dos interruptores estén apagados.
//Suponiendo que los datos ingresados por el usuario son los estados de los
//interruptores(1 o 0),mostrar por pantalla si el equipo funciona o no.


Console.WriteLine("Ingrese estado del primer interruptor (1 / 0):");
int Interruptor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese estado del segundo interruptor (1 / 0):");
int Interruptor2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese estado del tercer interruptor (1 / 0):");
int Interruptor3 = int.Parse(Console.ReadLine());

if (Interruptor1 + Interruptor2 + Interruptor3 == 1) { Console.WriteLine("El equipo está encendido"); }
else { Console.WriteLine("El equipo está apagado"); }
