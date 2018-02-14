using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Newtonsoft;
using Newtonsoft.Json;

namespace JsonStringify
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n\n\n Run ::: " + i);

                Ex exObj = new Ex()
                {
                    floatVar = 232.354F,
                    strVar = "sometexthere",
                    slfObj = new Ex(),
                };

                Ex exObj1 = new Ex()
                {
                    floatVar = 232.354F,
                    strVar = "sometexthere",
                    slfObj = new Ex(),
                    intVar1 = 11,
                    intVar2 = 333,
                };


                Ex exObj2 = new Ex()
                {
                    floatVar = 232.354F,
                    strVar = "sometexthere",
                    slfObj = new Ex(),
                    intVar1 = 11,
                    intVar2 = 333,
                    slfObjList = new List<EX1>() 
                { 
                    new EX1() { ex1_var1 = 8, ex1_var2 = 99 }, 
                }
                };


                Ex exObj3 = new Ex()
                {
                    floatVar = 232.354F,
                    strVar = "sometexthere",
                    slfObj = new Ex(),
                    intVar1 = 11,
                    intVar2 = 333,
                    slfObjList = new List<EX1>() 
                { 
                    new EX1() { ex1_var1 = 8, ex1_var2 = 99 }, 
                    new EX1() { ex1_var1 = 82, ex1_var2 = 992,}                
                }
                };


                Ex exObj4 = new Ex()
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
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
                };


                Ex exObj5 = new Ex()
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

                Ex exObj6 = new Ex()
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
                             ex1_var2 = 99,
                              ex5_lev5 = new Level5()
                              {
                              }
                        },
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
                };


                Ex exObj7 = new Ex()
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
                             ex1_var2 = 99,
                              ex5_lev5 = new Level5()
                              { le5_ex1_var1 = 51,
                                   le5_ex1_var2 = 52
                              }
                        },
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
                };



                Ex exObj8 = new Ex()
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
                             ex1_var2 = 99,
                              ex5_lev5 = new Level5()
                              {  ex1_lev6 = new Level6()
                              {
                              }
                              }
                        },
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
                };

                Ex exObj9 = new Ex()
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
                             ex1_var2 = 99,
                              ex5_lev5 = new Level5()
                              {
                                   ex1_lev6 = new Level6()
                                   {
                                        le5_ex1_var1 = 61, le5_ex1_var2 = 62
                                   }
                              }
                        },
                        ex1_var1 = 22,
                        ex1_var2 =55
                    } 
                }
                }
                };




                var t1 = DateTime.Now;
                var str = "";

                if (i == 1)
                    str = JsonConvert.SerializeObject(exObj);
                else if (i == 2)
                    str = JsonConvert.SerializeObject(exObj1);
                else if (i == 3)
                    str = JsonConvert.SerializeObject(exObj2);
                else if (i == 4)
                    str = JsonConvert.SerializeObject(exObj3);
                else if (i == 5)
                    str = JsonConvert.SerializeObject(exObj4);
                else if (i == 6)
                    str = JsonConvert.SerializeObject(exObj5);
                else if (i == 7)
                    str = JsonConvert.SerializeObject(exObj6);
                else if (i == 8)
                    str = JsonConvert.SerializeObject(exObj7);
                else if (i == 9)
                    str = JsonConvert.SerializeObject(exObj8);
                else if (i == 10)
                    str = JsonConvert.SerializeObject(exObj9);

                var t2 = DateTime.Now.Subtract(t1).TotalMilliseconds;
                Console.WriteLine("Total Time:" + t2);
                Console.WriteLine(str);

                t1 = DateTime.Now;
                var stringifiedTxt = "";

                if (i == 1)
                    stringifiedTxt = Converter.StringifyJson(exObj);
                else if (i == 2)
                    stringifiedTxt = Converter.StringifyJson(exObj1);
                else if (i == 3)
                    stringifiedTxt = Converter.StringifyJson(exObj2);
                else if (i == 4)
                    stringifiedTxt = Converter.StringifyJson(exObj3);
                else if (i == 5)
                    stringifiedTxt = Converter.StringifyJson(exObj4);
                else if (i == 6)
                    stringifiedTxt = Converter.StringifyJson(exObj5);
                else if (i == 7)
                    stringifiedTxt = Converter.StringifyJson(exObj6);
                else if (i == 8)
                    stringifiedTxt = Converter.StringifyJson(exObj7);
                else if (i == 9)
                    stringifiedTxt = Converter.StringifyJson(exObj8);
                else if (i == 10)
                    stringifiedTxt = Converter.StringifyJson(exObj9);


                t2 = DateTime.Now.Subtract(t1).TotalMilliseconds;
                Console.WriteLine("\n\n Total Time:" + t2);
                Console.WriteLine(stringifiedTxt);


            }
            Console.ReadLine();
        }
    }


}
