using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_Exam_5_Problem_FindBits
{
    class FindingBits
    {
        static void Main(string[] args)
        {
            int count = 0;
            int s = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int k = 0; k < m; k++)
            {
                int n = int.Parse(Console.ReadLine());

                //int mask = n & s;
                //string strMask = Convert.ToString(mask, 2).PadLeft(29, '0');
                //Console.WriteLine(strMask);
                string strS = Convert.ToString(s, 2).PadLeft(5, '0');
                //Console.WriteLine(strS);
                string strN = Convert.ToString(n, 2).PadLeft(29, '0');
                //Console.WriteLine(strN);
                

                for (int i = 0; i < strN.Length - 5 + 1; i++)
                {
                    //strN.Substring(i, 5);
                    if (strS == strN.Substring(i, 5))
                    {
                        ++count;
                    }
                }
            }

            Console.WriteLine(count);


        }
    }
}
