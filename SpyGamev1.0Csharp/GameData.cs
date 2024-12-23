using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpyGamev1._0Csharp
{
    internal class GameData
    {
        public static List<string> words = new List<string>() {"Cow", "Cat", "Dog", "Elephant", "Bee", "Snake", "Kangaro", "Lion"};
        public static List<Player> Players = new List<Player>();
        public static List<int> asker = new List<int>(), answerer = new List<int>();
        public static int TheCurrentPlayerindex = 0;
        public static int SpyIndex = 0;
        public static string ChoosenWord;


        

        public static void PreparePlyaersList()
        {
            //AddPlayer(
            //    new Player { Name = "plyr1", Score = 10, Avatar = Image.FromFile("avatar2.png") }
            //);
            //AddPlayer(
            //    new Player { Name = "plyr2", Score = 20, Avatar = Image.FromFile("avatar2.png") }
            //);
            //AddPlayer(
            //    new Player { Name = "plyr3", Score = 03, Avatar = Image.FromFile("avatar2.png") }
            //);
            //AddPlayer(
            //    new Player { Name = "plyr4", Score = 40, Avatar = Image.FromFile("avatar2.png") }
            //);
            //AddPlayer(
            //    new Player { Name = "plyr5", Score = 550, Avatar = Image.FromFile("avatar2.png") }
            //);
            //AddPlayer(
            //    new Player { Name = "plyr6", Score = 620, Avatar = Image.FromFile("avatar2.png") }
            //);
            

            for (int i = 0; i < Players.Count; i++)
            {
                asker.Add(i); answerer.Add(i);
            }
            Shuffle(asker);
            Shuffle(answerer);
            for (int i = 0; i < Players.Count; i++)
            {
                if (answerer[i] == asker[i])
                {
                    if (i == 0)
                        SwapInArray(answerer, 0, 1);
                    else
                        SwapInArray(answerer, i, i - 1);
                }
            }

            Random random = new Random();
            SpyIndex = random.Next(0, Players.Count);
            ChoosenWord = words[random.Next(0, words.Count)];
        }

        public static void Clear()
        {
            // Clear the players list
            Players.Clear();

            // Clear the asker and answerer lists
            asker.Clear();
            answerer.Clear();

            // Reset the other static variables
            TheCurrentPlayerindex = 0;
            SpyIndex = 0;
            ChoosenWord = string.Empty; // Or set to null if you prefer
        }
        static void SwapInArray<T>(List<T> array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        
        static void Shuffle(List<int> list)
        {
            Random random = new Random();
            int count = list.Count;

            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(i, count);
                // Swap elements
                int temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
        }

        public static void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
