﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Method_assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick a whole and positive number.");
            int userInp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number doubled is " + Operator.intDouble(userInp));
            Console.WriteLine("Your number tripled is " + Operator.intTriple(userInp));
            Console.WriteLine("Your number quadrupled is " + Operator.intQuadruple(userInp));
            Console.ReadLine();
        }
    }
}
