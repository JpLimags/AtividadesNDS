namespace Struct;

public class Struct
{
    static void Main()
    {

        var Usuario1 = new Usuario("Jp", "Lima", 18, 1.70);
        
        Console.WriteLine($"Nome: {Usuario1.name} " + $"{Usuario1.lastName}, Idade{Usuario1.idade}, Altura{Usuario1.altura}" );
    }
}

struct Usuario
{
    public String name;
    public String lastName;
    public int idade;
    public double altura;

    public Usuario(String name, String lastName, int idade, double altura)
    {

        this.name = name;
        this.lastName = lastName;
        this.idade = idade;
        this.altura = altura;
    }
}