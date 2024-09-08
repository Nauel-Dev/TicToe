using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practice_script
{
    internal class Program
    {
        static string user;
        static string password;
        static int highScore = 900000;
        static string highscorePlayer = "buntok";
        static int inputNum = 0;
        static int[,] num = new int[,] {
          {1,2,3},
          {4,5,6},
          {7,8,9},

        };
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();



            //weather wear checker


            /*Console.WriteLine("what is the Weather level");
            string weather = Console.ReadLine();

            int curweather;
            int numwead;

            //converts string to int

            if(int.TryParse(weather, out numwead))
            {
                curweather = numwead;

            }
            else
            {
                curweather = 0;
            }



            if (curweather>=5)
            {
                Console.WriteLine("Get inside now its dangerous");

            }

           else if (curweather >= 4)
            {
                Console.WriteLine("DO you have life insurance?");

            }

            else if (curweather >= 3)
            {
                Console.WriteLine("close the door behind you");

            }

           else  if (curweather >= 2)
            {
                Console.WriteLine("its abit dangerous");

            }

           else if (curweather >= 1)
            {
                Console.WriteLine("Get out if you want");

            }

            else { Console.WriteLine("Invalid input");
            }

            */












            //average score calculator
            //create an input collector that moves on after each press of enter
            //make it so once -1 is entered the operation calcualates it
            /*
           int input = 0;
            int answer = 0;
            int total = 0;
            
            do
            {
                Console.WriteLine("Enter Number");
                string inputConvert=Console.ReadLine();
                 int.TryParse(inputConvert, out input);
               
                if (int.TryParse(inputConvert, out input)&& input>0 && input < 21) {

                    total += input;
                }
                else
                {
                    if (!input.Equals("-1"))
                    {
                        Console
                    }
                }




                    if (input.Equals (-1))
                {
           
                    
                    Console.WriteLine(total);
                    break;
                };
               

            } while (input != -2);

           
           
            Animas Goat =new Animas("alpine",20 );
            Goat.Intro();
    
            Animas chicken = new Animas(5);
            chicken.Intro();

            Animas basicanimas = new Animas();
            basicanimas.Intro();


             */


            /*arrays*/

            /*tic tac toe*/

            /*
                        [0,0],[0,1],[0,2]
                        [1,0],[1,1],[1,2]
                        [2,0],[2,1],[2,2]]

            */

           



            
            bool player1run = false;
            bool player2run = false;
            display();


            do
                {

                    Console.WriteLine("Player one input please:");
                    string  playerStore1 = Console.ReadLine();
                    bool playerTrue1 = int.TryParse(playerStore1, out  int player1);
                    inputNum = player1;
                    if (playerTrue1 == true) { 
                        if (player1 < 10)
                    {
                        Console.WriteLine(player1);
                        turnMaker();
                        inputNum = player1;
                        display();
                    player1run=true;
                    
                    }
                    else
                    {
                        Console.WriteLine("The input entered is greater than 9 please try again");
                       
                  
                   
                    }
                }
                else
                {
                    Console.WriteLine("player 1 input a number");

                }


                 }
                  while (player1run == false);



            do { 
            Console.WriteLine("Player two input please:");
            string playerStore2 = Console.ReadLine();
            bool playerTrue2 = int.TryParse(playerStore2, out int player2);
           inputNum = player2;
           



            if (playerTrue2 == true)
            {
                    if (player2 < 10)
                    {
                        Console.WriteLine(player2);
                        turnMaker();
                        inputNum = player2;
                        display();
                        player1run = true;

                    }
                    else
                    {
                        Console.WriteLine("The input entered is greater than 9 please try again");



                    }
                }
            else
            {
                Console.WriteLine("player 2 input a number");
            }

            }while(player2run == false);






            Console.ReadKey();

        }



        public static void turnMaker()
        {
            switch (inputNum)
            {
                case 1:
                    num[0, 0] = 0;

                    break;

                case 2:
                    num[0, 1] = 0;


                    break;

                case 3:
                    num[0, 2] = 0;


                    break;

                case 4:
                    num[1, 0] = 0;


                    break;
                case 5:
                    num[1, 1] = 0;


                    break;
                case 6:
                    num[1, 2] = 0;


                    break;
                case 7:
                    num[2, 0] = 0;


                    break;
                case 8:
                    num[2, 1] = 0;


                    break;
                case 9:
                    num[2, 2] = 0;


                    break;

            }
        }







        public static void display()
        {


            Console.WriteLine("{0} | {1} | {2} ", num[0, 0], num[0, 1], num[0, 2]);
            Console.WriteLine("{0} | {1} | {2} ", num[1, 0], num[1, 1], num[1, 2]);
            Console.WriteLine("{0} | {1} | {2} ", num[2, 0], num[2, 1], num[2, 2]);

        }




        public static void attendance()
        {


            int test = 0;
            int count = 0;
            while (test < 1)
            {
                Console.WriteLine("Press enter");
                Console.WriteLine(count);
                string test1 = Console.ReadLine();
                test = test1.Length;

                count++;

            }
        }






       public static void higscoreChecker( string playerName,int score)
        {
            if (score > highScore)
            {
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);

            }
            else
            {

                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is held by " + highscorePlayer);
            }



        }











































        //user verfication

        public static void register()
        {
            Console.WriteLine("Please enter your username");
            string user = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string password = Console.ReadLine();


        }

        public static void login()
        {

            Console.WriteLine("LOGIN");
            Console.WriteLine("Please enter your username");
            string inUser = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string inPassword = Console.ReadLine();


            if (password != inPassword || user != inUser)
            {
                if (user != inUser && password != inPassword)
                {
                    Console.WriteLine("Incorrect username and Password");


                }
                else if (user != inUser)
                {
                    Console.WriteLine("Incorrect username ");

                }
                else if (password != inPassword)
                {
                    Console.WriteLine("Incorrect password");
                }




            }

            else
            {
                Console.WriteLine("Login Successful");
            }


        }
    }

}
