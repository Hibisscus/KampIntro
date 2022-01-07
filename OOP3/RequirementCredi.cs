using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class RequirementCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç Credi Hesabı Yapıldı");
        }

        public void DoSmtng()
        {
            throw new NotImplementedException();
        }
    }
}
