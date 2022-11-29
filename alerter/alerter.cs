using System;
using System.Diagnostics;

namespace AlerterSpace {
    public partial class Alerter {
        static bool isProduction = false;
        static int alertFailureCount = 0;
        static int networkAlertStub(float celcius) {
            Console.WriteLine("ALERT: Temperature is {0} celcius", celcius);
            // Return 200 for ok
            // Return 500 for not-ok
            // stub always succeeds and returns 200
            return (int)celcius;
        }
        static int networkAlerter(float celcius){
            return (int)celcius;
        }
        static void alertInCelcius(float farenheit) {
            float celcius = (farenheit - 32) * 5 / 9;
            //check if production or test to switch between networkAlerter and its stub method
            int returnCode = isProduction == false ? networkAlertStub(celcius) : networkAlerter(celcius);
            if (returnCode != 200) {
                // non-ok response is not an error! Issues happen in life!
                // let us keep a count of failures to report
                // However, this code doesn't count failures!
                // Add a test below to catch this bug. Alter the stub above, if needed.
                alertFailureCount += 1;
            }
        }
        static void Main(string[] args) {
            TestAlerter();
        }
    }
}
