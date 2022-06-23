using System; 


namespace sugeno {

    public class Rule_base {
        private float[] alpha; 
 private float[] z;
        
        public void compute(Tuple<float,float,float> strength , Tuple<float,float,float> money){
            Console.WriteLine(strength);
            Console.WriteLine(money);
        }
    }
}
