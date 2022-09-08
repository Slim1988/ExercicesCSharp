using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    public static class Calcul
    {
        public static DateTime _dateofbirth;
        public static int GetAge(DateTime dateofbirth)
        {
            
          int  age = DateTime.Now.Year - dateofbirth.Year;
            return age;
    
        }
    }
}
