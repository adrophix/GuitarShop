//using statements are used to tell the compiler which code we are using.
//using [namespace]
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Dynamic;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp_11_6_2022;
using ConsoleApp2;

//Namespace is used to organize classes
//Format of making a namespace:
//namespace [name of the namespace]
namespace ConsoleApp_11_6_2022
{
    //A class is used to organize methods and variables.
    //Format of making a class goes like this:
    //[Scope] class [Name of the class]
    class Person
    {
        //Format of a variable (inside of a class)
        //[Scope] [Data type] [Name];
        internal int height;

        // optionally: [Scope] [Data type] [Name] = [value];
        public static string hairColor = "Yellow";

        //A method is used to perform some action or code.
        //Format of a method:
        //[Scope] [Static or omit it] [Return type, use void to say there is no return] [Name of the method](parameter list)
        public static void Main(string[] args)
        {
            //Format of a variable (inside of a method)
            //[Data type] [Name];
            char characterNoDefaultValue;

            //optionally [Data type] [Name] = [value];
            double fractionalNumber = 0.5412412512 + 5124123;
            float smallerFractionalNumber = 0.54124125125124123f;
            char character = 'p';

            long longNumber = 1231235151251252312;
            int integerNumber = 124545;
            short smallInteger = 256;

            //Console.WriteLine(hairColor);
            //double roomTemperature = 72;
            //double convertedTemperature = TemperatureFarhenheitToCelcius(roomTemperature);
            //Console.WriteLine(convertedTemperature);

            double temp1 = 10;
            double temp2 = 72;
            double temp3 = 92;

            double average = TemperatureAverage(temp1, temp2, temp3);

            //string foo = "foo";
            //string bar = "bar";
            //string foobar = foo + bar; //the term for adding strings together is called "concatination"

            string[] stringArray = new string[3];
            stringArray[0] = "444";
            stringArray[1] = "123";
            //stringArray[2] is null



            double input1 = 10;
            double input2 = 72;
            double input3 = 92;

            double[] array = new double[3];
            array[0] = 10;
            array[1] = 72;
            array[2] = 92;

            double arrayAverage = TemperatureAverage(array[0], array[1], array[2]);



            /* Console.WriteLine("Please type your first number.");
             string firstNumberString = Console.ReadLine();

             Console.WriteLine("Please type your second number.");
             string secondNumberString = Console.ReadLine();

             double firstNumber = double.Parse(firstNumberString);
             double secondNumber = double.Parse(secondNumberString);

             string totalNumber = (firstNumber + secondNumber).ToString();

             //Console.WriteLine("Your total is: " + totalNumber);

             if (firstNumberInt < 0)
             {
                 Console.WriteLine("Your first number is Negative.");
             }
             else if (firstNumberInt >= 0)
             {
                 Console.WriteLine("Your first number is Positive.");
             }

             if (secondNumberInt < 0)
             {
                 Console.WriteLine("Your second number is Negative.");
             }
             else if (secondNumberInt >= 0)
             {
                 Console.WriteLine("Your second number is Positive.");
             }
           

            bool firstNumberPositive = IsEvenOrOdd(firstNumber);

            Console.WriteLine("The result is: " + firstNumberPositive);
            */

            /* Console.WriteLine("This is a while loop:");
             int counter = 1;

             while (counter < 6)
             {
                 counter = counter + 1;
                 Console.WriteLine(counter);
             }



             Console.WriteLine("This is a do while loop");
             counter = 1;
             do
             {
                 Console.WriteLine(counter);
                 counter = counter + 1;
             }
             while (counter < 6);



             Console.WriteLine("This is a for loop");
             for (counter = 1; counter <6; counter += 1)
             {
                 Console.WriteLine(counter);
             }
          

            Console.WriteLine("This is a foreach loop:");
            foreach (string s in stringArray)
            {
                if (s == null)
                {
                    Console.WriteLine("Null");
                }
                else
                {
                    Console.WriteLine(s);
                }

            }
          
              */


            long sumToThis = 80000;
            long methodResult = numberLoop(sumToThis);
            // Console.WriteLine(methodResult);


            /* long[] longArray = new long[6];
             longArray[0] = 1000;
             longArray[1] = 300;
             longArray[2] = 900;
             longArray[3] = 420;
             longArray[4] = 750;
             longArray[5] = -666;

             int lengthOfArray = longArray.Length;
             foreach (long l in longArray)
             {
                 Console.WriteLine(l);
             }
             

            int firstIndex = 0;
            long l1 = longArray[firstIndex];

            for (long i = 0; i < lengthOfArray; i++)
            {
                l1 = longArray[firstIndex];
                firstIndex++;
                Console.WriteLine(l1);
            }
            */
            //Console.WriteLine(foobar);
            string[] greetings = new string[4];
            greetings[0] = "Hello!";
            greetings[1] = "Welcome!";
            greetings[2] = "Hello World!";
            greetings[3] = "This is the fourth greeting.";

            /*string s = greetings[0];
            Console.WriteLine(s);

            s = greetings[1];
            Console.WriteLine(s);

            s = greetings[2];
            Console.WriteLine(s);
            
            // Console.WriteLine("The Loop's Output is below:");
            

            string tempS;

            for (int i = greetings.Length - 1; i >=0; i--)
            {
                //s = greetings[1];
                tempS = greetings[i];
                Console.WriteLine(tempS);
            }
            */

            string[] arrayToFill = new string[6];
            arrayToFill[0] = "A";
            arrayToFill[1] = null;
            arrayToFill[2] = "C";
            arrayToFill[3] = "D";
            arrayToFill[4] = "E";
            arrayToFill[5] = null;

            //TODO: Make the below method.
            //FillGap("Missing", arrayToFill);

            /*for (int i = 0; i < arrayToFill.Length; i++)
            {
                Console.WriteLine(arrayToFill[i]);
            }
            */

            string gapFill = "Missing";
            //Console.WriteLine(FillGap(gapFill, arrayToFill));
            //FillGap(arrayToFill);
            //FillGap(arrayToFill);
            //ObjectPractice();

            string[] arrayPractice = new string[3];
            arrayPractice[0] = "A";
            arrayPractice[1] = "B";
            arrayPractice[2] = "C";



            /* string temp = arrayPractice[0];
             arrayPractice[0] = arrayPractice[2];
             arrayPractice[2] = temp
             for (int i = 0; i < arrayPractice.Length; i++)
             {
                 Console.WriteLine(arrayPractice[i]);
             }
            */
            //Swap(1, 5, arrayPractice);

            arrayPractice = AddElement("D", arrayPractice);
            arrayPractice = AddElement("E", arrayPractice);
            arrayPractice = AddElement("F", arrayPractice);

            /*for (int i = 0; i < arrayPractice.Length; i++)
            {
                Console.WriteLine(arrayPractice[i]);playerInventory
            }
            */
            //GuitarShopObjectPractice();

            VisitGuitarShop();

            //ShopGame.Start();
           
        }


