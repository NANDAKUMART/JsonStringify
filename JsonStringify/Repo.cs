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
        public Level5 ex5_lev5 { get; set; }
    }

    public class Level5
    {
        public int le5_ex1_var1 { get; set; }
        public int le5_ex1_var2 { get; set; }
        public Level6 ex1_lev6 { get; set; }
    }

    public class Level6
    {
        public int le5_ex1_var1 { get; set; }
        public int le5_ex1_var2 { get; set; }
    }

}
