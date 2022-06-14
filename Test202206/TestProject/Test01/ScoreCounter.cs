using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

        }


        //メソッドの概要： StudentScoreのデータを取り出し、点数を出力
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> score = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Student scores = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                score.Add(scores);
            }

            return score;

        }

        //メソッドの概要： 科目別の点数の取り出し
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new Dictionary<string, int>();
            foreach (var scores in _score) {
                if (dict.ContainsKey(scores.Subject))
                    dict[scores.Subject] += scores.Score;
                else
                    dict[scores.Subject] = scores.Score;
            }
            return dict;
        }


    }
    
}
