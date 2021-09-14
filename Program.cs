// Name: Duy Ho
// Date: 9/13/2021
// Class: Managinng Information Resource
// Prof: Travis David

using System;

namespace TechProj2_DuyHo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask input
            Console.WriteLine("What grade do you expect to get in ISM 4300?");

            try
            {
                string input = Console.ReadLine();
                // Store input
                int Grade = int.Parse(input);
                char LetterGrade;

                if (Grade > 90 && Grade <= 100)
                {
                    Console.WriteLine("Your expectted grade will be" + string.Format("{0: }", Grade) + ": A ");

                    Console.WriteLine("What is the current Letter Grade you have?");
                    LetterGrade = char.Parse(Console.ReadLine());
                }
                else if (Grade >= 80 && Grade < 90)
                {
                    Console.WriteLine("Your expectted grade will be" + string.Format("{0: }", Grade) + ": B ");
                    Console.WriteLine("What is the current Letter Grade you have?");
                    LetterGrade = char.Parse(Console.ReadLine());
                }
                else if (Grade >= 70 && Grade < 80)
                {
                    Console.WriteLine("Your expectted grade will be" + string.Format("{0: }", Grade) + ": C ");
                    Console.WriteLine("What is the current Letter Grade you have?");
                    LetterGrade = char.Parse(Console.ReadLine());
                }
                else if (Grade >= 60 && Grade < 70)
                {
                    Console.WriteLine("Your expectted grade will be" + string.Format("{0: }", Grade) + ": D ");
                    Console.WriteLine("What is the current Letter Grade you have?");
                    LetterGrade = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your expectted grade will be" + string.Format("{0: }", Grade) + ": F ");
                    Console.WriteLine("What is the current Letter Grade you have?");
                    LetterGrade = char.Parse(Console.ReadLine());
                }
                switch (LetterGrade)
                {
                    case 'A':
                        Console.WriteLine("Excelent job!");
                        Console.WriteLine("Press any key to exist!");
                        Console.ReadKey(true);
                        break;
                    case 'B':
                        Console.WriteLine("You doing great! Keep up the good work!");
                        Console.WriteLine("Press any key to exist!");
                        Console.ReadKey(true);
                        break;
                    case 'C':
                        Console.WriteLine("Keep improving!");
                        Console.WriteLine("Press any key to exist!");
                        Console.ReadKey(true);
                        break;
                    case 'D':
                        Console.WriteLine("You have to try harder!");
                        Console.WriteLine("Press any key to exist!");
                        Console.ReadKey(true);
                        break;
                    case 'F':
                        Console.WriteLine("You failed!");
                        Console.WriteLine("Press any key to exist!");
                        Console.ReadKey(true);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please use any interger values for your expectted grade... ");
                Console.WriteLine("-- OR --");
                Console.WriteLine("Please input a Letter Grade you have in current Letter Grade you have..");
                Console.WriteLine("Press any key to exit the program!");
                Console.ReadKey(true);
            }
        }
    }
}
