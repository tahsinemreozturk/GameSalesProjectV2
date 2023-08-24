using GameSalesProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Entities
{
    public class Campagin : IEntity
    {
        public int CampaginId { get; set; }
        public string CampaginName { get; set; }
    }
}
