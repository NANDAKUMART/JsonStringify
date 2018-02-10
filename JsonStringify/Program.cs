using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace JsonStringify
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex exObj = new Ex()
            {
                floatVar = 232.354F,
                strVar = "sometexthere",
                slfObj = new Ex(),
                intVar1 = 11,
                intVar2 = 333,
                slfObjList = new List<EX1>() 
                { 
                    new EX1() { ex1_var1 = 8, ex1_var2 = 99 }, 
                    new EX1() { ex1_var1 = 82, ex1_var2 = 992, ex1_lev3 = new Level3()
                    {
                        ex1_lev4 = new Level4()
                        {
                             ex1_var1 =11, 
                             ex1_var2 = 99
                        },
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
            };

            var stringifiedTxt = Converter.StringifyJson(exObj.GetType(), exObj);
            Console.WriteLine(stringifiedTxt);
            Console.ReadLine();
        }
    }


}
