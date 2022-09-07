using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    public static class GetAge
    {
        public static DateTime _dateofbirth;
        public static int calcul(DateTime dateofbirth)
        {
            int age = DateTime.Now.Year - dateofbirth.Year;

                return age;
            
        }
    }
}
