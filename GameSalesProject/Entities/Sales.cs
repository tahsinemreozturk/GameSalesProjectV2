using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Entities
{
    public class Sales : IEntity
    {
        public int SalesId { get; set; }
        public int GamePrice { get; set; }
    }
}
