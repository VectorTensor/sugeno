using System;

namespace sugeno {
    class mother{
        public static void Main(String[] args){
var tuple1= Tuple.Create<float,float,float>(0.1f,0.5f,0.7f);
var tuple2= Tuple.Create<float,float,float>(0.2f,0.9f,0.3f);
            Rule_base_male rb = new Rule_base_male();
            rb.compute(tuple1,tuple2);
            float x= rb.avg_calc();
            Console.WriteLine(x);


        }
    }
}
