using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BuzzFizz
    {
        private int upperBound;
        public BuzzFizz(int intUpperBound)
        {
            this.upperBound = intUpperBound;
        }

        public static void StaticOutput(int upperBound)
        {
            
            for (int i = 1; i <= upperBound; i++)
            {
                string strReturn = "";
                if (i % 3 == 0)
                {
                    strReturn += "Buzz";
                }
                if (i % 5 == 0)
                {
                    strReturn += "Fizz";
                }
                if ((i % 3 != 0) && (i % 5 != 0))
                {
                    strReturn += i.ToString();
                }
                Console.WriteLine(strReturn);
            }
        }
        public void ObjectInstanceOutput()
        {
            for (int i = 1; i <= this.upperBound; i++)
            {
                string strReturn = "";
                if (i % 3 == 0)
                {
                    strReturn += "Buzz";
                }
                if (i % 5 == 0)
                {
                    strReturn += "Fizz";
                }
                if ((i % 3 != 0) && (i % 5 != 0))
                {
                    strReturn += i.ToString();
                }
                Console.WriteLine(strReturn);
            }
        }

    }
}
