// Adivina qué numero está pensando la máquina
Random numero = new Random();
int dado = numero.Next(3)+1;

Console.WriteLine("Qué número estoy pensando?");
string texto = Console.ReadLine();
int intento = int.Parse(texto);

if(intento == dado)
{
    Console.WriteLine("Adivinaste! Es {0}!", dado);
} else 
{
    Console.WriteLine("No adivinaste. El número que pensaba es: {0}", dado);
}

