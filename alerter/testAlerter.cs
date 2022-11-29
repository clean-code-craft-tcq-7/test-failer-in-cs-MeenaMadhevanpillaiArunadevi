using System;
using System.Diagnostics;
namespace AlerterSpace{
  public partial class Alerter{
      public static void TestAlerter(){
            alertInCelcius(400.5f);
            alertInCelcius(303.6f);
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Debug.Assert(alertFailureCount == 0);
            Console.WriteLine("All is well (maybe!)\n");
      }
  }
}
