//6. Ingresar un número de día y mostrar el nombre de dicho día.
//El día domingo se considera el primer día de la semana.
//Si se ingresa un número de día inválido, informar dicha situación con un mensaje aclaratorio.

Console.WriteLine("Ingrese número de día");
int Dia = int.Parse(Console.ReadLine());

if (Dia == 1) { Console.WriteLine("El día es Domingo"); }

else if (Dia == 2) { Console.WriteLine("El día es Lunes"); }

else if (Dia == 3) { Console.WriteLine("El día es Martes"); }

else if (Dia == 4) { Console.WriteLine("El día es Miércoles"); }

else if (Dia == 5) { Console.WriteLine("El día es Jueves"); }

else if (Dia == 6) { Console.WriteLine("El día es Viernes"); }

else if (Dia == 7) { Console.WriteLine("El día es Sábado"); }

else { Console.WriteLine("El número ingresado es inválido"); }
