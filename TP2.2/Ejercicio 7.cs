//Ingresar un número de mes y mostrar el nombre de dicho mes.
//Si se ingresa un número de mes inválido, informar dicha situación con un mensaje aclaratorio.

Console.WriteLine("Ingrese número de mes");
int Mes = int.Parse(Console.ReadLine());

if (Mes == 1) { Console.WriteLine("El día es Enero"); }

else if (Mes == 2) { Console.WriteLine("El día es Febrero"); }

else if (Mes == 3) { Console.WriteLine("El día es Marzo"); }

else if (Mes == 4) { Console.WriteLine("El día es Abril"); }

else if (Mes == 5) { Console.WriteLine("El día es Mayo"); }

else if (Mes == 6) { Console.WriteLine("El día es Junio"); }

else if (Mes == 7) { Console.WriteLine("El día es Julio"); }

else if (Mes == 8) { Console.WriteLine("El día es Agosto"); }

else if (Mes == 9) { Console.WriteLine("El día es Septiembre"); }

else if (Mes == 10) { Console.WriteLine("El día es Octubre"); }

else if (Mes == 11) { Console.WriteLine("El día es Noviembre"); }

else if (Mes == 12) { Console.WriteLine("El día es Diciembre"); }

else { Console.WriteLine("El número ingresado es inválido"); }
