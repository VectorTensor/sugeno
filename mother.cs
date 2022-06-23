using System;

namespace sugeno {
    class mother{
        public static void Main(String[] args){
var tuple= Tuple.Create<float,float,float>(0.1,0.5,0.7);
            Rule_base rb = new Rule_base();
            rb.compute(tuple,tuple);

        }
    }
}
