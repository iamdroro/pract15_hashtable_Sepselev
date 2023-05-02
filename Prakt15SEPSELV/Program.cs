using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt15Algoritm4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int parametr = 0;
                Zvuk catalog = new Zvuk();
                while (parametr != 8)
                {
                    Console.WriteLine("Выберите пункт меню");
                    Console.WriteLine("1) Добавление диска");
                    Console.WriteLine("2) Добавление песни");
                    Console.WriteLine("3) Удаление диска");
                    Console.WriteLine("4) Удаление песни");
                    Console.WriteLine("5) Вывод содержания диска");
                    Console.WriteLine("6) Поиск по исполнителю");
                    Console.WriteLine("7) Показать каталог");
                    Console.WriteLine("8) Выход");

                    parametr = int.Parse(Console.ReadLine());
                    switch (parametr)
                    {
                        case 1:
                        {
                            Console.Write("Введите название диска: ");
                            string NameDisk = Console.ReadLine();
                            catalog.AddDisc(NameDisk);
                        }
                        break;
                            case 2:
                        {
                            Console.Write("Введите название диска в который хотите добавить песню: ");
                            string NameDisk = Console.ReadLine();
                            Console.Write("Введите исполнителя: ");
                            string Ispolnitel = Console.ReadLine();
                            Console.Write("Введите название песни: ");
                            string NameofMusic = Console.ReadLine();
                            catalog.AddSong(NameDisk, Ispolnitel, NameofMusic);
                        }
                            break;
                            case 3:
                        {
                            Console.Write("Введите названия диска чтобы удалить песню: ");
                            string deleateDisk = Console.ReadLine();
                            catalog.RemoveDisc(deleateDisk);
                        }
                            break;
                        case 4:
                        {
                            Console.Write("Введите названия диска чтобы удалить песню: ");
                            string NameDisk = Console.ReadLine();
                            Console.Write("Введите исполнителя: ");
                            string ispolnitel = Console.ReadLine();
                            Console.WriteLine("Введите название песни из диска: ");
                            string NameofMusic = Console.ReadLine();
                        }
                            break;
                        case 5:
                        {
                            Console.Write("Введите название диска чтобы просмотреть содержимое: ");
                            string findDisk = Console.ReadLine();
                            catalog.PrintDisc(findDisk);
                        }
                            break;
                        case 6:
                        {
                            Console.Write("Для поиска введите исполнителя: ");
                            string findInspolnitel = Console.ReadLine();
                            catalog.SearchByArtist(findInspolnitel);
                        }
                            break;
                        case 7:
                        {
                            catalog.PrintCatalog();
                        }
                            break;
                        case 8:
                        {
                            parametr = 8;
                        }
                            break;
                        default:
                        {
                            Console.WriteLine("Некорректный ввод номера пункта!");
                        }
                            break;
                    }
                    Console.WriteLine("\n\n");
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод данных!");
            }

        }
    }
}
