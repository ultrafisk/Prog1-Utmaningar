using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program   //Erik "Mr Hacker" Hacker
    {
        static char[] guess;
        static void Main(string[] args)
        {
            Game();
            //genererar ett slumpmässigt ord och returnerar det
            string WordList()
            {
                string[] words = new string[10];
                words[0] = "dreamweaver";
                words[1] = "boi";
                words[2] = "bread";
                words[3] = "breed";
                words[4] = "braid";
                words[5] = "brood";
                words[6] = "fishing";
                words[7] = "christ";
                words[8] = "squid";
                words[9] = "banana";

                Random rnd = new Random();
                string randomWord = words[rnd.Next(11)];
                return randomWord;
            }

            void Game()
            {
                Console.Write("----====||====----\nWelcome to Hangman!\nGuess wrong and ye shall be hanged!\nWhat word am I thinking of?\n");
                char[] chars = WordList().ToCharArray();    //konverterar ordet till en character array där varje bokstav är ett eget värde
                guess = new char[chars.Length];             //gör en ny array som är likadan som ovan men byter sedan ut alla karaktärer till understreck
                for (int i = 0; i < guess.Length; i++)
                {
                    guess[i] = '_';
                }
                for (int i = 5; i > 0; i--)
                {
                    Console.WriteLine($"You have {i} tries left.");
                    for (int j = 0; j < guess.Length; j++)  //skriver ut alla charactärer i guess[] + mellanrum
                    {
                        Console.Write(guess[j] + " ");
                    }
                    Console.WriteLine();
                    int win = 0;
                    char input;
                    bool inputParse = char.TryParse(Console.ReadLine(), out input);
                    if (!inputParse)
                    {
                        Console.WriteLine("u r an invalid, tri agein");
                        Game();
                    }
                    for (int j = 0; j < chars.Length; j++)  //kollar om gissningen är i char[] och om den är så byts den understrecket i guess[] på den platsen till bokstaven ur chars[]
                                                            //kollar även om det finns några understreck kvar i guess[], om inte så vinner man spelet
                    {
                        if (chars[j] == input)
                        {
                            guess[j] = chars[j];
                            i++;
                        }
                        if (guess[j] == '_')
                        {
                            win++;
                        }
                    }
                    if (win == 0)
                    {
                        Console.Write($"Congratz you guessed correctly.\nThe word was: ");
                        for (int j = 0; j < chars.Length; j++)
                        {
                            Console.Write(chars[j]);
                        }
                        Console.WriteLine();
                        Game();
                    }
                }
                Console.Write($"You have failed try again.\nThe word was: {chars}\n");
                Game();
            }

            Console.ReadLine();
        }
    }
}
