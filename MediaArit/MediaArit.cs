namespace MediaArit;

public class MediaArit
{

    static void Main()
    {
        Console.WriteLine("Digite a primeira nota do aluno: ");
        float nota1 = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite a segunda nota do aluno: ");
        float nota2 = int.Parse(Console.ReadLine()!);
        
        CalculaMedia(nota1, nota2);
    }

    public static void CalculaMedia(float nota1, float nota2)
    {

        float media = (nota1 + nota2)/ 2;
        Console.WriteLine($"A média aritmética das notas {nota1} e {nota2} foi: {media}");
    } 
}