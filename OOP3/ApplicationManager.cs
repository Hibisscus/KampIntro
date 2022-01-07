using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
     class ApplicationManager
    {
        //Method injection.
        public void MakeApplication(ICrediManager crediManager, List<ILoggerService> loggerServices) 
        {
            crediManager.Calculate();
            foreach (var logerservice in loggerServices)
            {
                logerservice.Log();
            }
        }

        //birden fazla credi hesabı yapmak için list kullanılır
        public void DoPreİnformation(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
