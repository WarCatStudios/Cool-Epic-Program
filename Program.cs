using System;
using System.Collections.Generic;
namespace Cool_Epic_Program
{
    class Program
    {
        static void Main(string[] args)
        {
           // 1st & 2nd video (beginning & varibles)
            Console.Title = "Super Epic Cool Program";
            Console.ForegroundColor  = ConsoleColor.Green;
            
            Console.WriteLine("Hello, I am a cool epic program. What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Cool, nice to meet you " + userName + " do you want to press the button y/n?");
            
            //3rd video (conditions)

            string choice = Console.ReadLine();

           if (choice == "y")
           {
               Console.WriteLine("You can now buy the omega DLC which costs $10");
               Console.WriteLine("how much cash do you imput?:");
           }
            else
            {
               Console.ForegroundColor = ConsoleColor.Red;
               
                Console.WriteLine("you can close the program now");
            }

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 10)
            {
                Console.WriteLine("Thats not enough to buy the Omega DLC!");
            }
            else if (cash == 10)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("here is the Omega DLC, it just makes the text blue!");
            }
             else 
            {
                int change = cash - 10;
                Console.ForegroundColor = ConsoleColor.Blue;
               
                Console.WriteLine("here is the Omega DLC, it just makes the text blue!  Also here is your extra money: " + change + " dollars");
            }

            Console.WriteLine("ALSO SUPRISE QUIZ!!!");
            Console.WriteLine("Which content creator below creates content related to c#? (answer with the corresponding letter)");
            Console.WriteLine("A. Mark Rober");
            Console.WriteLine("B. Michael Reeves");
            Console.WriteLine("C. The Dev King");
            Console.WriteLine("D. Dani");

            string answer = Console.ReadLine();

            switch (answer) {

                case "a":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                break;
                case "b":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                break;
                case "c":
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                break;
                case "d":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct");
                break;
                default:
                Console.WriteLine("Enter an actual answer (make sure the letter is in lowercase)");
                break;
            }

            Console.ForegroundColor = ConsoleColor.Blue; //4th Video (loops)

            Console.ReadKey();
            Console.WriteLine("how high do you want the power of 2 to be? (insert a number)");
            int num = Convert.ToInt32(Console.ReadLine());
            

            for (int i = 1; i <= num; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ForegroundColor = ConsoleColor.Green; 
            Console.ReadKey();    
            Console.WriteLine("lets play a dice game, and see how long until we get 6. (press enter to roll)");

            Random numberGen = new Random();

            int roll = 0;
            int attempt = 0;

            while(roll != 6) {
                
                Console.ReadKey(); 
                roll = numberGen.Next(1, 7);
                Console.WriteLine("you rolled: " + roll);
                attempt++;

            }

            Console.WriteLine("It took you " + attempt + " attempts to roll a six.");
            
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Blue; //5th video (arrays)
            
            Console.WriteLine("Here is a list of my top 5 favorite video games.");

            string[] games = {"Minecraft","Team Fortress 2","Animal Crossing: New Horizons","Roblox","Legend Of Zelda: Breath Of The Wild"};

            for (int i = 0; i < games.Length; i++)
            {
              Console.ReadKey();
              int rank = i + 1;
              Console.WriteLine( rank + ". " + games[i]);  
            }
            
            
            Console.WriteLine("Now you Imput your top 5 favorite video games in order decending. (press enter to register the option)");
            string[] userFavs = new string[5];
            
            userFavs[0] = Console.ReadLine();
            userFavs[1] = Console.ReadLine();
            userFavs[2] = Console.ReadLine();
            userFavs[3] = Console.ReadLine();
            userFavs[4] = Console.ReadLine();
           Console.WriteLine("You have imputed all your favorite games now press space to show your leaderboard!");
           Console.ReadKey();
           
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("*" + userName + "'s game leaderboard*");


           for (int e = 0; e < userFavs.Length; e++)
           {   
               int userRank = e + 1;
              Console.WriteLine( userRank + ". " + userFavs[e]);
           }

            Console.WriteLine("--------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("I also have a list of my favorite YouTubers.");
             
             List<string> YTlist = new List<string>();

             YTlist.Add("Dani");
             YTlist.Add("MumboJumbo");
             YTlist.Add("DangerouslyFunny");
             YTlist.Add("UncleDane");
             YTlist.Add("Brakeys");

             for (int i = 0; i < YTlist.Count; i++)
             {
                 Console.WriteLine(YTlist[i]);
             }
             
             Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("I made this thing that randomly generates 3 SCP(s) press enter to get your 3!");
            Console.ReadKey();

            Console.WriteLine("----------------");
            SCP();
            Console.WriteLine("----------------");
            SCP();
            Console.WriteLine("----------------");
            SCP();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Im changing it back to green");
            
            Console.WriteLine("Imput two numbers you want to multiply");
            Console.WriteLine("First Number");
            int num03 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number");
            int num04 = Convert.ToInt32(Console.ReadLine());
            
            multiply(num03, num04);

            
            
            
            
            
            
            Console.ReadKey();
        }
        static void SCP()
        {
          Random numberGenTwo = new Random();

          string objectNum = "SCP-" + numberGenTwo.Next(1, 1000);

          Console.WriteLine("The SCP that was choosen was " + objectNum);

        }

        static void multiply(int num01, int num02)
        {
            int product = num01 * num02;
            Console.WriteLine("The result is: " + product);



          
