//5.Ingresar dos lados de un triángulo rectángulo y calcular:
//la hipotenusa , el perímetro, la superficie e imprimir los resultados.

---------- Solo  int--------

Console.WriteLine("Ingrese primer lado: ");
int Cateto1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo lado: ");
int Cateto2 = int.Parse(Console.ReadLine());

int Hipotenusa2 = Cateto1 * Cateto1 + Cateto2 * Cateto2;
int Hipotenusa = (int)Math.Sqrt(Hipotenusa2);

int Perimetro = Cateto1 + Cateto2 + Hipotenusa;

int Superficie = (Cateto1 * Cateto2) / 2;

Console.WriteLine("La hipotenusa mide: " + Hipotenusa);
Console.WriteLine("El perímetro es de: " + Perimetro);
Console.WriteLine("La superficie es de: " + Superficie);


------- Con float---------

Console.WriteLine("Ingrese primer lado: ");
float Cateto1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo lado: ");
float Cateto2 = float.Parse(Console.ReadLine());

float Hipotenusa2 = Cateto1 * Cateto1 + Cateto2 * Cateto2;
float Hipotenusa = (float)Math.Sqrt(Hipotenusa2);

float Perimetro = Cateto1 + Cateto2 + Hipotenusa;

float Superficie = (Cateto1 * Cateto2) / 2;

Console.WriteLine("La hipotenusa mide: " + Hipotenusa);
Console.WriteLine("El perímetro es de: " + Perimetro);
Console.WriteLine("La superficie es de: " + Superficie);


---------Con Math.Pow----------

Console.WriteLine("Ingrese primer lado: ");
float Cateto1 = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo lado: ");
float Cateto2 = float.Parse(Console.ReadLine());


float Cateto12 = (float)Math.Pow(Cateto1,2);
float Cateto22 = (float)Math.Pow(Cateto2, 2);

float Hipotenusa2 = Cateto12 + Cateto22;
float Hipotenusa = (float)Math.Sqrt(Hipotenusa2);

float Perimetro = Cateto1 + Cateto2 + Hipotenusa;

float Superficie = (Cateto1 * Cateto2) / 2;

Console.WriteLine("La hipotenusa mide: " + Hipotenusa);
Console.WriteLine("El perímetro es de: " + Perimetro);
Console.WriteLine("La superficie es de: " + Superficie);
