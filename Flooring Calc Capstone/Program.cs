using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Table
{
    //
    // Title: Cost of Flooring
    // Application Type: Console
    // Description:Cost for flooring
    // Author: Jacob Radtke
    // Date Created: 12/5/2019
    //

    class Program
    {
        static void Main(string[] args)
        {
            #region 
            string widthString;
            string lengthString;
            string costFoot;
            string room1Name = "1st";
            double room1Length, room1Width;
            double room1CostSqFoot;
            double room1Area;
            double room1Cost;
            string width2String;
            string length2String;
            string cost2Foot;
            string room2Name = "2nd";
            double room2Length, room2Width;
            double room2CostSqFoot;
            double room2Area;
            double room2Cost;
            string width3String;
            string length3String;
            string cost3Foot;
            string room3Name = "3rd";
            double room3Length, room3Width;
            double room3CostSqFoot;
            double room3Area;
            double room3Cost;
            string width4String;
            string length4String;
            string cost4Foot;
            string room4Name = "4th";
            double room4Length, room4Width;
            double room4CostSqFoot;
            double room4Area;
            double room4Cost;
            string width5String;
            string length5String;
            string cost5Foot;
            string room5Name = "5th";
            double room5Length, room5Width;
            double room5CostSqFoot;
            double room5Area;
            double room5Cost;
            double totalArea;
            double totalCost;
            //
            // Welcome
            //
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine();
            Console.Write("Welcome");
            Console.WriteLine();
            //
            //
            //
            Console.WriteLine();
            Console.Write("This program will tell you how much it costs to floor your house.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region 
            //
            // Measurements
            //
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("What is the Length of your 1st room?");
            lengthString = Console.ReadLine();
            while (!double.TryParse(lengthString, out room1Length))
            {
                Console.WriteLine("Enter a number");
                lengthString = Console.ReadLine();
            }
            Console.Write("\tThe length is " + room1Length + " feet.");
            room1Length = double.Parse(lengthString);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the width of your 1st room?");
            widthString = Console.ReadLine();
            while (!double.TryParse(widthString, out room1Width))
            {
                Console.WriteLine("Enter a number");
                widthString = Console.ReadLine();
            }
            Console.Write("\tThe width is " + room1Width + " feet.");
            room1Width = double.Parse(widthString);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            costFoot = Console.ReadLine();
            while (!double.TryParse(costFoot, out room1CostSqFoot))
            {
                Console.WriteLine("Enter a number");
                costFoot = Console.ReadLine();
            }
            room1CostSqFoot = double.Parse(costFoot);
            Console.Write("\tThe cost per square foot is " + room1CostSqFoot + " dollars.");
            Console.WriteLine();
            Console.Clear();
            #endregion
            #region 
            //
            // Second Room 
            //
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the length of your 2nd room?");
            length2String = Console.ReadLine();
            while (!double.TryParse(length2String, out room2Length))
            {
                Console.WriteLine("Enter a number");
                length2String = Console.ReadLine();
            }
            room2Length = double.Parse(length2String);
            Console.Write("\tThe length is " + room2Length + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the width of your 2nd room?");
            width2String = Console.ReadLine();
            while (!double.TryParse(width2String, out room2Width))
            {
                Console.WriteLine("Enter a number");
                width2String = Console.ReadLine();
            }
            room2Width = double.Parse(width2String);
            Console.Write("\tThe width is " + room2Width + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost2Foot = Console.ReadLine();
            while (!double.TryParse(cost2Foot, out room2CostSqFoot))
            {
                Console.WriteLine("Enter a number");
                cost2Foot = Console.ReadLine();
            }
            room2CostSqFoot = double.Parse(cost2Foot);
            Console.Write("\tThe cost per square foot is " + room2CostSqFoot + " dollars.");
            Console.WriteLine();
            Console.Clear();
            #endregion
            #region 
            //
            // Third Room 
            //
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the length of your 3rd room?");
            length3String = Console.ReadLine();
            while (!double.TryParse(length3String, out room3Length))
            {
                Console.WriteLine("Enter a number");
                length3String = Console.ReadLine();
            }
            room3Length = double.Parse(length3String);
            Console.Write("\tThe length is " + room3Length + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the width of your 3rd room?");
            width3String = Console.ReadLine();
            while (!double.TryParse(width3String, out room3Width))
            {
                Console.WriteLine("Enter a number");
                width3String = Console.ReadLine();
            }
            room3Width = double.Parse(width3String);
            Console.Write("\tThe width is " + room3Width + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost3Foot = Console.ReadLine();
            while (!double.TryParse(cost3Foot, out room3CostSqFoot))
            {
                Console.WriteLine("Enter a number");
                cost3Foot = Console.ReadLine();
            }
            room3CostSqFoot = double.Parse(cost3Foot);
            Console.Write("\tThe cost per square foot is " + room3CostSqFoot + " dollars.");
            Console.WriteLine();
            Console.Clear();
            #endregion
            #region 
            //
            // Fourth Room
            //
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tell me the length of your 4th room?");
            length4String = Console.ReadLine();
            while (!double.TryParse(length4String, out room4Length))
            {
                Console.WriteLine("Enter a number");
                length4String = Console.ReadLine();
            }
            room4Length = double.Parse(length4String);
            Console.Write("\tThe length is " + room4Length + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the width of your 4th room?");
            width4String = Console.ReadLine();
            while (!double.TryParse(width4String, out room4Width))
            {
                Console.WriteLine("Enter a number");
                width4String = Console.ReadLine();
            }
            room4Width = double.Parse(width4String);
            Console.Write("\tThe width is " + room4Width + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost4Foot = Console.ReadLine();
            while (!double.TryParse(cost4Foot, out room4CostSqFoot))
            {
                Console.WriteLine("Enter a number");
                cost4Foot = Console.ReadLine();
            }
            room4CostSqFoot = double.Parse(cost4Foot);
            Console.Write("\tThe cost per square foot is " + room4CostSqFoot + " dollars.");
            Console.WriteLine();
            Console.Clear();
            #endregion
            #region 
            //
            //Fifth Room 
            //
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tell me the length of your 5th room.");
            length5String = Console.ReadLine();
            while (!double.TryParse(length5String, out room5Length))

            {
                Console.WriteLine("Enter a number");
                length5String = Console.ReadLine();
            }
            room5Length = double.Parse(length5String);
            Console.Write("\tThe length is " + room5Length + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What is the width of your 5th room?");
            width5String = Console.ReadLine();
            while (!double.TryParse(width5String, out room5Width))

            {
                Console.WriteLine("Enter a number");
                widthString = Console.ReadLine();
            }
            room5Width = double.Parse(width5String);
            Console.Write("\tThe width is " + room5Width + " feet.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost5Foot = Console.ReadLine();
            while (!double.TryParse(cost5Foot, out room5CostSqFoot))

            {
                Console.WriteLine("Enter a number");
                costFoot = Console.ReadLine();
            }
            room5CostSqFoot = double.Parse(cost5Foot);
            Console.Write("\tThe cost per square foot is " + room5CostSqFoot + " dollars.");
            Console.WriteLine();
            Console.Clear();
            #endregion
            #region 
            //
            //  Calculate Table Values 
            //
            room1Area = room1Length * room1Width;
            room1Cost = room1Area * room1CostSqFoot;
            room2Area = room2Length * room2Width;
            room2Cost = room2Area * room2CostSqFoot;
            room3Area = room3Length * room3Width;
            room3Cost = room3Area * room3CostSqFoot;
            room4Area = room4Length * room4Width;
            room4Cost = room4Area * room4CostSqFoot;
            room5Area = room5Length * room5Width;
            room5Cost = room5Area * room5CostSqFoot;
            totalArea = room1Area + room2Area;
            totalCost = room1Cost + room2Cost;
            #endregion
            #region
            //
            //  show Table values
            //
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(
            room1Name.PadRight(15) +
            room1Length.ToString("f").PadLeft(10) +
            room1Width.ToString("f").PadLeft(10) +
            room1Area.ToString("f").PadLeft(10) +
            room1CostSqFoot.ToString("c").PadLeft(15) +
            room1Cost.ToString("c").PadLeft(10)
            );
            Console.WriteLine(
            room2Name.PadRight(15) +
            room2Length.ToString("f").PadLeft(10) +
            room2Width.ToString("f").PadLeft(10) +
            room2Area.ToString("#.###").PadLeft(10) +
            room2CostSqFoot.ToString("c").PadLeft(15) +
            room2Cost.ToString("c").PadLeft(10)
            );
            Console.WriteLine(
            room3Name.PadRight(15) +
            room3Length.ToString("f").PadLeft(10) +
            room3Width.ToString("f").PadLeft(10) +
            room3Area.ToString("#.###").PadLeft(10) +
            room3CostSqFoot.ToString("c").PadLeft(15) +
            room3Cost.ToString("c").PadLeft(10)
            );
            Console.WriteLine(
            room4Name.PadRight(15) +
            room4Length.ToString("f").PadLeft(10) +
            room4Width.ToString("f").PadLeft(10) +
            room4Area.ToString("#.###").PadLeft(10) +
            room4CostSqFoot.ToString("c").PadLeft(15) +
            room4Cost.ToString("c").PadLeft(10)
            );
            Console.WriteLine(
            room5Name.PadRight(15) +
            room5Length.ToString("f").PadLeft(10) +
            room5Width.ToString("f").PadLeft(10) +
            room5Area.ToString("#.###").PadLeft(10) +
            room5CostSqFoot.ToString("c").PadLeft(15) +
            room5Cost.ToString("c").PadLeft(10)
            );
            Console.WriteLine(
                "------".PadLeft(45) +
                "------".PadLeft(25)
                );
            Console.WriteLine(
            "Total".PadLeft(5) +
            totalArea.ToString("f").PadLeft(40) +
            totalCost.ToString("c").PadLeft(25)
            );
            #endregion

            #region 
            //
            //Pause For User
            //
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine("Thank you for using my application.");
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
            #endregion
        }
    }
}