using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class SalesManager : ISalesService
    {  
        public void Sale(Sales sales, Gamer gamer, Game game, Campagin campagin)
        {
            Console.WriteLine( gamer.FirstName + ": kullanicisina "  + game.GameName +" oyunu " +
                campagin.CampaginName + " kampanyasi dahilinde " +sales.GamePrice + " fiyatina Satilmistir.");
        }
    }
}
