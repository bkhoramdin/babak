using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;


namespace MyWCFServices



{
    public class RedPill : IRedPill
    {

       
        public System.Guid WhatIsYourToken()
        {
            Guid g = new Guid("702cff1c-675d-4d98-92dc-6d88f9a7304e");

            return g;

        }
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;
            else

            if (a == b && b == c)

                return TriangleType.Equilateral;
            else if (a == b || b == c || a == c)
                return TriangleType.Isosceles;
            else if(a != b && b != c)
                return TriangleType.Scalene;
            else           
                return TriangleType.Error;
                        
        }
        public long FibonacciNumber(long x)
        {
           
            if (x>92 || x<-92)
            {
                throw new ArgumentOutOfRangeException("Fib", "less than 92");
            }

            if (x < 0)
                return 1;
            
            if (x == 0) return 0;

            long prev = 0;
            long next = 1;
            for (int i = 1; i < x; i++)
            {
                long sum = prev + next;
                prev = next;
                next = sum;
            }
            return next;
           
        }

        public  string ReverseWords(string str)
        {
            if(str==null)
            {
                throw new ArgumentNullException("Null Argument");
            }
            var reversedWords = string.Join(" ",str.Split(' ')
          .Select(x => new String(x.Reverse().ToArray())));
        
       return reversedWords;
            
        }
    }
}
