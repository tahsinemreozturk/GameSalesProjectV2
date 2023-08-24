using GameSalesProject.Adapters;
using GameSalesProject.Concrete;
using GameSalesProject.Entities;

internal class Program
{
    static void Main(string[] args)
    {
        Gamer gamer1 = new Gamer() { FirstName = "TAHSİN EMRE", LastName = "ÖZTÜRK", 
            BirthdayYear = new DateTime(2002, 06, 21), TcNo = "32" };
        Gamer gamer2 = new Gamer()
        {
            FirstName = "Hakan",
            LastName = "Aydin",
            BirthdayYear = new DateTime(2000, 09, 21),
            TcNo = "31321564"
        };

        GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
        gamerManager.Add(gamer1);
        gamerManager.Add(gamer2);
        Console.WriteLine("\n");
        gamerManager.Delete(gamer1);
        gamerManager.Update(gamer2);

        Console.WriteLine("\n");

        Game game1 = new Game() { Id = 1, GameName = "CounterStrike", GamePrice = 144 };
        GameManager gameManager = new GameManager();
        gameManager.Add(game1);
        gameManager.Remove(game1);
        Console.WriteLine("\n");


        Campagin campagin1 = new Campagin() {CampaginId = 1, CampaginName ="Fps oyunlarinda %10 indirim firsati!!!! "};
        CampaginManager campaginManager = new CampaginManager();
        campaginManager.Add (campagin1);
        campaginManager.Delete(campagin1);
        campaginManager.Update(campagin1);
        Console.WriteLine("\n");

        Sales sales1 = new Sales() { SalesId = 1, GamePrice = 149 };
        SalesManager salesManager = new SalesManager();
        salesManager.Sale(sales1, gamer2, game1, campagin1);





















        Console.ReadLine();

    }
}