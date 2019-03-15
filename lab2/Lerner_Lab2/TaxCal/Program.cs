using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TaxCal
{/*Mark Lerner
    9/28/2018
   Federal Tax Calculator
   Lab2 uses switches for tax brackets and loops for error checking*/
    class Program
    {
        static void Main(string[] args)
        {
            double bracket, tax, percent, income;
            string numString;

            //Header and user prompt to enter taxable income 
            WriteLine("\t Mark's Tax Calculator for Married filing Jointly\n");
            Write("Please enter your taxable income for the year: ");
            numString = ReadLine();

            //converts data entered to double or exits program if string
            if (Double.TryParse(numString, out income))
            {

                //calculates taxes based on income brackets
                if (income <= 18650)
                {
                    tax = income * 0.10;
                    bracket = .10;
                }
                else if (income <= 75900)
                {
                    tax = 18650 * 0.10 + (income - 18650) * 0.15;
                    bracket = .15;
                }
                else if (income <= 153100)
                {
                    tax = 18650 * .10 + (75900 - 18650) * 0.15 + (income - 75900) * 0.25;
                    bracket = .25;
                }
                else if (income <= 233350)
                {
                    tax = 18650 * .10 + (75900 - 18650) * 0.15 + (153100 - 75900) * 0.25 + (income - 153100) * 0.28;
                    bracket = .28;
                }
                else if (income <= 416700)
                {
                    tax = 18650 * .10 + (75900 - 18650) * 0.15 + (153100 - 75900) * 0.25 + (233350 - 153100) * 0.28 + (income - 233350) * 0.33;
                    bracket = .33;
                }
                else if (income <= 470700)
                {
                    tax = 18650 * .10 + (75900 - 18650) * 0.15 + (153100 - 75900) * 0.25 + (233350 - 153100) * 0.28 + (416700 - 233350) * 0.33 + (income - 416700) * 0.35;
                    bracket = .35;
                }
                else
                {
                    tax = 18650 * .10 + (75900 - 18650) * 0.15 + (153100 - 75900) * 0.25 + (233350 - 153100) * 0.28 + (416700 - 233350) * 0.33 + (470700 - 416700) * 0.35 + (income - 470700) * 0.396;
                    bracket = .396;
                }
                //Final calculations output
                percent = tax / income;
                WriteLine($"Your total Federal Tax liability for the year is: {tax:C}");
                WriteLine($"Your final tax bracket is: {bracket:P}");
                WriteLine($"Your effective tax rate is: {percent:P}");
                
            }
        
            else
            Console.WriteLine("You must enter a number! The program is going to explode 5,4,3,2,1");

            
         }
    }
}
