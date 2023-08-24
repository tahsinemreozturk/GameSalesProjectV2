using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine("Kullanıcı ekleme basarılı : " + gamer.FirstName + " " + gamer.LastName + " " + gamer.TcNo);
            }
            else
            {
                Console.WriteLine("Ne yazıkki gerçek kullanıcı değilsiniz.");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanici silindi: " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanici guncellendi: " + gamer.FirstName);
        }
    }
}
