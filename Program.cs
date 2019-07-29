using System;
using System.Collections.Generic;

namespace randomNumbersPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            List<int> numbers = new List<int> {

                // 'random.Next(6)' will output a random number between 0 and 5.

    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};
            numbers.ForEach(num => Console.WriteLine(num));

            //if i = any number between 1 and 5 then console its there. It is going to go six times i will go up to 5 and it will check against random number.

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine("its there");
                }
                else
                {
                    Console.WriteLine("its not there");
                }
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.

                //Check with Adam.

            }
        }
    }
}

