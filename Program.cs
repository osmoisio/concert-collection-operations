using System;
using System.Collections;

namespace Assignment_III
{
    class Program
    {
        //Method to sort arraylist of concerts to ascending order by price
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
        static void Main(string[] args)
        {
            //We initialize a couple DateTime objects to use for the concert objects
            DateTime date1 = new DateTime(2023, 2, 2, 15, 0, 0);
            DateTime date2 = new DateTime(2023, 6, 20, 17, 0, 0);

            //We initialize concert objects
            Concert concert1 = new Concert("Concert", "Vaasa", date1, 20.99);
            Concert concert2 = new Concert("Concert", "Vaasa", date1, 19.99);
            Concert concert3 = new Concert("Concert3", "Seinäjoki", date1, 25);
            Concert concert4 = new Concert("Concert4", "Oulu", date2, 15.50);
            Concert concert5 = new Concert();

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
            foreach (Concert c in concerts)
                Console.WriteLine(c.ToString());

            //Calling the sort method
            SortAscending(concerts);

            //We print the sorted array
            Console.WriteLine("\nAfter sorting by price:");
            foreach (Concert c in concerts)
                Console.WriteLine(c.ToString());

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
            concert4++;
            Console.WriteLine("\nconcert4++: " + concert4.GetPrice());
            concert4--;
            Console.WriteLine("concert4--: " + concert4.GetPrice());
        }
    }
}
