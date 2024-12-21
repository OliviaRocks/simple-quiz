using System;

namespace myApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Quiz");
            Console.WriteLine("Press Enter to see the first question: ");
            Console.ReadLine();

            int totalScore = 0;

            bool correctGuess1 = false;

            Console.WriteLine("1. Which physicist developed the theory of general relativity?\n\t a. Isaac Newton\n\t b. Albert Einstein\n\t c. Niels Bohr");

            while (!correctGuess1)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "b")
                {
                    correctGuess1 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");

                }
                else
                {
                    Console.WriteLine("Incorrect answer. Please try again.");
                }
            }

            bool correctGuess2 = false;

            Console.WriteLine("2. What is the capital city of Australia?\n\t a. Sydney\n\t b. Melbourne\n\t c. Canberra");

            while (!correctGuess2)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "c")
                {
                    correctGuess2 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess3 = false;

            Console.WriteLine("3. Which element is the most abundant in the Earth's crust?\n\t a. Silicon\n\t b. Oxygen\n\t c. Aluminum");

            while (!correctGuess3)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "b")
                {
                    correctGuess3 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess4 = false;

            Console.WriteLine("4. Who composed the opera \"The Magic Flute\" ?\n\t a.Ludwig van Beethoven\n\t b.Wolfgang Amadeus Mozart\n\t c.Johann Sebastian Bach");

            while (!correctGuess4)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "b")
                {
                    correctGuess4 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess5 = false;

            Console.WriteLine("5. What is the hardest natural substance on Earth?\n\t a. Diamond\n\t b. Corundum\n\t c. Quartz");

            while (!correctGuess5)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "a")
                {
                    correctGuess5 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess6 = false;

            Console.WriteLine("6. Which ancient civilization built the Machu Picchu complex in Peru?\n\t a. Aztec\n\t b. Inca\n\t c. Maya");

            while (!correctGuess6)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "b")
                {
                    correctGuess6 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");

                }
                else
                {
                    Console.WriteLine("Incorrect answer. Please try again.");
                }
            }

            bool correctGuess7 = false;

            Console.WriteLine("7. What is the chemical formula for table salt?\n\t a. NaCl\n\t b. KCl\n\t c. CaCl2");

            while (!correctGuess7)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "a")
                {
                    correctGuess7 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess8 = false;

            Console.WriteLine("8. Which planet has the most moons?\n\t a. Jupiter\n\t b. Saturn\n\t c. Uranus");

            while (!correctGuess8)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "a")
                {
                    correctGuess8 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess9 = false;

            Console.WriteLine("9. Who is the author of the novel \"1984\"?\n\t a.Aldous Huxley\n\t b.George Orwell\n\t c.Ray Bradbury");

            while (!correctGuess9)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "b")
                {
                    correctGuess9 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }

            bool correctGuess10 = false;

            Console.WriteLine("10. What is the name of the longest river in the world?\n\t a. Amazon River\n\t b. Nile River\n\t c. Yangtze River");

            while (!correctGuess10)
            {
                string userAnswer = Console.ReadLine();

                if (userAnswer == "a")
                {
                    correctGuess5 = true;
                    totalScore += 2;
                    Console.WriteLine($"Correct! You're win!\n Your total score is {totalScore}");
                }
                else
                {
                    totalScore--;
                    Console.WriteLine("Incorrect answer. You lose 1 point. Please try again.");
                }
            }









        }
    }
}