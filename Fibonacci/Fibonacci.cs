namespace Fibonacci;

public class Fibonacci
{

    static void Main()
    {

        int termo;
        int ultimo = 1;
        int penultimo = 0;
        
        Console.WriteLine("Digite a quantidade de números que deseja imprimir:");
        int num = int.Parse(Console.ReadLine()!);

        int n = 0;
        
        while (n < num)
        {
            
            Console.WriteLine(ultimo);
            termo = ultimo + penultimo;
            penultimo = ultimo;
            ultimo = termo;
            n++;
        }
        
        

        //FibonacciMethod(num);
    }
    
    /*public static void FibonacciMethod(int num)
    {
        int anterior = 1;
        int aux = 1;

        for (int prox = 1; prox < num+1; prox++)
        {   
            
            
        }
    }*/
}