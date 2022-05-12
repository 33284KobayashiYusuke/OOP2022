using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            PrintInchToMeterList(1, 10);
        }
        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            //FeetConverter fc = new FeetConverter();
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
            }
        }
   }
}
