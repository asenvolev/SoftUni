using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var dict = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                if (input[0] == "JOKER")
                {
                    break;
                }
                //ADDtoDict
                var cards = input[1].Split(',').ToList();
                cards.TrimExcess();
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], cards);
                }
                else
                {
                    dict[input[0]].AddRange(cards);
                }
                input = Console.ReadLine().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var player in dict)
            {
                Console.Write(player.Key + ": ");
                int playerScore = 0;

                foreach (var cards in player.Value.Distinct())
                {
                    int currentCardScore = 0;

                    char number = cards[1];
                    char letter = cards[2];
                    switch (number)
                    {
                        case '2':
                            currentCardScore = 2;
                            break;
                        case '3':
                            currentCardScore = 3;
                            break;
                        case '4':
                            currentCardScore = 4;
                            break;
                        case '5':
                            currentCardScore = 5;
                            break;
                        case '6':
                            currentCardScore = 6;
                            break;
                        case '7':
                            currentCardScore = 7;
                            break;
                        case '8':
                            currentCardScore = 8;
                            break;
                        case '9':
                            currentCardScore = 9;
                            break;
                        case '1':
                            currentCardScore = 10;
                            letter = cards[3];
                            break;
                        case 'J':
                            currentCardScore = 11;
                            break;
                        case 'Q':
                            currentCardScore = 12;
                            break;
                        case 'K':
                            currentCardScore = 13;
                            break;
                        case 'A':
                            currentCardScore = 14;
                            break;
                        default:
                            break;
                    }
                    switch (letter)
                    {
                        default:
                            break;
                        case 'S':
                            currentCardScore *= 4;
                            break;
                        case 'H':
                            currentCardScore *= 3;
                            break;
                        case 'D':
                            currentCardScore *= 2;
                            break;
                        case 'C':
                            currentCardScore *= 1;
                            break;
                    }
                    playerScore += currentCardScore;
                }
                Console.WriteLine(playerScore);
            }
        }
    }
}
