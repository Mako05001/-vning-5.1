Console.WriteLine("Hur många mening vill du skriva?");
int Tot = int.Parse(Console.ReadLine());
string[] N = new string[Tot];
for (int i = 0; i < Tot; i++)
{
    Console.WriteLine("Skriv en mening");
    N[i] = Console.ReadLine();
}
for (int i = 0; i < Tot; i++)
{
    Console.WriteLine(N[i]);
    Console.WriteLine();
}
