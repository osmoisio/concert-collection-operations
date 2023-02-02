using System;

namespace Assignment_III
{
    class Concert
    {
        string title;
        string location;
        DateTime dateAndTime;
        double price;

        public Concert()
        {
            title = "not known";
            location = "not known";
        }

        public Concert(string title, string location, DateTime dateAndTime, double price)
        {
            this.title = title;
            this.location = location;
            this.dateAndTime = dateAndTime;
            this.price = price;
        }

        public override string ToString()
        {
            return title + ", " + location + ", " + dateAndTime.ToString("dd.MM.yyyy HH.mm") + ", " + String.Format("{0:0.00}", price) + "e";
        }

        public double GetPrice()
        {
            return price;
        }

        //== operator
        public static bool operator ==(Concert c1, Concert c2)
        {
            if (c1.title.Equals(c2.title) && c1.location.Equals(c2.location))
                return true;
            return false;
        }

        //!= operator
        public static bool operator !=(Concert c1, Concert c2)
        {
            if (!c1.title.Equals(c2.title) || !c1.location.Equals(c2.location))
                return true;
            return false;
        }
        
        //< operator
        public static bool operator < (Concert c1, Concert c2)
        {
            if (c1.price < c2.price)
                return true;
            return false;
        }

        //> operator
        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.price > c2.price)
                return true;
            return false;
        }

        //++ operator
        public static Concert operator ++(Concert c)
        {
            c.price += 5;
            return c;
        }

        //-- operator
        public static Concert operator --(Concert c)
        {
            c.price -= 5;
            return c;
        }
    }
}
