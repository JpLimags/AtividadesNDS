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
                
                Console.WriteLine("Você escolheu  a classe: Guerreiro");
                //Criar a "instância" da struct
                break;
            }

            case 2:
            {
                
                Console.WriteLine("Você escolheu  a classe: Arqueiro");
                //Criar a "instância" da struct
                break;
            }
            
            case 3:
            {
                
                Console.WriteLine("Você escolheu  a classe: Assassino");
                //Criar a "instância" da struct
                break;
            }
            
            case 4:
            {
                
                Console.WriteLine("Você escolheu  a classe: Guerreiro");
                //Criar a "instância" da struct
                break;
            }
        }    
    }
    
    public static void Guerreiro()
    {
    
    }

    public static void Assassino()
    {
    
    }

    public static void Arqueiro()
    {
        
        
    }
}

