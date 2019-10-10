﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        // field
        private string empName;

        // properties
        public string Name
        {
            get { return empName; }
            set
            {
                // perform validation
                if (value.Length > 15) { empName = value.Substring(0, 15); }
                else { empName = value; }
            }
        }

        // automatic properties
        public int ID { get; set; }
        public double Pay { get; set; }

        public void PrintState()
        {
            Console.WriteLine("Name:\t{0}", empName);
            Console.WriteLine("Name:\t{0}", Name);
            Console.WriteLine("ID:\t{0}", ID);
            Console.WriteLine("Pay:\t{0}", Pay);
        }
    }
}
