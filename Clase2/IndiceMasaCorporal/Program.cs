// See https://aka.ms/new-console-template for more information
double BAJO = 18.4; // De 18.4 para abajo
double NORMAL = 18.5;
double SOBREPESO =  25.0;
double OBESIDAD = 30.0; // De 30.0 para arriba

Console.WriteLine("Ingrese su altura en cm");
string in1 = Console.ReadLine();

Console.WriteLine("Ingrese su peso en kg");
string in2 = Console.ReadLine();

int peso = int.Parse(in2);
int alturaCm = int.Parse(in1);
float alturaM = (float) alturaCm / 100;

double IMC = peso / Math.Pow(alturaM, 2);
string resultado;

if (IMC < NORMAL)
{
    resultado = "Bajo peso";
} else if (IMC >= NORMAL & IMC < SOBREPESO)
{
    resultado = "Peso normal";
} else if ( IMC >= SOBREPESO & IMC < OBESIDAD)
{
    resultado = "Sobrepeso";
} else
{
    resultado = "Obesidad";
}

Console.WriteLine("Su Indice de masa corporal es: {0}", IMC);
Console.WriteLine("Categoría: {0}", resultado);