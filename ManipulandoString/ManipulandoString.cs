using System.Text.RegularExpressions;

namespace ManipulandoString;

public class ManipulandoString
{
    static void Main()
    {
        
        Console.WriteLine("Digite seu nome completo: ");
        String Nome = Console.ReadLine()!;

        Console.WriteLine(Nome.Trim());
        Console.WriteLine(Nome.First());
        Console.WriteLine(Nome.ToLower());
        Console.WriteLine(Nome.ToUpper());
        Console.WriteLine(Nome.Insert(6,"Liminha"));
        Console.WriteLine(Nome.Replace(" ",""));
    }
}