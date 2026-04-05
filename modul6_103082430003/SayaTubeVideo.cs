using System;
using System.Collections.Generic;
using System.Text;

namespace modul6_103082430003
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public int GetPlayCount()
        {
            return playCount;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.playCount = 0;

            Random random = new Random();
            int ganerateId = random.Next(00000, 99999);
            this.id = ganerateId;
        }

        public void IncreasePlayCount(int plusCount)
        {
            this.playCount += plusCount;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Id Film : {id}");
            Console.WriteLine($"Judul : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }
    }
}
