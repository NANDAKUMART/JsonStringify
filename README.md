# JsonStringify

<b>Object to Json Stringify</b>

<b>What is this repo all about?</b><br/>
  You can use it to convert the object to json string. <br/>
  
<b>Any limitation here?</b><br/>
 No self recursion is allowed here. As of now, List is supported as part of this. Will add more here. <br/>
 
<b>Any samples here?</b><br/>
 Yes. Lets take this one.<br/>
 
<pre>
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

</pre>

<b>This is producing the Json string as:-</b><br/>

<pre>
{floatVar:232.354,strVar:"haha", slfObjList:[{ex1_var1:8,ex1_var2:99,},{ex1_var1:82,ex1_var2:992,
ex1_lev3:{ex1_var1:22,ex1_var2:55,ex1_lev4:{ex1_var1:11,ex1_var2:99}}}],intVar1:11,intVar2:333}
</pre>

Will add more here.

Thx for stopping by :)
