using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// This defines a guitar shop object, where customers can purchase guitars for a price.
    /// </summary>
    public class GuitarShop
    {

        private List<Guitar> guitars = new List<Guitar>();
        private string ownerName = "Zach";
        public bool canAffordGuitar;
        /// <summary>
        /// If there is a null spot in the guitar array, then fill that first.
        /// <br/>
        /// If there are no null spots left, then grow the array and add the new guitar.
        /// </summary>
        /// <param name="guitar"></param>
        public void AddGuitar(Guitar guitar)
        {
            guitars.Add(guitar);
        }
        public void AddGuitar(int index)
        {
            guitars.Add(guitars[index - 1]);
        }

        //TODO: Find and remove the given guitar from the guitars array.
        public void RemoveGuitar(Guitar guitar)
        {
            guitars.Remove(guitar);
        }

        public void RemoveGuitar(int index)
        {
            guitars.RemoveAt(index);
        }

        public Guitar GetGuitar(int index)
        {
            return guitars[index];
        }

        public List<Guitar> GetGuitars()
        {
            return guitars;
        }

        public string GetOwner()
        {
            return ownerName;
        }
        public string GetShopOptions()
        {
            string shopOptions = "(1): View Guitars | (2): View your Inventory | (3) Exit Shop";
            return shopOptions;
        }
        public bool GetCanAffordGuitar(decimal customerMoney, int index)
        {
            if (index > 0 && index <= guitars.Count && customerMoney >= guitars[index - 1].GetPrice())
            {
                    canAffordGuitar = customerMoney >= guitars[index - 1].GetPrice();
                    return canAffordGuitar;
                
            }

            else
            {
                return false;
            }
        }
        /// <summary>
        /// Displays guitar brand, and price.
        /// </summary>
        /// <param name="guitar"></param>
        public void DisplayGuitarInfo(Guitar guitar)
        {
            Console.WriteLine($"Brand: {guitar.GetBrand()} | Price: ${guitar.GetPrice()}");

        }

        public decimal DisplayGuitarPrice(List<Guitar> guitars, int index)
        {
            decimal guitarPrice = guitars[index - 1].GetPrice();
            return guitarPrice;
        }
        /// <summary>
        /// Subtracts the price of the guitars[index] from double customerMoney
        /// </summary>
        /// <param name="customerMoney"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public decimal PayForGuitar(decimal customerMoney, int index)
        {

            customerMoney -= guitars[index - 1].GetPrice();
            customerMoney = Math.Round(customerMoney, 2);
            return customerMoney;

        }
        public decimal SellGuitar(decimal customerMoney, int index)
        {

            customerMoney += guitars[index - 1].GetPrice();
            customerMoney = Math.Round(customerMoney, 2);
            return customerMoney;

        }
    }
}
