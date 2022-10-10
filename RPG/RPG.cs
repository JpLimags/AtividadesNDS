using System.ComponentModel.Design;

namespace RPG;

public class RPG
{

    static void Main()
    {

        Menu();
    }

    public static void Menu()
    {
        
        Console.Clear();
		
        Console.WriteLine("Bem vindo ao RPG");
        Thread.Sleep(1500);
        Console.WriteLine("Informe a classe que você deseja jogar:\n1- Guerreiro\n2- Arqueiro\n3- Assassino\n4- Mago\n0- Exit");

        int option = int.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 0:
            {
                Console.WriteLine("Saindo !");
                break;
            }

            case 1:
            {
                Guerreiro();
                break;
            }

            case 2:
            {

                Arqueiro();
                break;
            }
            
            case 3:
            {
                
                Assassino();
                break;
            }
            
            case 4:
            {
                
                Mago();
                break;
            }
        }    
    }
    
    public static void Guerreiro()
    {
        
        var guerreiro = new Heroi("Guerreiro", 250, 150);
        Console.WriteLine($"Você escolheu  a classe: {guerreiro.Classe}");
        Console.WriteLine($"Seus atributos são: Vida: {guerreiro.Vida}, Poder de Ataque: {guerreiro.PoderAtaque}");
        
        //Chamar struct invoca vilão
    }

    public static void Assassino()
    {
        
        var assassino = new Heroi("Assassino", 400, 250);
        Console.WriteLine($"Você escolheu  a classe: {assassino.Classe}");
        Console.WriteLine($"Seus atributos são: Vida: {assassino.Vida}, Poder de Ataque: {assassino.PoderAtaque}");
    }

    public static void Arqueiro()
    {
        var arqueiro = new Heroi("Arqueiro", 350, 200);
        Console.WriteLine($"Você escolheu  a classe: {arqueiro.Classe}");
        Console.WriteLine($"Seus atributos são: Vida: {arqueiro.Vida}, Poder de Ataque: {arqueiro.PoderAtaque}");
        //Chamar invoca vilão
    }

    public static void Mago()
    {
        
        var mago = new Heroi("Mago", 700, 680);
        Console.WriteLine($"Você escolheu  a classe: {mago.Classe}");
        Console.WriteLine($"Seus atributos são: Vida: {mago.Vida}, Poder de Ataque: {mago.PoderAtaque}");
    }

    public static void InvocaVilao()
    {
        
    }

    struct Heroi
    {
        public Heroi(string classe, int vida, int poderAtaque)
        {

            Classe = classe;
            Vida = vida;
            PoderAtaque = poderAtaque;
        }

        public string Classe { get; set;}
        public int Vida { get; set;}
        public int PoderAtaque { get; set;}
    }

    struct Vilao
    {
        public Vilao(string nome, int vida, int poderDeAtaque)
        {

            Nome = nome;
            Vida = vida;
            PoderAtaque = poderDeAtaque;
        }
        
        public string Nome{ get; set;}
        public int Vida { get; set; }
        public int PoderAtaque { get; set; }
    }

}

