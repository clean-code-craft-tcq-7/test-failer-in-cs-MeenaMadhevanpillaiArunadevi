using System;
using System.Diagnostics;

namespace MisalignedSpace {
    public partial class Misaligned {
        static string printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            string result = "";
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    if(number == (i * 5 + j))
                    {
                        result = String.Format("{0} | {1}", majorColors[i], minorColors[i]);
                    }
					
                    Console.WriteLine("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }
            return result;
        }
        static void Main(string[] args) {
           testTwentyFivePair_ColorManual();
        }
    }
}
