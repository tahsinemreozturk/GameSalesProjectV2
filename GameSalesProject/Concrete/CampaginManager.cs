using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSalesProject.Concrete
{
    public class CampaginManager : ICampaginService
    {
        public void Add(Campagin campagin)
        {
            Console.WriteLine("Yeni kampanya eklendi: " + campagin.CampaginName );
        }

        public void Delete(Campagin campagin)
        {
            Console.WriteLine("Kampanya kaldirildi: " + campagin.CampaginName);
        }

        public void Update(Campagin campagin)
        {
            Console.WriteLine("Kampanya guncellendi: " + campagin.CampaginName);
        }
    }
}
