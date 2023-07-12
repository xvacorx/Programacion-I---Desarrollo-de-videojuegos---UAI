//4.Ingresar los lados de un rectángulo y calcula su perímetro (suma de todos los lados) e imprimirlo.

---------- SUMA -----------

Console.WriteLine("Ingrese Lado: ");
int Lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Lado 2: ");
int Lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Lado 3: ");
int Lado3 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Lado  4:  ");
int Lado4 = int.Parse(Console.ReadLine());

int SumaT = Lado1 + Lado2 + Lado3 + Lado4;

Console.WriteLine("El perimetro es: " + SumaT);


---------- MULTIPLO --------------

Console.WriteLine("Ingrese Base: ");
int Base = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Altura: ");
int Altura = int.Parse(Console.ReadLine());

int Perimetro = Altura * 2 + Base * 2;

Console.WriteLine("El perimetro es: " + Perimetro);
