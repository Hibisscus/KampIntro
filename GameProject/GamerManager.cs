﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; 

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService; 
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
                 
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncelleindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
