using System;
using System.Diagnostics;
namespace MisalignedSpace{
    public partial class Misaligned{
            public static void testTwentyFivePair_ColorManual(){
                        //int result = printColorMap();
                        //Debug.Assert(result == 25);
                        //Debug.Assert(result == 36);
                        string result = printColorMap(4);
                        Debug.Assert(result == "White | Slate");
                        Console.WriteLine("All is well (maybe!)");
            }
    }
}
           
