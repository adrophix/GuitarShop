using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    /// <summary>
    /// This defines a guitar shop object, where customers can purchase guitars for a price.
    /// </summary>
    public class GuitarShopWithArray
    {

        private Guitar[] guitars = new Guitar[2];
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
            bool addedTheGuitar = false;

            for (int i = 0; i < guitars.Length; i++)
            {

                if (guitars[i] == null)
                {
                    guitars[i] = guitar;
                    addedTheGuitar = true;
                    break;
                }
            }
            if (addedTheGuitar == false)
            {
                int newSize = guitars.Length + 1;
                Guitar[] newArray = new Guitar[newSize];

                for (int i = 0; i < guitars.Length; i++)
                {
                    newArray[i] = guitars[i];
                }

                newArray[newArray.Length - 1] = guitar;
                guitars = newArray;
                
            }
            
        }
        //TODO: Find and remove the given guitar from the guitars array.
        public void RemoveGuitar(Guitar guitar)
        {
            for (int i = 0; i < guitars.Length; i++)
            {
                if (guitars[i] == guitar)
                {
                    RemoveGuitar(i, false);
                    break;
                }
            }
        }

        public void RemoveGuitar(int index, bool shrinkArray)
        {
            ShiftElementsDown(index);

            if (shrinkArray)
            {
                ShrinkArray(1);
            }
        }

        private void ShiftElementsDown(int index)
        {
            for (int j = index; j < guitars.Length; j++)
            {
                if (j == guitars.Length - 1)
                {
                    guitars[j] = null;
                }
                else
                {
                    guitars[j] = guitars[j + 1];
                }
            }
        }

        /// <summary>
        /// Shrinks the <see cref="guitars"/> array by removing the last element.
        /// </summary>
        private void ShrinkArray(int amount)
        {
            int newSize = guitars.Length - amount;
            Guitar[] newArray = new Guitar[newSize];
            for (int k = 0; k < newArray.Length; k++)
            {
                newArray[k] = guitars[k];
            }
            guitars = newArray;
        }

        public Guitar[] GetGuitars()
        {
            return guitars;
        }

        public string GetOwner()
        {
            return ownerName;
        }
        public bool GetCanAffordGuitar(decimal customerMoney, int index)
        {
            if (index > 0 && index <= guitars.Length && customerMoney >= guitars[index - 1].GetPrice())
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
    }
}
