namespace _8._5___Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int subject;
            subject = generator.Next(1, 5);
            string word = "PICKLE";
            string displayWord = "______";

            if (subject == 1) 
            {
                word = "FISH";
                displayWord = "____";
            }

            else if (subject == 2)
            {
                word = "PICKLE";
                displayWord = "______";
            }

            else if (subject == 3)
            {
                word = "EXPLOSION";
                displayWord = "_________";
            }

            List <char> letters = new List<char>();
            bool done = false;
            int wrongdoings = 0;
            int draw = 0;
            int tempLength = word.Length;
            string choice;
            String mod;
            

            Console.WriteLine("Hello, would you like to play a game? No? Too bad!");
            Console.WriteLine("We're playing hangman, you have 3 guess, lets go!");

            
            while (!done)
            {
                

                if (draw == 0)
                {
                    Console.WriteLine("  +---+  ");
                    Console.WriteLine("  |   |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("=========");
                    Console.WriteLine(displayWord);
                    Console.WriteLine($"You currently have guessed wrong {draw} times.");
                    string guess = Console.ReadLine().ToUpper();
                    if (word.Contains(guess))
                    {
                        for (int i = 0; i < tempLength; i++)
                        {
                            if (word[i] == guess[0])


                            {
                                displayWord = displayWord.Remove(i, 1);
                                displayWord = displayWord.Insert(i, guess);
                            }
                        }

                        Console.WriteLine("Correct, you guess a letter right.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        draw += 1;
                        Console.WriteLine("Wrong, try again. Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();

                    }
                }

                else if (draw == 1)
                {
                    Console.WriteLine("  +---+  ");
                    Console.WriteLine("  |   |  ");
                    Console.WriteLine("  O   |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("=========");
                    Console.WriteLine(displayWord);
                    Console.WriteLine($"You currently have guessed wrong {draw} times.");
                    string guess = Console.ReadLine().ToUpper();
                    if (word.Contains(guess))
                    {
                        for (int i = 0; i < tempLength; i++)
                        {
                            if (word[i] == guess[0])


                            {
                                displayWord = displayWord.Remove(i, 1);
                                displayWord = displayWord.Insert(i, guess);
                            }
                        }

                        Console.WriteLine("Correct, you guess a letter right.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        draw += 1;
                        Console.WriteLine("Wrong, try again. Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();

                    }
                }

                else if (draw == 2)
                {
                    Console.WriteLine("  +---+  ");
                    Console.WriteLine("  |   |  ");
                    Console.WriteLine("  O   |  ");
                    Console.WriteLine(" /|\\  |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("=========");
                    Console.WriteLine(displayWord);
                    Console.WriteLine($"You currently have guessed wrong {draw} times.");
                    string guess = Console.ReadLine().ToUpper();
                    if (word.Contains(guess))
                    {
                        for (int i = 0; i < tempLength; i++)
                        {
                            if (word[i] == guess[0])


                            {
                                displayWord = displayWord.Remove(i, 1);
                                displayWord = displayWord.Insert(i, guess);
                            }
                        }

                        Console.WriteLine("Correct, you guess a letter right.");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        draw += 1;
                        Console.WriteLine("Wrong, try again. Press enter to continue.");
                        Console.ReadLine();
                        Console.Clear();

                    }
                }

               

                if (draw == 3)
                {
                    done = true;
                    Console.WriteLine("  +---+  ");
                    Console.WriteLine("  |   |  ");
                    Console.WriteLine("  O   |  ");
                    Console.WriteLine(" /|\\  |  ");
                    Console.WriteLine(" / \\  |  ");
                    Console.WriteLine("      |  ");
                    Console.WriteLine("=========");

                    Console.WriteLine("Oh, you lost!");
                    Console.WriteLine($"The word was {word}.");
                

                }

                if (displayWord == word)
                {
                    done = true;
                    Console.WriteLine("Good job, you won!");
                    Console.WriteLine("See you next time.");
                }

                


            }
        }
    }
}