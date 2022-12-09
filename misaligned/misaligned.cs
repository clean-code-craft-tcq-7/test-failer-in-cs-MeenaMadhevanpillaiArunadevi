using System;
using System.Diagnostics;

namespace MisalignedSpace
{
    public partial class Misaligned
    {
        static int printColorMap()
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            int i = 0, j = 0;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine(formatColorPairFromColorIndex(i, j));
                }
            }
            return i * j;
        }
        public static string formatColorPairFromColorIndex(int i, int j)
        {
            string[] majorColors = { "White", "Red", "Black", "Yellow", "Violet" };
            string[] minorColors = { "Blue", "Orange", "Green", "Brown", "Slate" };
            string colorpair = "";
            var majorcolor_length = majorColors[i].Length;
            var noOfSpaces = 7 - majorcolor_length;
            // 5 white  2  = 7
            // 3 red    4  = 7
            // 5 black  2  = 7
            // 6 yellow 1  = 7
            if (i * 5 + j + 1 < 10)
            { 
                //single digit
                switch(noOfSpaces)
                {
                    case 2:
                        // code block
                        colorpair = String.Format("{0}  | {1}  | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                    case 4:
                        // code block
                        colorpair = String.Format("{0}  | {1}    | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                    case 1:
                        // code block
                        colorpair = String.Format("{0}  | {1} | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                   
                }

            }
            else
            {
                //double digit
                switch (noOfSpaces)
                {
                    case 2:
                        // code block
                        colorpair = String.Format("{0} | {1}  | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                    case 4:
                        // code block
                        colorpair = String.Format("{0} | {1}    | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                    case 1:
                        // code block
                        colorpair = String.Format("{0} | {1} | {2}", i * 5 + j + 1, majorColors[i], minorColors[j]);
                        break;
                    
                }
            }
            return colorpair;
        }
        static void Main(string[] args)
        {
            test_ColorPair();
        }
    }
}
