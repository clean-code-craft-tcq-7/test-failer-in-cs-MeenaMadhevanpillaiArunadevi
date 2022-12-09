using System;
using System.Diagnostics;
namespace MisalignedSpace{
    public partial class Misaligned{
        public static void test_ColorPair()
        {
            int result = printColorMap();
            Debug.Assert(result == 25);
            //Test if Color Pair number starts from 1 instead of 0 (i.e., 1-25 color pair)
            //Alignment of Major Color and separator is also considered 
            Debug.Assert(formatColorPairFromColorIndex(0, 0) == "1  | White  | Blue");  //2 spaces between White and |
            //Test Single Digit Color Pair number
            Debug.Assert(formatColorPairFromColorIndex(0, 4) == "5  | White  | Slate");
            //Test Double Digit Color Pair number
            Debug.Assert(formatColorPairFromColorIndex(2, 3) == "14 | Black  | Brown");
            //Test variable length Colors
            Debug.Assert(formatColorPairFromColorIndex(1, 1) == "7  | Red    | Orange"); //4 spaces between Red and |
            //Additional check on variable length Color
            Debug.Assert(formatColorPairFromColorIndex(1, 1) == "17 | Yellow | Orange"); //1 space between Yellow and |
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
           
