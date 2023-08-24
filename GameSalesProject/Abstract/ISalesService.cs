using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface ISalesService
    {
        void Sale(Sales sales, Gamer gamer, Game game, Campagin campagin);
        
    }
}
