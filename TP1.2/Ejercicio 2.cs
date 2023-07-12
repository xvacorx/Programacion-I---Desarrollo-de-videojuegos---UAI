//2.Calcular el área y volumen de una esfera conociendo el valor del radio. (A = 4 PI R2, V = 4 / 3 PI R3)

Console.WriteLine("ingrese radio de esfera: ");
float Radio = float.Parse(Console.ReadLine());

double Area = 4 * Math.PI * Math.Pow(Radio, 2);

double Volumen = 4 * Math.PI * Math.Pow(Radio, 3) / 3;

Console.WriteLine("El área es de: " + Area);
Console.WriteLine("El volumen es de: " + Volumen);
