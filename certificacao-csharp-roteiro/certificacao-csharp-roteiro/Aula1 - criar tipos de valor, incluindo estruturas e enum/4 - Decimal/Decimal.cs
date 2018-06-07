﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Decimal : IAulaItem
    {
        //The decimal keyword indicates a 128-bit data type.Compared to other floating-point types, the decimal type has more precision and a smaller range, which makes it appropriate for financial and monetary calculations.The approximate range and precision for the decimal type are shown in the following table.

        //Type Approximate Range Precision	.NET Framework type
        //decimal (-7.9 x 1028 to 7.9 x 1028) / (100 to 1028)	28-29 significant digits    System.Decimal
        //The default value of a decimal is 0m.

        //Literals
        //If you want a numeric real literal to be treated as decimal, use the suffix m or M, for example:

        //C#

        //Copy
        //decimal myMoney = 300.5m;
        //Without the suffix m, the number is treated as a double and generates a compiler error.

        //Conversions
        //The integral types are implicitly converted to decimal and the result evaluates to decimal. Therefore you can initialize a decimal variable using an integer literal, without the suffix, as follows:

        //C#

        //Copy
        //decimal myMoney = 300;
        //There is no implicit conversion between other floating-point types and the decimal type; therefore, a cast must be used to convert between these two types.For example:


        //C#

        //Copy
        //decimal myMoney = 99.9m;  
        //double x = (double)myMoney;  
        //myMoney = (decimal)x;  
        //You can also mix decimal and numeric integral types in the same expression.However, mixing decimal and other floating-point types without a cast causes a compilation error.
        public void Executar()
        {
            Console.WriteLine("Descobrindo se (0.1 + 0.2) == 0.3");
            Console.WriteLine((0.1 + 0.2) == 0.3);

            Console.WriteLine("Descobrindo se (0.1 + 0.2) == 0.30000000000000004");
            Console.WriteLine((0.1 + 0.2) == 0.30000000000000004);

            Console.WriteLine("Descobrindo se (0.1m + 0.2m) == 0.3m");
            Console.WriteLine((0.1m + 0.2m) == 0.3m);
        }
    }
}
