using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new MorningRoom());
game.Add(new Salon());
game.Add(new Forest());
game.Add(new HuntRoom());
game.Add(new Bathroom());
game.Add(new AtticRoom());



while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);

    
    
        if (Game.HP > 0) { Console.WriteLine(Game.HP + "HP restant"); }
        else
        {
            Console.WriteLine("Tu es mort car votre point de vie est tombée à zéro");
            Game.Finish();
        }
    {
        Console.WriteLine(Game.Atk + " Atk");
        Console.WriteLine(Game.Déf + " Déf");
    }
}

    Console.WriteLine("FIN");
Console.ReadLine();