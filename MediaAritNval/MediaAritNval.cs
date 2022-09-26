namespace MediaAritNval;

public class MediaAritNval
{
    static void Main()
    {
        float total = 0;
        int contNums = 0;
        
        Console.WriteLine(PrencherVetor(total, contNums));
    }

    public static float PrencherVetor(float total, int cont)
    {
   
        float nums;

        do
        {
            
            Console.WriteLine("Digite um número(Caso deseje sair digite 0):");
            nums = int.Parse(Console.ReadLine()!);
            cont++;
            if(nums != 0){
                total += nums;
            }
        }while (nums != 0);
        
        return total / (cont - 1);
            
        //Console.WriteLine(cont);
    }
}