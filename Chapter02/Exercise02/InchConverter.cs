using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {

   public static class InchConverter {
        private const double retio = 0.0254; 
      
        // インチからメートルを求める(静的メソッド)
        public static double ToMeter(double inch) {
            return inch * retio;
        }


    }
}
