using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace modul6_103082430003
{
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            //prekondisi
            Debug.Assert(username != null, "Username tidak boleh null!");
            Debug.Assert(username.Length <= 100, "Username maksimal 100 karakter!");

            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();

            Random random = new Random();
            int generateId = random.Next(00000, 99999);
            this.id = generateId;
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var i in uploadedVideos)
            {
                total += i.GetPlayCount();
            }
            return total;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            Debug.Assert(video!=null,"Video yang ditambahkan tidak bisa null");
            Debug.Assert(video.GetPlayCount()<int.MaxValue,"playCount harus kurang dari nilai maksismum integer");
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User : {username}");

            //post kondisi
            int limit = Math.Min(uploadedVideos.Count,8);

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
