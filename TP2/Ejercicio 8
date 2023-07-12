//8.Ingresar tres valores correspondientes al día, mes y año de una fecha
//indicar si es válida, considerar los años bisiestos

Console.WriteLine("Ingresar año: ");
int A1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresar mes: ");
int M1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresar día: ");
int D1 = int.Parse(Console.ReadLine());

DateTime T1 = new DateTime(A1, M1, D1);

if (DateTime.IsLeapYear(A1))
{
    Console.WriteLine("El año es bisiesto y la fecha está correcta");
}
else { Console.WriteLine("El año no es bisiesto y la fecha está correcta"); }


----------- Se puede realizar sin la función, utilizando la siguiente operación ------

if ((A1 / 4 != 0 && A1 / 100 != 0) || (A1 / 400 != 0)){
    Console.WriteLine("El año es bisiesto y la fecha está correcta"); }
else { Console.WriteLine("El año no es bisiesto y la fecha está correcta"); }
