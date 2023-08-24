using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Abstract
{
    public interface ICampaginService
    {
        void Add(Campagin campagin);
        void Delete(Campagin campagin);
        void Update(Campagin campagin);
    }
}
