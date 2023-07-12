//3. Ingresar los tres lados de un triángulo e indicar que tipo de triángulo es

Console.WriteLine("Ingrese primer lado del triángulo");
int L1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese segundo lado del triángulo");
int L2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese tercer lado del triángulo");
int L3  = int.Parse(Console.ReadLine());

if (L1 == L2 && L1 == L3) {
    Console.WriteLine("El triángulo es un triángulo equilatero"); }

else if (L1 != L2  && L1 != L3 && L2 != L3)
{
    Console.WriteLine("El triángulo es un triángulo escaleno"); }

else {
    Console.WriteLine("El triángulo es un triángulo isosceles"); }
