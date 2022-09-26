namespace Tabuleiro;

public class Tabuleiro
{

    static void Main()
    {
        
        tabuleiro();
    }

    public static void tabuleiro()
    {
        
        Console.WriteLine("Digite a quantidade de linhas do tabuleiro");
        int m = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite a quantidade de colunas do tabuleiro");
        int n = int.Parse(Console.ReadLine()!);
        
        Console.Write("#");
        for (int i = 0; i < m; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");
        
        
        for (int i = 0; i < m; i++)
        {
            Console.Write("#");
            for (int j = 0; j < n; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("#");
        }
        
        Console.Write("#");
        for (int i = 0; i < m; i++)
        {
            Console.Write("#");
        }
        Console.WriteLine("#");
    }
}