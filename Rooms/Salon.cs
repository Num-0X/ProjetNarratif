using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Salon:Room
    {
        internal override string CreateDescription() =>
        @"Tu te trouve au Salon. Il y a un bon [sofa] neuf que tes parents t'on interdient de t'asseoir
          devant la belle télévision sans fil. Elle ressemble à un siège pour un roi.
        La [cuisine] se trouve à ta gauche.
        Sur ton bureau, tu aperçois une [photo]";
        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "sofa":
                    Console.WriteLine("Tu te retrouves assis sur le sofa");
                    Console.WriteLine("Quelque minutes plutard de bonne relaxation, tu réalise que tu n'arrive pas" +
                        "\t à te lever du siège. La télé qui semble tout à fait normale s'allume toute seule devant toi!");
                    Console.WriteLine("La télécommande se trouvait nul pars au salon");
                    break;
                    
                case "cuisine": 
                    Console.WriteLine("Tu arrive dans la cuisine pour déjeuner.");
                    Console.WriteLine("Tu récupères de l'endurance");
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }

            }
        }
    }

