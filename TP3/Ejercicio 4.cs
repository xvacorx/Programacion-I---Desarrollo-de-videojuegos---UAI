//4. Ingresar 30 valores. Contar cuantos están entre 1 y 10,
//cuantos entre 10 y 20, cuantos entre 20 y 30 y cuantos son mas de 30.
//Luego mostrar el porcentaje de cada grupo en el total.

int Entre1y10 = 0;
int Entre10y20 = 0;
int Entre20y30 = 0;
int MayorA30 = 0;

Console.WriteLine("Ingrese 30 números");

for (int i = 0; i < 30; i++)
{
    int Valor = int.Parse(Console.ReadLine());

    if (Valor > 0 && Valor < 10) { Entre1y10++; }

    else if (Valor >= 10 && Valor < 20) { Entre10y20++; }

    else if (Valor >= 20 && Valor < 30) { Entre20y30++; }

    else if (Valor >= 30) { MayorA30++; }
}

double Porcentaje1 = ((double)Entre1y10 / 30.0) * 100;
double Porcentaje2 = ((double)Entre10y20 / 30.0) * 100;
double Porcentaje3 = ((double)Entre20y30 / 30.0) * 100;
double Porcentaje4 = ((double)MayorA30 / 30.0) * 100;

Console.WriteLine("Los números ingresados fueron los siguientes: ");
Console.WriteLine("La cantidad entre 1 y 10 fue de: " + Entre1y10 + ", y representa el " + Porcentaje1 + "%");
Console.WriteLine("La cantidad entre 10 y 20 fue de: " + Entre10y20 + ", y representa el " + Porcentaje2 + "%");
Console.WriteLine("La cantidad entre 20 y 30 fue de: " + Entre20y30 + ", y representa el " + Porcentaje3 + "%");
Console.WriteLine("La cantidad mayor a 30 fue de: " + MayorA30 + ", y representa el " + Porcentaje4 + "%");
