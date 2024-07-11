using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // Make an Emplyee class take a generic type parameter 
    public class Employee<T>
    {
        // Add property called things with generic list data type
        public List<T> things { get; set; }


    }
}
