namespace FirstProjectCSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o seu nome: ");
        string? myName = Console.ReadLine();

        Console.WriteLine($"Bem vindo, {myName}!");
    }
}
