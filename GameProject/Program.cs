using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManeger gamerManeger = new GamerManeger(new UserValidationManager());
            gamerManeger.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1998, 
                FirstName = "BARIŞ", 
                LastName = "TÜRKMEN", 
                IdentityNumber = 123456 
            });
            Console.WriteLine("Hello World!");
        }
    }
}
