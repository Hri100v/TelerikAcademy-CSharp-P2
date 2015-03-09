/*
encoding	is	done	as	follows:
• If	the	character	is	“@”,	stop	the	program
• If	the	character	in	the	text	is	a	letter,	multiply	its	char	code	by	the	given	SECRET and	add	1000.
• If	the	character	in	the	text	is	a	digit,	add	to	its	char	code	SECRET and	add	500
• If	the	character	in	the	text	is	not	a	digit,	letter	or	“@” (any	other	symbol),	
    subtract	from	its	char  code	SECRET
• After	performing	the	above	operations	on	the	character	in	the	original	text:
o If	 the	 character	 is	 on	 even	 position	 in	 the	 text - divide	 the	 encoded	 value	 
    by	 100 and	round	the	precision	to	2	digits	after the	decimal	point
o Else	if	the	character	is	on	odd	position	in	the	original	text	– multiply its	encoded	value	by	
100
o The	first	character	in	the	text	is	at	position	0.	
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Symbol_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int secret = int.Parse(Console.ReadLine());
            string expres = Console.ReadLine();
            int count = 0;
            int tempNum;
            char tempChar;
            decimal result;
            
            foreach (char symbol in expres)
            {
                tempNum = 0;
                if (symbol == '@')
                {
                    break;
                }
                tempNum = Convert.ToInt32(symbol);
                if (Char.IsDigit(symbol))   //digit,	add	to	its	char	code	SECRET and	add	500
                {
                    tempNum = tempNum + secret + 500;
                    //Console.WriteLine(tempNum);
                }
                else if (Char.IsLetter(symbol)) //letter, multiply its	char code by the given SECRET and add 1000
                {
                    tempNum = tempNum * secret + 1000;
                }
                else    //not	a	digit,	letter	or	“@” (any	other	symbol),subtract from its char  code	SECRET
                {
                    tempNum = tempNum - secret;
                    //Console.WriteLine("NO Digit");
                }

                //Console.WriteLine(tempNum);
                

                //check even or odd
                if (count % 2 == 0)   //is even
                {                           //divide the encoded value by 100 and round	the	precision to 2 digits after the	decimal	point
                    result = (decimal)tempNum / 100.00M;
                    Console.WriteLine("{0:0.00}", result);
                }
                else    //is odd
                {       //multiply its	encoded	value	by	100
                    result = (decimal)tempNum * 100;
                    Console.WriteLine("{0}", result);
                }

                ++count;
            }

            //char t = 'T';
            //char e = 'e';
            //
            //int num1 = Convert.ToInt32(t);
            //Console.WriteLine(num1);
            //Console.WriteLine(num1 + 1);
            //
            //int tempNum = int.Parse(t.ToString());
            //Console.WriteLine(tempNum);
        }
    }
}
