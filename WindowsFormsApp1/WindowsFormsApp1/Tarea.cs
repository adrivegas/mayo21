using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Tarea
    {
        public int sumaglo;

        public long suma()
        {

            long val = 0;

            for (long i = 0; i < 100000000; i++)
            {
                val += i;

                Console.WriteLine(val);
             
            }

            return val;
        }
   }
}
