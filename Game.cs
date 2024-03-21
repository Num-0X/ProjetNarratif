using ProjetNarratif.Rooms;

namespace ProjetNarratif
{
    internal class Game
    {
        List<Room> rooms = new();
        Room currentRoom;
        internal bool IsGameOver() => isFinished;
        static bool isFinished;
        static string nextRoom = "";
        internal static int HP = 50;
        internal static int Atk = 15;
        internal static int Déf = 10;

        internal static void LoseHealth()
        {
            if (Game.HP > 0) { Console.WriteLine(HP + "HP restant"); }
            else
            {
                Console.WriteLine("Tu es mort, car votre point de vie est tombée à zéro");
                Game.Finish();
            }
            if (Game.HP > 50) { AddHP();  }
            if (Game.Atk > 15) { AddAtk(); }
            if (Game.Déf > 10) { AddDéf(); }
        }
        internal static void AfficheStatus()
        {
            Console.WriteLine(Game.Atk + " Atk");
            Console.WriteLine(Game.Déf + " Déf");
        }
        static int AddHP()

        { return Game.HP + 25; }
        static int AddAtk() 
        {return Game.Atk + 10;}
        static int AddDéf()
        { return Game.Déf + 10; }

        internal static bool épée, arc, bouclier, cuirasse, casque, bottes, rayonmiel, viande, potion, pomme, fleurmédicinal;
        internal static string[] ObjetList = new string[10];
        internal static List <string> inventaire= new List<string>();
        internal static int ObjectCount;
        internal void Add(Room room)
        {
            rooms.Add(room);
            if (currentRoom == null)
            {
                currentRoom = room;
            }
        }

        internal string CurrentRoomDescription => currentRoom.CreateDescription();

        internal void ReceiveChoice(string choice)
        {
            currentRoom.ReceiveChoice(choice);
            CheckTransition();
        }

        internal static void Transition<T>() where T : Room
        {
            nextRoom = typeof(T).Name;
        }

        internal static void Finish()
        {
            isFinished = true;
        }

        internal void CheckTransition()
        {
            foreach (var room in rooms)
            {
                if (room.GetType().Name == nextRoom)
                {
                    nextRoom = "";
                    currentRoom = room;
                    break;
                }
            }
        }
    }
}
