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
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal panjang judul 100 karakter");

            }
            this.title = title;
            this.playCount = 0;

            Random random = new Random();
            int ganerateId = random.Next(00000, 99999);
            this.id = ganerateId;
        }

        public void IncreasePlayCount(int plusCount)
        {
            //prekondisi
            if (plusCount > 25000000 || plusCount<0)
                throw new ArgumentOutOfRangeException("Maksimal nominal penambahan adalah 25.000.000 dan nominal plusCount tidak boleh negatif.");
            

            try
            {
                checked
                {
                    this.playCount += plusCount;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error : error overflow penambahan melebihi batas integer atau negatif");
            }
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
