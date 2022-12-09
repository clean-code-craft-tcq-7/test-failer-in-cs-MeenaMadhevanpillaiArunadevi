using System;
using System.Diagnostics;
namespace AlerterSpace{
  public partial class Alerter{
       
       public static void TestAlerter(string env)
        {
            switch (env)
            {
                case "dev":
                    alertInCelcius(networkAlertStub, 392f);
                    Console.WriteLine("{0} alerts failed.", alertFailureCount);
                    Debug.Assert(alertFailureCount == 0);

                    alertInCelcius(networkAlertStub, 303.6f);
                    Console.WriteLine("{0} alerts failed.", alertFailureCount);
                    Debug.Assert(alertFailureCount == 0);

                    alertInCelcius(networkAlertStub, 400.5f);
                    Console.WriteLine("{0} alerts failed.", alertFailureCount);
                    Debug.Assert(alertFailureCount == 1);
                    break;
                case "prod":
                    alertInCelcius(networkAlert, 392f);
                    Debug.Assert(alertFailureCount == 0);
                    alertInCelcius(networkAlert, 303.6f);
                    Debug.Assert(alertFailureCount == 0);
                    alertInCelcius(networkAlert, 400.5f);
                    Debug.Assert(alertFailureCount == 0);
                    break;
                default:
                    throw new Exception("Environment setting in valid");
            }

            Console.WriteLine("All is well (maybe!)\n");

        }
  }
}
