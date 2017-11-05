using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwT5
{
    //Евдохин Д.

    // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    // б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    // МЕЖДУНАРОДНАЯ КЛАССИФИКАЦИЯ ДЕФИЦИТА МАССЫ ТЕЛА И ОЖИРЕНИЯ
    //ДЕФИЦИТ МАССЫ<18,50
    //Выраженный дефицит массы	<16,00
    //Недостаточная масса тела	16,00 - 18,49
    //НОРМА	18,50 - 24,99
    //Избыточный вес	>25,00
    //Предожирение    25,00 - 29,99
    //ОЖИРЕНИЕ    >30,00
    //Ожирение первой степени 30,00 - 34,99
    //Ожирение второй степени 35,00 - 39,99
    //Ожирение третьей степени    >40,00
    //ТАБЛИЦА ИНДЕКСА МАССЫ ТЕЛА ПО ВОЗРАСТНЫМ ГРУППАМ
    //ВОЗРАСТНЫЕ ГРУППЫ ПРИЕМЛЕМЫЙ ИМТ
    //19 - 24	19 - 24
    //25 - 34	20 - 25
    //35 - 44	21 - 26
    //45 - 54	22 - 27
    //55 - 64	23 - 28
    //старше 65	24 - 29
    class Program
    {
        static void ChangeWeight(double height, double weight)
        {
            double weightStart = weight;
            double index = weight / Math.Pow(height, 2);
            int res;
            if (index > 24.99)
            {
                while (index > 24.99)
                {
                    weight -= 0.01;
                    index = weight / Math.Pow(height, 2);
                }
                res = Convert.ToInt32(weightStart - weight);
                Console.WriteLine($"Вам необходимо похудеть как минимум на {res}кг в соответствии с международным стандартом");
            }
            else if (index < 18.50)
            {
                while (index < 18.50)
                {
                    weight += 0.01;
                    index = weight / Math.Pow(height, 2);
                }
                res = Convert.ToInt32(weight - weightStart);
                Console.WriteLine($"Вам необходимо набрать как минимум {res}кг в соответствии с международным стандартом");
            }
            else
            {
                Console.WriteLine("Вы в норме =)");
            }
        }

        static string Question(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n {0}", text);
            Console.ResetColor();
            string answer = Console.ReadLine();
            return answer;
        }

        static void Main(string[] args)
        {
            string[] questions = new string[]
            {
                "Рост в см: ",
                "Вес в кг: "
                //"Полных лет: "
            };

            string[] answers = new string[questions.Length];

            Console.WriteLine("\n\tПожалуйста заполните анкету чтобы узнать свой ИМТ.");
            for (int i = 0; i < 2; i++)
            {
                answers[i] = Question(questions[i]);
            }

            double height = double.Parse(answers[0]) / 100;
            double mass = double.Parse(answers[1]);
            double index = mass / Math.Pow(height, 2);

            Console.WriteLine(string.Format("\n Твой ИМТ {0:N2}", index));

            ChangeWeight(height, mass);

            Console.ReadKey();
        }
    }
}
