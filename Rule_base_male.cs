using System; 


namespace sugeno {

    public class Rule_base_male {
        private float[] alpha ={0,0,0,0,0,0,0,0,0}; 
 private float[] z = {1,2,2,2,3,3,3,4,4};
// for all rule base value of degree of membershi[ and output        
        public void compute(Tuple<float,float,float> strength , Tuple<float,float,float> money){
            // This function takes the fuzzy sets and computes degree of memberships of rules in rule base
            float x= Math.Max(2.3f,5.7f);
            Console.WriteLine(x);
            alpha[0] = Math.Min(strength.Item1,money.Item1);
            
            alpha[1] = Math.Min(strength.Item1,money.Item2);
            alpha[2] = Math.Min(strength.Item1,money.Item3);
            alpha[3] = Math.Min(strength.Item2,money.Item1);
            alpha[4] = Math.Min(strength.Item2,money.Item2);
            alpha[5] = Math.Min(strength.Item2,money.Item3);
            alpha[6] = Math.Min(strength.Item3,money.Item1);
            alpha[7] = Math.Min(strength.Item3,money.Item2);
            alpha[8] = Math.Min(strength.Item3,money.Item3);
            

        }
        public float avg_calc(){
            // This function performs defuzzification
            float numerator =0f;
            float product =0f;
            float avg =0f;
            for( int i =0 ; i<9;i++ ){
                product = alpha[i]*z[i];
                numerator = numerator + product;

            }
            float denominator=0f;
            for (int j=0 ; j<9 ; j++){
                denominator = denominator +alpha[j];

            }
            avg = numerator/denominator;
            return avg;

        }
    }
}
