using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double PackageAmount = 0.0;
            Console.WriteLine("Enter Your Salary packege Ammount!");
            Console.Write("Package Amount: $");
            PackageAmount = Convert.ToDouble(Console.ReadLine());
            OKINPUT:
            Console.WriteLine("Enter Your Pay Frequency(M for Monthly,F for Fortnightly,W for Weekly!");
            char input1 = char.Parse(Console.ReadLine());

            if (input1 == 'M' || input1 == 'W' || input1 == 'F')
            {

                Console.WriteLine("Calculating Salary Details....");
                Console.WriteLine("Gross Package:$" + PackageAmount);
                double number1 = Convert.ToDouble(PackageAmount);
                double Multiple = 9.5;
                double super = (number1 * Multiple) / 100;
                double Taxableincome = Convert.ToDouble(PackageAmount) - super;

                Console.WriteLine("Taxable Income:$" + Taxableincome);

                Console.WriteLine("Deductions...");

                double Medicare_Levy = 0.0;
                double Budget_repair_Lavy = 0.0;

                if (Taxableincome >= 0 && Taxableincome <= 21335)
                {
                    Medicare_Levy = 0;
                    Console.WriteLine("Medicare_Levy:" + Medicare_Levy);
                }

                if (Taxableincome >= 21336 && Taxableincome <= 26668)
                {
                    double Meducare = Taxableincome - 21336;
                    Medicare_Levy = (Meducare * 10) / 100;
                    Console.WriteLine("Medicare_Levy:" + Medicare_Levy);

                }

                if (Taxableincome >= 26669)
                {

                    Medicare_Levy = (Taxableincome * 2) / 100;
                    Console.WriteLine("Medicare_Levy:" + Medicare_Levy);
                }

                if (Taxableincome >= 0 && Taxableincome <= 180000)
                {
                    Budget_repair_Lavy = 0.0;
                    Console.WriteLine("Budget Repair Lavy:" + Budget_repair_Lavy);
                }
                if (Taxableincome >= 180001)
                {
                    double number2 = Taxableincome - 180001;
                    Budget_repair_Lavy = (number2 * 2) / 100;
                    Console.WriteLine("Budget Repair Lavy:" + Budget_repair_Lavy);
                }
                double incometax = 0;
                if (Taxableincome >= 0 && Taxableincome <= 18200)
                {
                    incometax = 0;
                    Console.WriteLine("Income Tax:" + incometax);
                }
                if (Taxableincome >= 18201 && Taxableincome <= 37000)
                {
                    double excess = Taxableincome - 18201;
                    incometax = (excess * 19) / 100;
                    Console.WriteLine("Income Tax:" + incometax);
                }
                if (Taxableincome >= 37001 && Taxableincome <= 87000)
                {
                    double excess = Taxableincome - 37001;
                    incometax = (excess * 32.5) / 100;
                    incometax = incometax + 3572;
                    Console.WriteLine("Income Tax:", +incometax);
                }

                if (Taxableincome >= 87001 && Taxableincome <= 180000)
                {
                    double excess = Taxableincome - 87001;
                    incometax = (excess * 37) / 100;
                    incometax = incometax + 19822;
                    Console.WriteLine("Income Tax:", +incometax);
                }

                if (Taxableincome >= 87001)
                {
                    double excess = Taxableincome - 87001;
                    incometax = (excess * 47) / 100;
                    incometax = incometax + 54232;
                    Console.WriteLine("Income Tax:" + incometax);

                }
                double netincome = 0.0;
                double deductions = incometax + Medicare_Levy + Budget_repair_Lavy;
                netincome = Convert.ToDouble(PackageAmount) - super - deductions;

                Console.Write("Net Income:" + netincome);


                Console.Write(SwitchChar(input1, PackageAmount));
                Console.Read();
            }
            else
            {
                Console.Write("Please Enter Write Choice:");
                goto OKINPUT; 
            }
        }
        static string SwitchChar(char input, double netincome)
        {
            switch (input)
            {
                case 'M':
                    {
                        
                        double permonthincome =Math.Round(netincome / 12);
                        Console.WriteLine("Income per Month: $"+permonthincome);
                            return Convert.ToString(netincome);
                    }
                case 'F':
                    {
                        double permonthincome =Math.Round(netincome / 26);
                        Console.WriteLine("Income per FOrtnight: $", permonthincome);
                        return Convert.ToString(netincome);
                    }
                case 'W':
                    {
                       
                       double perweekincome =Math.Round(netincome / 52);
                        Console.WriteLine("Income per Weeek: $", perweekincome);
                        return Convert.ToString(perweekincome);
                    }
                default:
                    {
                        return "Deal";
                    }
            }
        }

    }
}
