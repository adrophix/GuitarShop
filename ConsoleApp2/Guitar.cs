using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Guitar
    {
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        //Body

        //Neck

        //Head - Where strings attach
        public int numberOfStrings
        {
            get { return numberOfStrings; }
            set { numberOfStrings = value; }
        }

         public double lengthOfNeck
        {
            get { return lengthOfNeck; }
            set { lengthOfNeck = value; }
        }
        public double numberOfFrets
        {
            get { return numberOfFrets; }
            set { numberOfFrets = value; }
        }
        public double weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string brand;

        private decimal price;

        //Constructors - Are the starting 'method'
        //structure of a constructor: [scope] Guitar(parameters)

        public Guitar(string brandOfGuitar)
        {
            brand = brandOfGuitar;
        }

        /* Old Code Below
        public void SetNumberOfStrings(int newStringCount)
        {
            numberOfStrings = newStringCount;
        }

        public int GetNumberOfStrings()
        {
            return numberOfStrings;
        }

        public void SetLengthOfNeck(double newLengthOfNeck)
        {
            lengthOfNeck = newLengthOfNeck;
        }

        public double GetLengthOfNeck()
        {
            return lengthOfNeck;
        } 

        public void SetNumberOfFrets(int newFretCount)
        {
            numberOfFrets = newFretCount;
        }

        public int GetNumberOfFrets()
        {
            return numberOfFrets;
        }

        public void SetWeight(double newWeight)
        {
            weight = newWeight;
        }
        
        public double GetWeight()
        {
            return weight;
        }
        */
        public string GetBrand()
        {
            return brand;
        }

        public void SetPrice(decimal newPrice)
        {
            price = newPrice;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}
