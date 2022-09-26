namespace  MaiorMenor;

public class MaiorMenor
{
    public static void Main()
    {
        var nums = new int[3];
        PreencheVetor(nums);
        VerificaMaiorMenor(nums);
    }

    static int PreencheVetor(int[] nums)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Informe o {i+1}º número");
            nums [i] = int.Parse(Console.ReadLine()!);
        }

        return 0;
    }

    static void VerificaMaiorMenor(int[] nums)
    {
        int maior = 0;
        int menor = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (maior == 0 && menor==0)
            {
                maior = nums[i];
                menor = nums[i];

            }else if(nums[i] > maior)
            {
                maior = nums[i];
            }else if (nums[i] < menor)
            {
                menor= nums[i];
            }
        }
        
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"O maior valor entre {nums[0]}, {nums[1]}, {nums[2]} é {maior}");
        Console.WriteLine($"O menor valor entre {nums[0]}, {nums[1]}, {nums[2]} é {menor}");
    }
}