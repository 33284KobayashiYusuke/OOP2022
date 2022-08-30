﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace Exercise1 {
    class ReplacedProcessor : TextProcessor{
              
        protected override void Execute(string line) {
           string s = Regex.Replace(line,"[０-９]",p => ((char)(p.Value[0]-'０'+'0')).ToString());
            Console.WriteLine(s);
        }
       
    }
}
