using System;  //Metodlar bizim için tekrar tekrar kullanılabilirliği sağlayan bir ortam sunar.


namespace Mathematic
{
    class Program
    {

        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();

            dortIslem.Topla(5,6);

            dortIslem.Topla(55, 8);


        }
    }
}