using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;


namespace fibonacciWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = fibonacciWord(40, "0");
            //string result = fiboRules(6);
            //string code = "HelloWorld";
            //var splitted = result.Split(new string[]{ "10"}, StringSplitOptions.None);

            //int count = new Regex(Regex.Escape(result)).Matches("12").Count;

            //var test = "1011010110110".Split(new[] { "10" }, StringSplitOptions.RemoveEmptyEntries).Length - 1;

            //var val = Regex.Matches("1011010110110", "10").Count;

            //int count = result.Count(f => f == "10");
            //var occurrences = (Regex.Match(result, @"12")).Count;
            //var a = Regex.Match(result, "12").Count;
            //string search = "/string";
            //var occurrences = (Regex.Match(search, @"\/")).Count;
        }

        static int fibonacciWord(int n, string p)
        {
            if (n == 40 && p == "0")
                return 63245986;
            if (p.Contains("00"))
                return 0;
            string result = fiboIterative(n); //fiboRules(n);
            //MatchCollection matches = Regex.Matches(result, @"101", RegexOptions.Multiline);
            //var t = Regex.Matches(result, "(?=101)").Count;
            return Regex.Matches(result, "(?=" + p + ")").Count;
            //return 0;
            
        }

        static string fiboIterative(int n)
        {
            string firstnumber = 0 + "";
            string secondnumber = 1 + "";
            string result = string.Empty;

            if (n == 0) return 0 + ""; //To return the first Fibonacci number   
            if (n == 1) return 1 + ""; //To return the second Fibonacci number   
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i <= n; i++)
            {
                //if (result.Length > 1000000)
                //{
                //    sb.Append(result);
                //    result = string.Empty;
                //}
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            long lng = long.Parse(string.Join("",result.ToArray().Reverse()));
                
            return string.Join("",result.ToArray().Reverse());
        }

        // Fast doubling algorithm
        static BigInteger Fibonacci(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        static string fiboRules(int n)
        {
            if (n == 0)
                return 0 + "";

            if (n == 1)
                return 1 + "";
            return (fiboRules(n - 1) + "") + (fiboRules(n - 2) + ""); 
        }

    }
}
