//12.Calcular la superficie y volumen del cilindro dados su altura y radio de la base

Console.WriteLine("Ingrese radio de la base:");
float Radio = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese altura del cilindro:");
float Altura = float.Parse(Console.ReadLine());

double Area = 2 * Math.PI * Radio * Altura + 2 * Math.PI * Math.Pow(Radio,2);
double Volumen = Math.PI * Math.Pow(Radio,2) * Altura;

Console.WriteLine("El área del cilindro es de: " +  Area);
Console.WriteLine("El volumen del cilindro es de: " +  Volumen);
