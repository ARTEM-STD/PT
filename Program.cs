using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            void Poipo()
        {
            int a, b;
            a = 1;
            b = 40;
            int c = a + b;
            Console.WriteLine("a+b="+c);

        }
            Poipo();


            void Poip()
            {
                int a, b;
                a = 15;
                b = 5;
                a += b;
                b = a - b;
                a -= b;
                Console.WriteLine("a="+a+"b="+b);

            }
            Poip();

            People people = new People()
            {
                NamePeople = "Дмитрий",
                Sotseti = "пароль"
            };
            Console.WriteLine("Введи логин");
            string Seti = Console.ReadLine();

            people.Vhod(Seti,"");
            Console.ReadLine();
            
        }

        
        
        
        
    }
    class People
    {
       public string NamePeople;
       public string Sotseti;
        
        public void Vhod(string Name, string Seti) 
        {
            if (Name == NamePeople) 
            { 
                Console.WriteLine("Вы вошли в аккаунт");
            }
            else
            {
                Console.WriteLine("Вы не вошли");
            }
        }
    }
    





    //Метод

    
}
