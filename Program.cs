using System;

namespace SpinningPipeLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPipes = 100; // Number of pipes to be loaded.

            Console.WriteLine("Loading... ");

            for (int i = 0; i < numberOfPipes; i++) // Loop for the number of pipes to be loaded. 
            {
                
                System.Threading.Thread.Sleep(300); // Wait for 100 milliseconds before printing the next pipe character. 

                if (i == numberOfPipes - 1) // If we are on the last pipe, print a new line character and end the loop. 
                {
                    Console.WriteLine();
                    break;
                }

                Console.Write("\b"); // Move back one character in the console window to overwrite the previous pipe character with a spinning one instead.  

                char spinningCharacter = '-'; // Character used to represent spinning pipe loading animation.  

                switch (i % 4) // Change the spinning character based on which iteration of the loop we are in, so it looks like it's spinning around in a circle as it loads each pipe character.  
                {
                    case 0: spinningCharacter = '\\'; break;

                    case 1: spinningCharacter = '|'; break;

                    case 2: spinningCharacter = '/'; break;

                    case 3: spinningCharacter = '-'; break;
                }

                Console.Write(spinningCharacter);
            }
        }
    }
}