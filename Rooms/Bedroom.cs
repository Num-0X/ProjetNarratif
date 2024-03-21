using System;

namespace ProjetNarratif.Rooms
{
    internal class Forest : Room
    {
        bool PickSword, PickArc, PickHoney;

        internal override string CreateDescription() =>
      @"Tu te retrouve dans un nouveau monde infesté de créature dangeureuses.
      À ton réveille, tu te retrouve dans la fôret. En te prommenant, tu vois un [homme] assomé et blessé sur un tronc d'arbre.
       Et un peu plus loin, à l'autre côté de la rivière séparée par un pont fragile, tu aperçois un [elfe] dans le même état que l'autre. Chacun d'eux porte une arme.
      L'homme porte une épée et l'autre un arc. Il sera toutefois risqué de vouloir les deux.
      Tu devra choisir lequel prendre en premier si tu veux te raprocher de ces deux personnages inconnus.

        ";
        

        internal override void  ReceiveChoice(string choice)
        {
           

            switch (choice)

            {

                case "homme":
                    
                    char option;
                   Game.épée = true;
                    Game.cuirasse = true;
                    Game.inventaire.Add("épée " + " cuirasse");
                   
                    Console.WriteLine("Tu te raprocche de l'humain. Tu t'équipes de son épée et de sa cuirasse. Le reste des ses équpements sont en piteux état."
                        + "Sûrement à cause d'un monstre!"+
                        "Tu gagne 5 point d'attaque et 5 point de défense");
                    {
                        Console.WriteLine(Game.Atk+ 10 + " Atk");
                        Console.WriteLine(Game.Déf + 10 + " Déf");
                    }

                    Console.WriteLine("\tEntrez '1' pour continuer ton chemin.\t Tap '2' pour risquer de traverser " +
                        "le pont pour allez récupérer l'arc de l'elfe");
                    Console.WriteLine("Entrez votre choix: ");
                    option= Convert.ToChar(Console.ReadLine());

                    switch (option)
                    {
                        case '1':
                            Game.Transition<HuntRoom>();

                            break;
                            
                        case '2':
                             Random random = new Random();
                            double chance = random.NextDouble();
                            if (chance < 0.9)
                            {
                                Console.WriteLine("Malgré le craquement des planches de bois, tu arrives à traverser de justesse");
                            }
                            else
                            {
                                Console.WriteLine("Arrivée vers la fin le pont s'éffondre.\n Tu perd des points de vie");
                            }


                            Console.WriteLine();
                            break;
                    }


                    
                    break;
                case "elfe":                   
                  {
                        Console.WriteLine("");
                       
                  }
                    break;
                case "grenier":
                    Console.WriteLine("Tu montes dans le grenier.");
                    Game.Transition<AtticRoom>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
