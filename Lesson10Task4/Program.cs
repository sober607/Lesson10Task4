using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson10Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в раздел регистрации \n Пожалуйста введите желаемый логин (символы должны быть латинские)");
            string inputLogin = Console.ReadLine();
            Regex loginRegex = new Regex("[A-Z]|[a-z]");
            //string inputLogin = Console.ReadLine();
            
            while (!loginRegex.IsMatch(@inputLogin))
            {
                Console.WriteLine("Пожалуйста введите снова логин, введенный формат не верный");
                inputLogin = Console.ReadLine();
            }
            Console.WriteLine("Теперь введите пароль");

            string inputPass = Console.ReadLine();
            Regex passRegex = new Regex(@"\w");

            while (!passRegex.IsMatch(@inputPass))
            {
                Console.WriteLine("Пожалуйста введите снова пароль, введенный формат не верный");
                inputLogin = Console.ReadLine();
            }

            Console.WriteLine("Большое спасибо");
            Console.ReadLine();
        }
    }
}
