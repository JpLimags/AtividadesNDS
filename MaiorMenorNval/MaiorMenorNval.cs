namespace MaiorMenorNval;

public class MaiorMenorNval
{

    static void Main()
    {

        int[] nums = new int[50];
        
        PreencheVetor(nums);
        VerificaMaiorMenor(nums);
    }

    static void PreencheVetor(int[] nums)
    {
        int i = 0;
        
        do
        {
            if (nums[i] != 0)
            {
                i++;
            }
            
            Console.WriteLine("Digite um número: ");
            nums[i] = int.Parse(Console.ReadLine()!);
        } while (nums[i] != 0);
        
    }

    static void VerificaMaiorMenor(int[] nums)
    {
        int maior = 0;
        int menor = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (maior == 0 && menor == 0)
            {
                maior = nums[i];
                menor = nums[i];

            }
            else if (nums[i] > maior)
            {
                if (nums[i] != 0)
                {
                    maior = nums[i];
                }
            }
            else if (nums[i] < menor)
            {
                if (nums[i] != 0)
                {
                    menor = nums[i];
                }
            }
        }
        
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"O maior valor digitado foi é {maior}");
        Console.WriteLine($"O menor valor digitado foi é {menor}");
    }
}