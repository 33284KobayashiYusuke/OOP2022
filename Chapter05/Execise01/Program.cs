using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            //5.1
            Console.Write("文字列１を入力：");
            var inputString1 = Console.ReadLine();

            Console.Write("文字列２を入力：");
            var inputString2 = Console.ReadLine();


            if (inputString1.ToUpper() == inputString2.ToUpper()) {
                Console.WriteLine("一致しています");
            } else {
                Console.WriteLine("一致していません");
            }
        }
    }
}
