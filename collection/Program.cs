﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file path: ");
            string filePath = Console.ReadLine();

            ContactManager cm = new ContactManager(filePath);

            Console.WriteLine("\nEnties: ");
            
            foreach(ContactEntry ce in cm.Entries)
            {
                Console.WriteLine(ce.ToString());
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