        public static void VisitGuitarShop()
        {
            GuitarShop shop = new GuitarShop();

            decimal money = 25499.99M;
            Customer player = new Customer(money);


            List<Guitar> guitarStock = shop.GetGuitars();
            List<Guitar> playerInventory = player.PlayerInventory;
            bool canAffordGuitar;
            

            shop.AddGuitar(RandomNumberGen.GenerateGuitar());
            shop.AddGuitar(RandomNumberGen.GenerateGuitar());
            shop.AddGuitar(RandomNumberGen.GenerateGuitar());
            shop.AddGuitar(RandomNumberGen.GenerateGuitar());
            shop.AddGuitar(RandomNumberGen.GenerateGuitar());


            MainMenu(player);

            while (guitarStock.Count > 0)
            {

                DisplayGuitarShop(guitarStock, shop);
                Console.WriteLine("Select the guitar you wish to BUY, or press 0 to return.");
                string input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You selected: {input}");
                int userInput;
                bool result = int.TryParse(input, out userInput);


                canAffordGuitar = shop.GetCanAffordGuitar(player.Money, userInput);
                while (true)
                {
                    if (result && userInput == 0)
                    {
                        MainMenu(player);
                    }
                    break;
                }

                if (result && canAffordGuitar && userInput > 0 && userInput <= guitarStock.Count)
                {
                    //double guitarPrice = shop.DisplayGuitarPrice(guitarStock, userInput); 
                    Console.WriteLine($"Guitar Purchased for ${shop.DisplayGuitarPrice(guitarStock, userInput)}");
                    player.Money = shop.PayForGuitar(player.Money, userInput);
                    Console.WriteLine($"You have ${player.Money}.");
                    player.AddGuitar(guitarStock, userInput);
                    shop.RemoveGuitar(userInput - 1);


                    if (guitarStock.Count == 0)
                    {
                        Console.Write("We're out of guitars. Goodbye.");
                        return;
                    }



                }
                else if (result && !canAffordGuitar && userInput > 0 && userInput <= guitarStock.Count)
                {
                    Console.WriteLine($"Sorry! That costs ${guitarStock[userInput - 1].GetPrice()} and you only have ${player.Money}.");

                }
                else if (result && userInput != 0 && guitarStock.Count > 0)
                {
                    Console.WriteLine($"Out of bounds. Please select the guitar you wish to buy, or Press 0 to return. \nYou have ${player.Money}.");
                }
                else if (!result)
                {
                    Console.WriteLine($"Not a number. Try again.\nYou have ${player.Money}");
                }

            }




        }
        /// <summary>
        /// Takes in an a guitar array, and a shop, and lists in order the stored guitars by brand and price.
        /// </summary>
        /// <param name="guitars"></param>
        /// <param name="shop"></param>
        public static void DisplayGuitarShop(List<Guitar> guitars, GuitarShop shop)
        {
            List<Guitar> guitarStock = shop.GetGuitars();
            for (int i = 0; i < guitarStock.Count; i++)
            {
                //Console.Write(i + 1 + ". ");
                Console.Write($"{i + 1}. ");
                shop.DisplayGuitarInfo(guitarStock[i]);
            }
        }
        public static void EnterUserInventory(List<Guitar> guitars, Customer player)
        {
            Console.Clear();
            GuitarShop shop = new GuitarShop();
            List<Guitar> playerInventory = player.PlayerInventory;
            if (playerInventory.Count == 0)
            {
                Console.WriteLine("You do not have any guitars. Press 0 to return.");
                while (true)
                {
                    string input = Console.ReadLine();
                    int userInput;
                    bool result = int.TryParse(input, out userInput);
                    if (result && userInput == 0)
                    {
                        MainMenu(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not an option. Please press 0 to return.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"You have ${player.Money}");
                Console.WriteLine("Your guitars are:");
                for (int i = 0; i < playerInventory.Count; i++)
                {
                    //Console.Write(i + 1 + ". ");
                    Console.Write($"{i + 1}. ");
                    player.DisplayGuitarInfo(playerInventory[i]);
                }
                Console.WriteLine("Press 0 to return.");
                while (true)
                {
                    string input = Console.ReadLine();
                    int userInput;
                    bool result = int.TryParse(input, out userInput);
                    if (result && userInput == 0)
                    {
                        Console.Clear();
                        MainMenu(player);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Not valid. Press 0 to return.");
                    }
                }

            }

        }
        public static void MainMenu(Customer player)
        {
            Console.Clear();
            string greeting = $"Welcome to WeSellGuitarsGuitarShop! My guitar shop, where I, {RandomNumberGen.GetRandomOwner()}, sell guitars.";
            string shopOptions = "(1): View Guitars\n(2): View your Inventory\n(3): Sell Guitars\n(4): Exit Shop";
            Console.WriteLine(greeting);
            Console.WriteLine(); // Line for better look
            Console.WriteLine(shopOptions);

            while (true)
            {

                string input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You selected: {input}");
                int userInput;
                bool result = int.TryParse(input, out userInput);
                if (result && userInput == 1)
                {
                    Console.WriteLine($"You have ${player.Money}");
                    Console.WriteLine("Our Guitars are: ");
                    break;
                }
                else if (userInput == 2)
                {
                    EnterUserInventory(player.PlayerInventory, player);
                    break;
                }
                else if (userInput == 3)
                {
                    SellGuitars(player.PlayerInventory, player);
                    return;
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"Please select one of the listed options.\n{shopOptions}");
                }
            }


        }
        public static void SellGuitars(List<Guitar> guitars, Customer player)
        {
            GuitarShop shop = new GuitarShop();
            List<Guitar> playerInventory = player.PlayerInventory;
            Console.Clear();
            if (playerInventory.Count == 0)
            {
                Console.WriteLine("You do not have any guitars. Press 0 to return.");
                while (true)
                {
                    string input = Console.ReadLine();
                    int userInput;
                    bool result = int.TryParse(input, out userInput);
                    if (result && userInput == 0)
                    {
                        MainMenu(player);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not an option. Please press 0 to return.");
                    }
                }
            }

            while (playerInventory.Count > 0)
            {
                Console.Clear();
                Console.WriteLine($"You have ${player.Money}\nYour guitars are:");
                for (int i = 0; i < playerInventory.Count; i++)
                {
                    //Console.Write(i + 1 + ". ");
                    Console.Write($"{i + 1}. ");
                    player.DisplayGuitarInfo(playerInventory[i]);
                }
                Console.WriteLine("Select the guitar you wish to SELL, or press 0 to return.");
                string input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You selected: {input}");
                int userInput;
                bool result = int.TryParse(input, out userInput);

                if (result && userInput == 0)
                {
                    MainMenu(player);
                    return;
                }

                else if (result && userInput > 0 && userInput <= playerInventory.Count)
                {
                    //double guitarPrice = shop.DisplayGuitarPrice(guitarStock, userInput); 
                    Console.WriteLine($"Guitar sold for ${shop.DisplayGuitarPrice(playerInventory, userInput)}");
                    shop.AddGuitar(playerInventory[userInput - 1]);
                    player.Money = shop.SellGuitar(player.Money, userInput);
                    Console.WriteLine($"You have ${player.Money}.");
                    playerInventory.Remove(playerInventory[userInput - 1]);


                }
            }

        }
        /* public static string[] AddElement(string newGuitar, string[] Guitar)
         {
             int newSize = Guitar.Length + 1;
             string[] newArray = new string[newSize];

             for (int i = 0; i < Guitar.Length; i++)
             {
                 newArray[i] = Guitar[i];
             }
             newArray[newArray.Length - 1] = newGuitar;
        
             return newArray;
         }*/
        public static string[] AddElement(string newStr, string[] array)
        {
            int newSize = array.Length + 1;
            string[] newArray = new string[newSize];

            for(int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = newStr;

            return newArray;
        }

        public static void Swap(int firstIndex,int secondIndex,string[] arrayPractice)
        {
            string temp = arrayPractice[firstIndex];

            arrayPractice[firstIndex] = arrayPractice[secondIndex];
            arrayPractice[secondIndex] = temp;

        }

        public static void ObjectPractice()
        {
            string brand = "Fender";
            Guitar myGuitar = new Guitar(brand);

            brand = "Walmart";
            Guitar mySecondGuitar = new Guitar(brand);

            myGuitar.SetNumberOfStrings(12);
            mySecondGuitar.SetNumberOfStrings(36);

            int numberOfStrings = myGuitar.GetNumberOfStrings();
            int mySecondGuitarStringCount = mySecondGuitar.GetNumberOfStrings();

            double lengthOfNeck = myGuitar.GetLengthOfNeck();
            double mySecondGuitarLengthOfNeck = mySecondGuitar.GetLengthOfNeck();

            int numberOfFrets = myGuitar.GetNumberOfFrets();
            int mySecondGuitarNumberOfFrets = mySecondGuitar.GetNumberOfFrets();

            double weight = myGuitar.GetWeight();
            double mySecondGuitarWeight = mySecondGuitar.GetWeight();
        }

        public static void GuitarShopObjectPractice()
        {
            GuitarShop theGuitarShop = new GuitarShop();



            string brand = "Fender";
            Guitar myGuitar = new Guitar(brand);

            brand = "Fender2";
            Guitar myGuitar2 = new Guitar(brand);

            brand = "Fender3";
            Guitar myGuitar3 = new Guitar(brand);

            brand = "Fender4";
            Guitar myGuitar4 = new Guitar(brand);

            brand = "Fender5";
            Guitar myGuitar5 = new Guitar(brand);

            brand = "Fender6";
            Guitar myGuitar6 = new Guitar(brand);

            brand = "Fender7";
            Guitar myGuitar7 = new Guitar(brand);

            brand = "Fender8";
            Guitar myGuitar8 = new Guitar(brand);

            brand = "Fender9";
            Guitar myGuitar9 = new Guitar(brand);

            theGuitarShop.AddGuitar(myGuitar);
            theGuitarShop.AddGuitar(myGuitar2);
            theGuitarShop.AddGuitar(myGuitar3);
            theGuitarShop.AddGuitar(myGuitar4);
            theGuitarShop.AddGuitar(myGuitar5);

            theGuitarShop.RemoveGuitar(myGuitar3);
            theGuitarShop.RemoveGuitar(4);

            theGuitarShop.AddGuitar(myGuitar6);
            theGuitarShop.AddGuitar(myGuitar7);
            theGuitarShop.AddGuitar(myGuitar8);
            theGuitarShop.AddGuitar(myGuitar9);
        }
       
         public static void FillGap(string[] arrayToFill) //This is the original for fillgap method
         {
             string nullFinder;
             for (int i = 0; i < arrayToFill.Length; i++)
             {
                 if (arrayToFill[i] == null)
                 {
                     nullFinder = "Missing";
                     Console.WriteLine(nullFinder);
                 }
                 else
                 {
                     Console.WriteLine(arrayToFill[i]);
                 }

             }

         }
          public static string FillGap(string gapFill, string[] arrayToFill) //This is the second for fillgap method
           {
               string nullFinder;
               for (int i = 0; i < arrayToFill.Length; i++)
               {
                   if (arrayToFill[i] == null)
                   {
                      nullFinder = gapFill;
                       Console.WriteLine(nullFinder);
                   }
                   else
                   {
                       Console.WriteLine(arrayToFill[i]);
                   }

               }
               nullFinder = null;
               return nullFinder;
           }


    /*     public static string FillGap(string[] arrayToFill) //This is the foreach fillgap method
          {
              string nullFinder;
              foreach (string s in arrayToFill)
              {
                  if (s == null)
                  {
                      nullFinder = "Missing";
                      Console.WriteLine(nullFinder);
                  }
                  else
                  {
                      nullFinder = s;
                      Console.WriteLine(nullFinder);
                  }

              }
              nullFinder = null;
              return nullFinder;

          }

         public static string FillGap(string[] arrayToFill) //This is the do while fillgap method
         {
             string nullFinder;
             int counter = 0;
             do
             {
                 if (arrayToFill[counter] == null)
                 {
                     nullFinder = "Missing";
                     Console.WriteLine(nullFinder);
                 }
                 else
                 {
                     nullFinder = arrayToFill[counter];
                     Console.WriteLine(nullFinder);

                 }
                 counter++;
             }
             while (counter < arrayToFill.Length);
             nullFinder = null;
             return nullFinder;
         }*/

        public static long numberLoop(long sumToThis)
            {
                long sum = 0;

                for (int i = 1; i <= sumToThis; i += 1)
                {
                    sum += i;
                }

                return sum;
            }
            public static double TemperatureFarhenheitToCelcius(double fahrenheit)
            {
                double celcius = (fahrenheit - 32) * .5556;

                return celcius;
            }

            public static double TemperatureAverage(double temperature1, double temperature2, double temperature3)
            {
                double finalNumber = (temperature1 + temperature2 + temperature3) / 3;

                return finalNumber;
            }


            //Returns true if Positive, false if negative
            public static bool IsPositive(double number)
            {
                bool boolTrueorFalse;
                if (number >= 0)
                {
                    boolTrueorFalse = true;
                }
                else
                {
                    boolTrueorFalse = false;
                }
                return boolTrueorFalse;
            }

            //Returns true if even, if not, false
            public static bool IsEvenOrOdd(double number)
            {
                //If even, true, if odd, false

                if (number % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }





        }
    }

