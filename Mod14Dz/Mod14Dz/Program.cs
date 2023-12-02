using KartGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mod14Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Game game = new Game("Player1", "Player2");
            //game.PlayGame();

            //TASK 2
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> wordCount = CountWords(text);

            DisplayStatistics(wordCount);
        }

        static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }

        static void DisplayStatistics(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("| Слово          | Количество |");
            Console.WriteLine("|----------------|------------|");

            foreach (var kvp in wordCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"| {kvp.Key,-15} | {kvp.Value,-10} |");
            }
        }

    }

}
