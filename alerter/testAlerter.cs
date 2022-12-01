using System;
using System.Diagnostics;
namespace AlerterSpace{
  public partial class Alerter{
      public static void TestAlerter(){
            alertInCelcius(400.5f); //>392F (200C)
            alertInCelcius(392.0f); //=392F
            alertInCelcius(303.6f); //<392F
            Console.WriteLine("{0} alerts failed.", alertFailureCount);
            Debug.Assert(alertFailureCount == 0);
            Console.WriteLine("All is well (maybe!)\n");
      }
  }
}
