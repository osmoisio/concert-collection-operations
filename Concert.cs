using System;

namespace Assignment_III
{
    class Concert
    {
        string title;
        string location;
        DateTime dateAndTime;
        double price;

        static double increment;
        static double decrement;

        public Concert(string title, string location)
        {
            this.title = title;
            this.location = location;
        }

        public Concert(string title, string location, DateTime dateAndTime, double price)
        {
            this.title = title;
            this.location = location;
            this.dateAndTime = dateAndTime;
            this.price = price;
        }

        public static double Decrement
        {
            set { decrement = value; }
        }

        public static double Increment
        {
            set { increment = value; }
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
        public static bool operator <(Concert c1, Concert c2)
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
            c.price += increment;
            return c;
        }

        //-- operator
        public static Concert operator --(Concert c)
        {
            c.price -= decrement;
            return c;
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }
            //If parameter cannot be cast to Point return false.
            Concert c = obj as Concert;
            if ((System.Object)c == null)
            {
                return false;
            }
            if (this.title == c.title && this.location == c.location && this.price == c.price)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
