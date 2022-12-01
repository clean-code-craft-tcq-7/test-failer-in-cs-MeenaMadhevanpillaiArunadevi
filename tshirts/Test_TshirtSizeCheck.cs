using System;
using System.Diagnostics;

namespace TshirtSpace {
    public partial class Tshirt {
       
        public static void test_GetTshirt_size() {
           
            Debug.Assert(Size(37) == "S");
            Debug.Assert(Size(40) == "M");
            Debug.Assert(Size(43) == "L");
            Debug.Assert(Size(38) == "S");
            Debug.Assert(Size(42) == "M");
            Debug.Assert(Size(-1) == "Not exists");
            Console.WriteLine( "All is well (maybe!)");
      
        }
    }
}
