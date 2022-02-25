using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_RPG
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите имя: ");
                string playerName = Console.ReadLine();
                Random r = new Random();
                for (int km = r.Next(1, 10) + 1; km <= r.Next(10, 10) + 1; km++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        while (true)
                        {
                           
                                Console.WriteLine("--(1 - идти, 2 - говорить, 3 - покушать, 4 - отдохнуть, 5 - пойти домой)--");
                                Console.Write("Выберите действие: ");
                                int numOfAction = int.Parse(Console.ReadLine());
                                if (numOfAction == 1)
                                {
                                    Console.WriteLine($"{playerName} Он пошел в домик на дереве");
                                    Console.WriteLine($"{playerName} Он прошел {km} км");
                                    int hours = r.Next(1, 6);
                                    Console.WriteLine($"{playerName} Он шел {hours} часов");
                                }
                                else if (numOfAction == 2)
                                {
                                    int hours = r.Next(1, 6);
                                    Console.WriteLine($"{playerName} Он разговаривал с подругой");
                                    Console.WriteLine($"{playerName} Он говорил с подругой {hours} часов");
                                }
                                else if (numOfAction == 3)
                                {
                                    int hours = r.Next(1, 6);
                                    Console.WriteLine($"{playerName} Он пошел поесть с подругой");
                                    Console.WriteLine($"{playerName} Он кушал с подругой {hours} часов");
                                }
                                else if (numOfAction == 4)
                                {
                                    Console.WriteLine($"{playerName} Он пошел полежать с подругой");
                                    int hours = r.Next(1, 6);
                                    Console.WriteLine($"{playerName} Он спал с подругой {hours} часов");
                                }
                                else if (numOfAction == 5)
                                {
                                    Console.WriteLine($"{playerName} Он пошел к себе домой");
                                    Console.WriteLine($"{playerName} Он прошел {km} км");
                                    int hours = r.Next(1, 6);
                                    Console.WriteLine($"{playerName} Он шел обратно к себе домой {hours} часов");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{playerName} Он не умеет выполнять эту задачу");
                                }
                        } 
                    }
                    Console.WriteLine("Для продолжения нажмите Enter, а для выхода нажмите 0: ");
                    if (Console.ReadLine() == "0")
                    {
                        break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
