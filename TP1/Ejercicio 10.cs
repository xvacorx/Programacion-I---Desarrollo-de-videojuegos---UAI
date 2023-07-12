//10.Una Concesionaria de autos desea liquidar el sueldo a cada vendedor pagando $500 por mes
//más un plus del 10% del precio sobre cada auto vendido
//y un valor con constante de $50 pesos por cada uno de ellos
//se ingresa un valor del vehículo y la cantidad de ese vehículo que vendió
//calcular el sueldo e imprimirlo

Console.WriteLine("Ingresar valor del vehiculo:"); 
float Valor = float.Parse(Console.ReadLine()); 

Console.WriteLine("Ingresar cantidad de vehiculos:"); 
float Cantidad = float.Parse(Console.ReadLine());

double Sueldo = 500 + Valor * 0.1 + 50 * Cantidad;

Console.WriteLine("Su sueldo es de: " + Sueldo);
