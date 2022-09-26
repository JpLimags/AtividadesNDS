namespace ParOuImpar;

public class ParOuImpar
{
    static void Main()
    {

        Console.WriteLine("Digite um número:\n");
        int num1 = int.Parse(Console.ReadLine());

        ParOrImpar(num1);
    }

    static void ParOrImpar(int num)
    {

        if (num % 2 == 0)
        {
            Console.WriteLine($"O número {num} é par");
        }
        else
        {
            Console.WriteLine($"O numero {num} é ímpar");
        }
    }
}