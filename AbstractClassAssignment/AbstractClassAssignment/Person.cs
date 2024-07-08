using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Create an abstract class called Person
    public abstract class Person
    {
        // Two properties called firstName and lastName
        public string firstName {  get; set; }
        public string lastName { get; set; }

        // Method called SayName()
        public abstract void SayName();
    }
}
