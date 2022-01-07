using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TransportCrediManager : ICrediManager

    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt Credi Hesabı Yapıldı");
        }

        public void DoSmtng()
        {
            throw new NotImplementedException();
        }
    }
}
