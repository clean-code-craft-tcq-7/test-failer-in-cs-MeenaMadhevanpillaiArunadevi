using System;
using System.Diagnostics;
namespace MisalignedSpace{
    public partial class Misaligned{
        public static void test_ColorPair()
        {
            int result = printColorMap();
            Debug.Assert(result == 25);
            //Test if Color Pair number starts from 1 instead of 0 (i.e., 1-25 color pair)
            Debug.Assert(formatColorPairFromColorIndex(0, 0) == "1  | White | Blue");
            //Test Single Digit Color Pair number
            Debug.Assert(formatColorPairFromColorIndex(0, 4) == "5  | White | Slate");
            //Test Double Digit Color Pair number
            Debug.Assert(formatColorPairFromColorIndex(2, 3) == "14 | Black | Brown");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
           
