using System;
using System.Collections.Generic;
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
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine($"User : {username}");

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
            }
        }
    }
}
