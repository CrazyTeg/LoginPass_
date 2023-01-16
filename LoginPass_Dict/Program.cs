using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPass_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();

            users.Add("Iv", "Иван Петров");
            users.Add("Vova", "Владимир Акст");
            users.Add("Slava", "Вячеслав Батурин");
            users.Add("Natt", "Наталья Иванова");

            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            if (!users.TryGetValue(login, out _))
            {
                Console.WriteLine("Учетная запись не найдена! Пожалйста зарегестрируйтесь.");
                Console.WriteLine("Введите Логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите ваше имя и фамилию:");
                string name = Console.ReadLine();
                users.Add(login, name);                
                Console.WriteLine("Поздравляем {0}, вы зарегистрированы!", users[login]);
            }
            else
            {
                Console.WriteLine("Здравствуйте {0}", users[login]);
            }
            Console.WriteLine("Для просмотра всех имен пользователей введите: name");            
            var command = Console.ReadLine();
            if (command == "name")
            {
                foreach(var value in users.Values)
                {
                    Console.WriteLine(value);
                }
            }
            else
            {
                Console.WriteLine(">>> Вы ввели некорректное значение. <<<");               
            }
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
