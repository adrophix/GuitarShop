using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{    
     /// <summary>
     /// Defines an object that represents a customer for a <see cref="GuitarShop"/> who can spend money and own <see cref="Guitar"/>s.
     /// </summary>
    internal class Customer : Person
    {
        private List<Guitar> playerInventory = new List<Guitar>();


        public Customer(string name, decimal money)
            : base(name)
        {
            this.money = money;
        }
        public void AddGuitar(Guitar guitar)
        {
            playerInventory.Add(guitar);
        }

        public void RemoveGuitar(Guitar guitar)
        {
            playerInventory.Remove(guitar);
        }

        public List<Guitar> GetGuitars()
        {
            return playerInventory;
        }
    }
}
