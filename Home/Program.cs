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

            Console.Write("Введите имя: ");
            string playerName = Console.ReadLine();
            string type = "", bonus = "";
            int choise, hp = 100, dmg = 30, luck = 30;
            Random rnd = new Random();
            int ih = rnd.Next(1, 10);
            for (int i = 0; i < 10; i++)
            {

                while (type == "")
                {
                    Console.WriteLine("--(1 - маг огня, 2 -маг воды, 3 -маг земли)--");
                    Console.Write("Выберите тип персонажа: ");
                    choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            type = "маг огня";
                            break;
                        case 2:
                            type = "маг воды";
                            break;
                        case 3:
                            type = "маг земли";
                            break;
                        default:
                            Console.WriteLine("Такого типа не существует");
                            break;
                    }
                }
                Console.WriteLine($"Вы выбрали тип персонажа: {type}");


                while (bonus == "")
                {
                    Console.WriteLine("--(1 - больше маны, 2 - больше урона, 3 - больше защиты)--");
                    Console.Write("Выберите бонус персонажа: ");
                    choise = int.Parse(Console.ReadLine());

                    switch (choise)
                    {


                        case 1:
                            bonus = "больше маны";
                            i = 3;
                            break;
                        case 2:
                            bonus = "больше урона";
                            i = 6;
                            break;
                        case 3:
                            bonus = " больше защиты";
                            i = 10;
                            break;
                        default:
                            Console.WriteLine("Такого типа не существует");
                            break;

                    }
                    Console.WriteLine($"Вы выбрали бонус: {bonus}");
                }
            }
            Random r = new Random();
            for (int km = 1; km <= 7; km++)
            {
                for (int it = 0; it < 10; it++)
                {
                    Console.WriteLine("--(1 - замок, 2 - говорить, 3 - задание, 4 - троффей,5 - пойти спать)--");
                    Console.Write("Выберите действие: ");
                    int numOfAction = int.Parse(Console.ReadLine());
                    switch (numOfAction)
                    {
                        case 1:
                            Console.WriteLine($"{playerName} пошел на обучение в волшебный замок");
                            int hoursing = r.Next(1, 8);
                            Console.WriteLine($"{playerName} Пришел в замок за {hoursing} км");
                            it = 1;
                            break;
                        case 2:
                            Console.WriteLine($"{playerName} разговаривал с мудрецом волшебства");
                            it = 3;
                            break;
                        case 3:
                            int hours = r.Next(1, 8);
                            Console.WriteLine($"{playerName} пошел сразить монстра за {hours} часов");
                            it = 5;
                            break;
                        case 4:
                            Console.WriteLine($"{playerName} принес голову монстра мудрецу");
                            it = 7;
                            break;
                        case 5:
                            Console.WriteLine($"{playerName} Пошел в замок что бы поспать");
                            it = 10;
                            break;
                        default:
                            Console.WriteLine($"{playerName} Он не умеет выполнять эту задачу");
                            break;
                    }

                }
            
              Console.WriteLine($"{playerName} Он закончил свой {km} день");
              Console.WriteLine("Для продолжения нажмите Enter, а для выхода нажмите 0: ");
              if (Console.ReadLine() == "0")
              {
                break;
              }
              Console.ReadKey();
            }
        }           
    } 
} 

