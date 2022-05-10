using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            //2-1-3
          
            /*  List<Song> songs = new List<Song>();
                 var song1 = new Song("lastscore", "xx", 416);
                 var song2 = new Song("rei", "xxx", 416);
                 var song3 = new Song("stera", "xxxx", 416);
                 songs.Add(song1);
                 songs.Add(song2);
                 songs.Add(song3);
                 PrintSongs(songs);
              */

            var songs = new Song[] {
                    new Song("lastscore", "xx", 212),
                    new Song("rei", "xxx", 416),
                    new Song("stera", "xxxx", 400),
            };
            PrintSongs(songs);
        }
        //2-1-4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                var span = new TimeSpan(0, 0, song.Length);
                Console.WriteLine("{0},{1},{2:m\\:ss}", 
                    song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));

            }
        }



        private static void PrintSong(List<Song> songs) {
            Console.WriteLine(songs);
        }
    }
}
