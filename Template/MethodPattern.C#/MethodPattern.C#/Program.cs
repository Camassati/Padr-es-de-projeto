

using MethodPattern.C_;
using System.Linq.Expressions;

public class Program
{
    public static void Main()

    {
        Console.WriteLine("Menu principal do noso jogo.");
        Console.WriteLine("Selecione o tipo de jogo");
        Console.WriteLine("1 - Casual, 2 - Competitivo");

        string? userInput = Console.ReadLine();
        if (userInput != null)
        {
            try
            {
                int gameType = int.Parse(userInput);
                switch (gameType)
                {
                    case 1:
                        new CasualGame().PlayGame();
                        break;
                    case 2:
                        new CompetitiveGame().PlayGame();
                        break;
                    default:
                        Console.WriteLine($"Opção [{gameType}]selecionada é invalida.");
                        break;
                }
            }
            catch 
            { 
                Console.WriteLine("Não foi possivel iniviar o jogo!");

            }
        }
        else
        {
            Console.WriteLine("Você não selecionou nenhuma opção!");
        }
    }
}

