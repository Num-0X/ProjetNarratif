using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class MorningRoom:Room
    {
        internal override string CreateDescription() =>
@"Tu te lève ce matin dans ta chambre.
La [porte] qui mène au salon est devant toi.
Sur ton bureau, tu aperçois une [photo]
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "photo":
                    Console.WriteLine("Tu regarde la photo de tes parents parties en voyage.");
                    Console.WriteLine("Tu es content de passez plus de temps libre sans te soucier de" +
                        "leur présence.");
                    break;
                    
                case "porte":
                    Console.WriteLine("Tu ouvre la porte.");
                    Game.Transition<Salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

