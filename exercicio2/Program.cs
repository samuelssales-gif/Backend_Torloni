Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("                  Seja Bem Vindo meu rei"               );
Console.WriteLine("-------------------------------------------------------");

double Palmeiras, Flamengo, Empate;

Console.WriteLine("Palmeiras fez quantos gols?");
Palmeiras = double.Parse(Console.ReadLine());

Console.WriteLine("Flamengo fez quantos gols?");
Flamengo = double.Parse(Console.ReadLine());

Empate = (Palmeiras - Flamengo) / 2; 

if (Palmeiras > Flamengo)
{
    Console.WriteLine("Palmeiras vence a partida!");
}
else if (Flamengo > Palmeiras)
{
    Console.WriteLine("Flamengo vence a partida!");
}
else
{
    Console.WriteLine("Jogo empatado entre o rubro-negro e o alviverde!");
}
