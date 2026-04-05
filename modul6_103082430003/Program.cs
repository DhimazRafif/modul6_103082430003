using modul6_103082430003;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Normal Condition");
        try
        {
            SayaTubeUser user = new SayaTubeUser("Dhimaz Rafif Hanafi");

            SayaTubeVideo film11 = new SayaTubeVideo("Review Film Maquia oleh Dhimaz Rafif Hanafi");
            film11.IncreasePlayCount(1000);

            user.AddVideo(film11);
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"Gagal : {ex.Message}");
        }

        Console.WriteLine("\n Testing Overflow");
        SayaTubeVideo test = new SayaTubeVideo("Review Film Minion oleh Dhimaz Rafif Hanafi");
        try
        {
            for(int i = 0; i < 90; i++)
            {
                test.IncreasePlayCount(25000000);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Caught Exception: {ex.Message}");
        }
        test.PrintVideoDetails();

        Console.WriteLine("Testing post condition print 8 video");
        SayaTubeUser testUser = new SayaTubeUser("Dhimaz Sutrisno");

        for(int i = 1;i <= 10; i++)
        {
            testUser.AddVideo(new SayaTubeVideo($"Review Film part{i}"));
        }

        testUser.PrintAllVideoPlayCount();

        Console.WriteLine($"\nTest precondition nama video null");
        SayaTubeVideo videoSalah = new SayaTubeVideo(null);
    }
}
