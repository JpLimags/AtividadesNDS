namespace MediaPond;

public class MediaPond
{

    static void Main()
    {
        
        Console.WriteLine("Digite um valor: ");
        float num1 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite o peso da primeria nota: ");
        int peso1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite outro valor: ");
        float num2 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite o peso da segunda nota: ");
        int peso2 = int.Parse(Console.ReadLine()!);

        CalcMediaPond(num1, peso1, num2, peso2);
    }

    public static void CalcMediaPond(float n1, int p1, float n2, int p2)
    {

        float media = (((n1 * p1) + (n2 * p2)) / (p1 + p2));
        
        Console.WriteLine(media);
    }
}