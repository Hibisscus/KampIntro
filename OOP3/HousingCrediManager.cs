using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class HousingCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut Credi Hesabı Yapıldı");
        }

        public void DoSmtng()
        {
            throw new NotImplementedException();
        }
    }
}
