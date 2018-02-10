using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonStringify
{
    public class Ex
    {
        public float floatVar { get; set; }
        public string strVar { get; set; }
        public Ex slfObj { get; set; }
        public List<EX1> slfObjList { get; set; }
        public int intVar1 { get; set; }
        public int intVar2 { get; set; }
    }

    public class EX1
    {
        public int ex1_var1 { get; set; }
        public int ex1_var2 { get; set; }
        public Level3 ex1_lev3 { get; set; }
    }

    public class Level3
    {
        public int ex1_var1 { get; set; }
        public int ex1_var2 { get; set; }
        public Level4 ex1_lev4 { get; set; }
    }

    public class Level4
    {
        public int ex1_var1 { get; set; }
        public int ex1_var2 { get; set; }
    }
}
