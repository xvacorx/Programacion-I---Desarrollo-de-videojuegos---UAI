//5. Determinar y exhibir si la estatura de una persona adulta dada,
//es mayor que la estatura media de las personas adultas de su sexo, siendo:
//estatura media de mujeres adultas: 1,65 m.
//y estatura media de varones adultos: 1,72 m.

Console.WriteLine("Ingrese altura:");
float Altura = float.Parse(Console.ReadLine());

Console.WriteLine("Ingrese sexo (H / M)");
char Sexo = char.Parse(Console.ReadLine());

if (Sexo == 'H' || Sexo == 'h')
{
    if (Altura > 1.72) { Console.WriteLine("La estatura está por encima del promedio"); }
    else { Console.WriteLine("La altura está por debajo del promedio"); }
}
else if (Sexo == 'M' || Sexo == 'm')
{
    if (Altura > 1.65) { Console.WriteLine("La estatura está por encima del promedio"); }
    else { Console.WriteLine("La altura está por debajo del promedio"); }
}
