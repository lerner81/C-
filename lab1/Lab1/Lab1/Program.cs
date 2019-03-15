using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sLength, sWidth, sFloorCost;
            int length, width, totalSqFeet;
            double floorCost, totalFloorCost, hoursWork, totalLaborCost, totalProject;
            double COSTPERHOUR = 35.75, SQFEETPERHOUR = 40;

            //Header
            WriteLine("Mark's Flooring Cost Estimator: ");

            //Prompts user for project details
            Write("Please enter length of floor in whole numbers: ");
            sLength = ReadLine();
            length = Convert.ToInt32(sLength);

            Write("Please enter width of floor: ");
            sWidth = ReadLine();
            width = Convert.ToInt32(sWidth);

            Write("Please enter the cost per square foot for the flooring selected: ");
            sFloorCost = ReadLine();
            floorCost = Convert.ToDouble(sFloorCost);

            //Computes and gives output for total floor cost

            totalSqFeet = length * width;
            totalFloorCost = totalSqFeet * floorCost;

            WriteLine("For a total floor size of " + totalSqFeet + " the flooring cost is: " + (totalFloorCost.ToString("C2")));

            //Computes and gives output for total labor cost

            hoursWork = totalSqFeet / SQFEETPERHOUR;
            totalLaborCost = hoursWork * COSTPERHOUR;

            WriteLine("It will take " + (hoursWork.ToString("F2")) + " to install the floor at a cost of " + (totalLaborCost.ToString("C2")));

            //Computes and gives out total project costs

            totalProject = totalFloorCost + totalLaborCost;
            WriteLine("The total finished cost for the new floor is: " + (totalProject.ToString("C2")));
        }
    }
}
