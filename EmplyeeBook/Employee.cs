using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyeeBook
{
    /// <summary>
    /// this is a blue print
    /// </summary>

    public class Employee
    {
        /// <summary>
        /// property - string - need a space. space allocation
        /// </summary>
        public string Title { get; set; }

        public string Name { get; set; }

        public static Employee GetEmployee()
        {
        
           // crating an object

            var employee = new Employee()
            {
                Name = "Done Joe",
                Title = "CEO"
            };
            return employee;
        }

    }
}
