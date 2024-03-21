using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class HuntRoom: Room
    {
        internal override string CreateDescription() =>
@"Tu continues ton chemin. Soudainement, tu vois un [goblin] devant toi.
Tu te demande si tu voudrai l'affronter pour augenter tes points d'expériences.
Tu vois à gauche une rûche d'abeille.Tu pourrai récolter un rayon de [miel] de bonne qualité.


";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "bain":
                    Console.WriteLine("Tu te laisses relaxer dans le bain.");
                    break;
                case "miroir":
                    Console.WriteLine("Tu aperçois les chiffres 2314 écrits sur la brume sur le miroir.");
                    break;
                case "chambre":
                    Console.WriteLine("Tu retournes dans ta chambre.");
                    Game.Transition<Forest>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
    

