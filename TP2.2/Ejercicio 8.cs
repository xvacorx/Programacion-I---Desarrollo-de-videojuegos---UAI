//8. Se desea convertir la calificaciones alfabéticas A, B, C, D y E
//a calificaciones numéricas 4, 5, 6, 7, y 8 respectivamente.
//En caso de ingresar cualquier otra letra, considerar que la calificación será 0.

Console.WriteLine("Ingrese calificación:");
char Nota  = char.Parse(Console.ReadLine());

if (Nota == 'A' || Nota == 'a') { Console.WriteLine("La nota numérica es 4"); }

else if (Nota == 'B' || Nota == 'b') { Console.WriteLine("La nota numérica es 5"); }

else if (Nota == 'C' || Nota == 'c') { Console.WriteLine("La nota numérica es 6"); }

else if (Nota == 'D' || Nota == 'd') { Console.WriteLine("La nota numérica es 7"); }

else if (Nota == 'E' || Nota == 'e') { Console.WriteLine("La nota numérica es 8"); }

else { Console.WriteLine("La nota numérica es 0"); }
