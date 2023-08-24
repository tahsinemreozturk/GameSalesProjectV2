using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal GamePrice { get; set; }
    }
}
