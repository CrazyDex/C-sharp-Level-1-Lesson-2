using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT4
{
    //Евдохин Д.

    // Реализовать метод проверки логина и пароля.
    // На вход подается логин и пароль.
    // На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
    // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    // С помощью цикла do while ограничить ввод пароля тремя попытками.

    class Program
    {
        public static string ruser = "root";
        public static string rpassword = "GeekBrains";

        /// <summary>
        /// Real start
        /// </summary>
        static void Start()
        {
            Console.Clear();
            short tryes = 3;
            string trystr = "";
            //string ruser = "1", rpassword = "1"; // "правильные" юзер и пас
            Console.Write("You try enter to the Forbidden Directory...");

            do
            {
                #region Проверка юзера
                Console.WriteLine(trystr);
                Console.Write("Username: ");
                string user = Console.ReadLine();
                Console.Write("\nPassword: ");
                Console.ForegroundColor = ConsoleColor.Black;
                string password = Console.ReadLine();
                Console.Clear();
                Console.ResetColor();
                trystr = $"Failed enter. You have {--tryes} tryes";
                #endregion

                if (user == ruser && password == rpassword)
                {
                    Loading();
                    Console.WriteLine($"Hi \"{user}\"\n");
                    System.Threading.Thread.Sleep(1000);
                    Level1();
                }

                #region При проваленном входе
            } while (tryes != 0);
            if (tryes == 0)
            {
                while (true)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    System.Threading.Thread.Sleep(20);
                    Console.Write("WARNING!!!   ");
                }
            }
            #endregion
        }

        /// <summary>
        /// имитация загрузки
        /// </summary>
        static void Loading()
        {
            Console.WriteLine("Loading...");
            System.Threading.Thread.Sleep(1000);
            Random random = new Random();
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write('\x2588');
                System.Threading.Thread.Sleep(random.Next(5, 300));
            }
            Console.Clear();
        }

        /// <summary>
        /// 1. Terminate system
        /// </summary>
        static void TermSyst()
        {
            Random random = new Random();
            for (int i = 0; i < (Console.BufferHeight-6); i++)
            {
                System.Threading.Thread.Sleep(20);
                Console.MoveBufferArea(0, i, random.Next(0, Console.BufferWidth), 2, random.Next(6), random.Next(20));
            }
        }

        /// <summary>
        /// 2. Spam world
        /// </summary>
        static void SpW()
        {
            int i = 0;
            for (int k = 0; k < 25; k++)
            {
                Console.Clear();
                Console.WriteLine("| Start sending virus XdheH4.sa.45(0a) to everybody on the planet");
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("/ Start sending virus XdheH4.sa.45(0a) to everybody on the planet");
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("- Start sending virus XdheH4.sa.45(0a) to everybody on the planet");
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("\\ Start sending virus XdheH4.sa.45(0a) to everybody on the planet");
                System.Threading.Thread.Sleep(30);
            }
            Random random = new Random();
            while (random.Next(100) != 0)
            {
                i++;
                Console.Clear();
                Console.WriteLine("| Sent succesful {0}", i);
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("/ Sent succesful {0}", i);
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("- Sent succesful {0}", i);
                System.Threading.Thread.Sleep(30);
                Console.Clear();
                Console.WriteLine("\\ Sent succesful {0}", i);
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine("Something going wrong!\n\n1. For extrim terminate system\nAny another to return");
            if (Console.ReadLine() == "1") { TermSyst(); }
            else { Level1(); }
        }

        /// <summary>
        /// 3. Humor
        /// </summary>
        static void Hum()
        {
            Console.Clear();
            Console.WriteLine("If you're having a bad day, don't be sad. Be like an unsigned integer...");
            Console.ReadKey();
            Console.WriteLine("\n...Stay positive.");
            System.Threading.Thread.Sleep(5000);
            Console.Write("\nPress any key to return and start working!");
            Console.ReadKey();
            Level1();
        }

        /// <summary>
        /// 4. Profile
        /// </summary>
        static void Prof()
        {
            bool b = true;
            string s = "";
            Console.Clear();
            Console.WriteLine("1. Change username\n2. Return");
            while (b)
            {
                s = Console.ReadLine();
                b = (s == "1") || (s == "2") ? false : true;
            }
            if (s == "1")
            {
                Console.Clear();
                Console.Write("New username: ");
                ruser = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Username change succesful");
                Console.ReadLine();
                Prof();
            }
            else { Level1(); }
        }

        /// <summary>
        /// 5. Security
        /// </summary>
        static void Sec()
        {
            bool b = true;
            string s = "";
            Console.Clear();
            Console.WriteLine("1. Change password\n2. Return");
            while (b)
            {
                s = Console.ReadLine();
                b = (s == "1") || (s == "2") ? false : true;
            }
            if (s == "1")
            {
                Console.Clear();
                Console.Write("New password: ");
                Console.ForegroundColor = ConsoleColor.Black;
                rpassword = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Password change succesful");
                Console.ReadLine();
                Sec();
            }
            else { Level1(); }
        }

        /// <summary>
        /// 6. Exit
        /// </summary>
        static void Ex()
        {
            Start();
        }

        /// <summary>
        /// Main menu
        /// </summary>
        static void Level1()
        {
            Console.Clear();
            short switchBut = 0;
            Console.WriteLine("1. Terminate system\n2. Spam world\n3. Humor\n4. Profile\n5. Security\n6. Exit");
            short.TryParse(Console.ReadLine(), out switchBut);
            switch (switchBut)
            {
                case 1: TermSyst(); break;
                case 2: SpW(); break;
                case 3: Hum(); break;
                case 4: Prof(); break;
                case 5: Sec(); break;
                case 6: Ex(); break;
                default: Level1(); break;
            }
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}
