using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class MorningRoom : Room
    {
        internal override string CreateDescription() =>
@"Tu te lève ce matin dans ta chambre.
La [porte] qui mène au salon est devant toi.
Sur ton bureau, tu aperçois une [photo]
La salle de [bain] se trouve à ta gauche
";
        internal static int HP = 30;
        internal static int Atk = 15;
        internal static int Déf = 10;

        internal static void LoseHealth()
        {
            if (HP > 0) { Console.WriteLine(HP + "HP restant"); }
            else
            {
                Console.WriteLine("Tu es mort");
                Game.Finish();
            }
        }




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


                case "bain":
                    Console.WriteLine("Tu entre dans la salle de bain pour te doucher");
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}




