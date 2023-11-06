using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService2.Classes
{
    public class Count
    {
        private static int uniqueIdentifier ;

        public string GenerateUniqueOrderNumber()
        {
           
            string uniquePart = (uniqueIdentifier++ % 10).ToString("D5"); 

           
            return uniquePart;
        }
    }
}
