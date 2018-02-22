using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main()
        {
            string guy = "\\O/\n |\n /\\";
            string start = " ";
            words word = new words();
            string MyWord = word.deal();
            int MyWordnum = MyWord.Length;
            string Hidden = MyWordnum.ToString();
            bool IsGameOver = false;
            int Strikes = 0;
            
            
            






            Console.WriteLine("Type go to start!");

            start = Console.ReadLine();
            if (start == "go")
            {
                StringBuilder exes = new StringBuilder("");
                for(int i = 0; i<MyWordnum; i++)
                {

                    exes.Append("#");
                }
                
                
                Console.WriteLine(Hidden + "letters to be guessed");
                

                while (!IsGameOver)
                {
                    Console.WriteLine(exes.ToString());
                    Console.WriteLine("Guess a letter");
                    char guess = Console.ReadLine()[0];
                    bool isGuessCorrect = false;
                    for (int i = 0; i < MyWord.Length; i++)
                    {

                        if (guess == MyWord[i])
                        {

                            exes[i] = guess;
                            isGuessCorrect = true;
                            
                        }                
                       
                        
                    }

                    if (!isGuessCorrect)
                    {
                        Strikes++;
                    }
                    if(Strikes == 10)
                    {
                        IsGameOver = true;
                        Console.WriteLine("You Lose!  The Word Was " + MyWord);
                        Console.WriteLine(guy);
                    }
                    if(exes.ToString() == MyWord)
                    {
                        IsGameOver = true;
                        Console.WriteLine(MyWord);
                        Console.WriteLine("You Win!");
                    }
                        
                }

            }
            else
            {
                Console.WriteLine("oops");
            }


         

           
         
            
           

            Console.ReadLine();
        }

       
    }
}