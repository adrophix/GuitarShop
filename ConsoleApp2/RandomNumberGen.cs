using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp2
{
    public static class RandomNumberGen
    {
        private static Random random = new Random();

        public static string GetRandomOwner()
        {
            
            string ownerName;
            int randomNumber = random.Next(4);

            if (randomNumber == 0)
            {
                ownerName = "Zach";
            }
            else if (randomNumber == 1)
            {
                ownerName = "Taylor";
            }
            else if (randomNumber == 2)
            {
                ownerName = "Jacob";
            }
            else
            {
                ownerName = "Chris";
            }
            return ownerName;
        }

        public static Guitar GenerateGuitar()
        {
            Guitar randomGuitar = new Guitar(GetRandomBrand());

            decimal randomPrice = random.Next(100, 1501);
            randomPrice = Math.Round(randomPrice / 10) * 10;
            randomPrice -= 0.01M;
            randomGuitar.Price = randomPrice;
            return randomGuitar;

        }
        public static string GetRandomBrand()
        {
            string guitarBrand;
            int randomBrand = random.Next(4);

            switch (randomBrand)
            {
                case 0:
                    guitarBrand = "Fender";
                    break;
                case 1:
                    guitarBrand = "Taylor";
                    break;
                case 2:
                    guitarBrand = "ZachsGuitars";
                    break;
                default:
                    guitarBrand = "Squire";
                    break;
            }
            return guitarBrand;
        }













    }
}
