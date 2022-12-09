using System;
using System.Diagnostics;

namespace AlerterSpace
{
    public partial class Alerter
    {
        static string env;
        static int alertFailureCount = 0;
        //production network
        static int networkAlert(float celsius)
        {
            return 200;
        }
     
        static void alertInCelcius(Func<float,int>func, float farenheit)
        {
            float celsius = (farenheit - 32) * 5 / 9;
            //pass the necessary method based on the environment (networkAlerter or its stub method)
            int returnCode = func(celsius);
            if (returnCode != 200)
            {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 1;
            }
        }
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                env = args[0];
            }
            else
            {
                env = "dev";
            }
           
            TestAlerter(env);
        }

      
       
    }

}
