using System;

 public class Fuzzy_membership{
    
    private float left_shoulder_trapezoidal(float x){
        float calculated;

        if (x <= 20){
            return 1;
        }

        else if(x >= 40){
            return 0;
        }

        else{
            calculated = (40 - x) / 20;
            return calculated;
        }
    }

    private float middle_triangle(float x)
    {
        float calculated;
        if (x>=30 &&  x<=50)
        {
            calculated = (x - 30) / 20;
            return calculated;
        }

        else if(x>=50 && x<=70)
        {
            calculated = (70 - x) / 20;
            return calculated;
        }

        else
        {
            return 0;
        }
    }

    private float right_shoulder_trapezoidal(float x){
        float calculated;

        if (x >= 80){
            return 1;
        }

        else if(x <= 60){
            return 0;
        }

        else{
            calculated = (x - 60) / 20;
            return calculated;
        }
    } 

    public (float, float, float) membership_values(float x)
    {
        return (left_shoulder_trapezoidal(x), middle_triangle(x),  right_shoulder_trapezoidal(x));
    }
    
}

namespace Sample1{
 public class Program{
    static void Main(string[] args)
    {
        Fuzzy_membership f = new Fuzzy_membership();
        Console.WriteLine(f.membership_values(40));
    }
}
}