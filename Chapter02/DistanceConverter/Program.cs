using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            //フィートからメートルへの対応表を出力
            if (args.Length >= 1 && args[0] == "-tom") {
                PrintFeetToMeterList(1, 10);
            } else {
                //メートルからフィートへの対応表を出力
                PrintFeetToMeterList(1, 10);
                }

            }
            private static void PrintFeetToMeterList(int start,int stop) {
                for (int feet = 1; feet <= 10; feet++) {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine("{0} ft ={1:0.0000}m",meter,feet);
                }
            }
            private static void PrintFeetToMeterList(int start, int stop) {
                 for (int feet = 1; feet <= 10; feet++) {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} ft ={1:0.0000}m",feet,meter);
            }
        }
        //フィートからメートルを求める
        static double FeetMeter(int feet) {
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        double MeterToFeet(int meter) {
            return meter / 0.3048;


        }
    }
}
