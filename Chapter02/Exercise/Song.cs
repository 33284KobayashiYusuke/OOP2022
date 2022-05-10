using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {
      //プロパティ
      　public  String Title { get; set; } //歌のタイトル
        public  String ArtistName { get; set; } //アーティスト名
        public int Length { get; set; }//演奏時間　単位は秒

        //引数付きコンストラクタ
        public Song(string title,string artistname, int length) {
            this.Title = title;
            this.ArtistName = artistname;
            this.Length = length;
        }
      


    }
}
