using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSalesProject.Abstract;

namespace GameSalesProject.Entities
{
    public class Gamer : IEntity
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthdayYear { get; set; }

    }
}
