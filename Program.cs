using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworkers_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"data.csv";

            Repository1 workersRep = new Repository1(path);


            Console.WriteLine(
                "Приветствую. " +
                "\nСегодня я попытааюсь впарить Вам свою домашку. " +
                "\nСегодня у нас в меню:" +
                "\n1.Просмотр всех записей" +
                "\n2.Просмотр одной записи" +
                "\n3.Создание записи" +
                "\n4.Удаление записи" +
                "\n5.Загрузка записей в выбранном диапазоне дат" +
                "\n\nЧто выберете?");

            while (true)
            {
                string choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Вывожу все записи:");
                        workersRep.GetAllWorkers();
                        break;
                    case "2":
                        Console.WriteLine("Введите номер записи:");
                        int id = int.Parse(Console.ReadLine());
                        Woreker woreker = workersRep.GetWorkerByID(int id);
                        break;
                    case "3":
                        Console.WriteLine("Введите номер записи:");
                        int id = int.Parse(Console.ReadLine());
                        workersRep.DeleteWorker(int id);
                        break;
                    case "4":
                        Console.WriteLine("Начнем с номера записи:");
                        int id = int.Parse(Console.ReadLine());
                        workersRep.AddWorker();
                        break;
                    case "5":
                        Console.WriteLine("Введите первую дату:");
                        int dateFrom = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите вторую дату:");
                        int dateTo = int.Parse(Console.ReadLine());

                        workersRep.GetWorkersBetweenTwoDates();
                        break;
                    default:
                        Console.WriteLine("Я понимаю только цифры 1,2,3,4 и 5. На остальное не реагирую.");
                        break;
                }
            }
    }
}
