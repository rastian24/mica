// Dados: El que saca el mayor número gana
Random aleatorio = new Random();
int compu = aleatorio.Next(6)+1;
int jugador =  aleatorio.Next(6)+1;

Console.WriteLine("Presioná cualquier tecla para tirar los dados!");
Console.ReadKey();

Console.WriteLine("Computadora: {0}", compu);
Console.WriteLine("Jugador: {0}", jugador);

if(jugador > compu)
{
    Console.WriteLine("Ganaste!!!");
} else if(jugador == compu)
{
    Console.WriteLine("Empataron");
} else
{
    Console.WriteLine("Perdiste");
}

