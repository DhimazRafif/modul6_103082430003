using modul6_103082430003;

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Dhimaz Rafif Hanafi");

        SayaTubeVideo film1 = new SayaTubeVideo("Review Film Maquia oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film2 = new SayaTubeVideo("Review Film Kimi No Nawa Dhimaz Rafif Hanafi");
        SayaTubeVideo film3 = new SayaTubeVideo("Review Film Pacific RIM oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film4 = new SayaTubeVideo("Review Film Guardian Of The Galaxy oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film5 = new SayaTubeVideo("Review Film Minion oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film6 = new SayaTubeVideo("Review Film Kungfu Panda oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film7 = new SayaTubeVideo("Review Film Spiderman In To The Spiderverse oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film8 = new SayaTubeVideo("Review Film Chainsaw Man Reze Arc oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film9 = new SayaTubeVideo("Review Film Superman oleh Dhimaz Rafif Hanafi");
        SayaTubeVideo film10 = new SayaTubeVideo("Review Film Despicable Me oleh Dhimaz Rafif Hanafi");


        user.AddVideo(film1);
        user.AddVideo(film2);
        user.AddVideo(film3);
        user.AddVideo(film4);
        user.AddVideo(film5);
        user.AddVideo(film6);
        user.AddVideo(film7);
        user.AddVideo(film8);
        user.AddVideo(film9);
        user.AddVideo(film10);

        film1.IncreasePlayCount(20);
        film1.PrintVideoDetails();

        user.GetTotalVideoPlayCount();
        user.PrintAllVideoPlayCount();
    }
}
