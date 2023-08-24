using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Yeni oyun eklendi: " + game.GameName);
        }

        public void Remove(Game game)
        {
            Console.WriteLine("Oyun kaldirildi: " + game.GameName);
        }
    }
}
