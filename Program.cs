using System;
using System.Collections;

namespace Assignment_III
{
    class Program
    {
        //Sort arraylist of concerts to ascending order by price
        public static void SortAscending(ArrayList concerts)
        {
            for (int i = 0; i < concerts.Count - 1; i++)
            {
                for (int j = 0; j < concerts.Count - i - 1; j++)
                {
                    if ((Concert)concerts[j] > (Concert)concerts[j + 1])
                    {
                        Concert temp = (Concert)concerts[j];
                        concerts[j] = concerts[j + 1];
                        concerts[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintConcerts(ArrayList concerts)
        {
            foreach (Concert c in concerts)
                Console.WriteLine(c.ToString());
        }

        static void Main(string[] args)
        {
            //We initialize DateTime objects to use for the concert objects
            DateTime date1 = new DateTime(2023, 2, 2, 15, 0, 0);
            DateTime date2 = new DateTime(2023, 6, 20, 17, 0, 0);
            DateTime date3 = new DateTime(2023, 8, 10, 20, 0, 0);

            //We initialize concert objects
            Concert concert1 = new Concert("Concert", "Vaasa", date1, 20.99);
            Concert concert2 = new Concert("Concert", "Vaasa", date1, 19.99);
            Concert concert3 = new Concert("Concert3", "Seinäjoki", date2, 25);
            Concert concert4 = new Concert("Concert4", "Oulu", date3, 15.50);
            Concert concert5 = new Concert("Concert5", "Helsinki");

            //We create an arraylist and add the concert objects to it
            ArrayList concerts = new ArrayList
            {
                concert1,
                concert2,
                concert3,
                concert4,
                concert5
            };

            //We print information of all concerts in the arraylist
            Console.WriteLine("Before sorting:");
            PrintConcerts(concerts);

            //Calling the sort method
            SortAscending(concerts);

            //We print the concerts again, now they are sorted
            Console.WriteLine("\nAfter sorting by price:");
            PrintConcerts(concerts);

            //We test all operators to make sure they work correctly
            Console.WriteLine();
            // <
            Console.WriteLine("concert1 < concert3: " + (concert1 < concert3));
            Console.WriteLine("concert1 < concert4: " + (concert1 < concert4));

            // >
            Console.WriteLine("\nconcert1 > concert3: " + (concert1 > concert3));
            Console.WriteLine("concert1 > concert4: " + (concert1 > concert4));

            // ==
            Console.WriteLine("\nconcert1 == concert2: " + (concert1 == concert2));
            Console.WriteLine("concert1 == concert4: " + (concert1 == concert4));

            // !=
            Console.WriteLine("\nconcert1 != concert2: " + (concert1 != concert2));
            Console.WriteLine("concert1 != concert4: " + (concert1 != concert4));

            // ++ and --
            Concert.Increment = 5;
            Concert.Decrement = 3;

            concert4++;
            Console.WriteLine("\nconcert4++: " + concert4.GetPrice());
            concert4--;
            Console.WriteLine("concert4--: " + concert4.GetPrice());

            // Equals method
            Console.WriteLine("\nconcert1.Equals(concert2): " + concert1.Equals(concert2));

        }
    }
}
