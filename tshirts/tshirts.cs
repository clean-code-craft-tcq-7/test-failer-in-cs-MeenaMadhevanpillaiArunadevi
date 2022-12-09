using System;
using System.Diagnostics;

namespace TshirtSpace {
    public partial class Tshirt {
        static string Size(int cms) {
            if(cms <= 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
           test_GetTshirt_size();
                
        }
    }
}
