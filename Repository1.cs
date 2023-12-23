using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworkers_1._0
{
    class Repository1
    {
        private Woreker[] workers;

        public Woreker this[int index]
        {
            get { return workers[index]; }
            set { workers[index] = value; }
        }

        private string path;

        int index;
        string[] titles;

        public Repository1(string Path)
        {
            this.path = Path;
            this.index = 0;
            this.titles = new string[5];
            this.workers = new Woreker[2];
        }

        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.workers, this.workers.Length * 2);
            }
        }
        /// <summary>
        /// Добавление работника вручную.
        /// </summary>
        /// <param name="ConcreteWorker"></param>
        public void Add(Woreker ConcreteWorker)
        {
            this.Resize(index >= this.workers.Length);
            this.workers[index] = ConcreteWorker;
            this.index++;
        }
        /// <summary>
        /// Загрузка таблицы данных.
        /// </summary>
        public void Load()
        {
            using (StreamReader dataBaseRead = new StreamReader("Database.csv", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"{"Номер сотрудника",15}{"Время",8} {"Ф.И.О. сотрудника"}");

                while ((line = dataBaseRead.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0],15} {data[1],8} {data[2]}");
                }
            }
        }
        /// <summary>
        /// Печать в консоль
        /// </summary>
        public void PrintDbToConsole()
        {
            Console.WriteLine($"{this.titles[0],15} {this.titles[1],15} {this.titles[2],15} {this.titles[3],15} {this.titles[4],15} {this.titles[5]}");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(this.workers[i].Print());
            }
        }

        public int Count { get { return this.index; } }

        public Woreker[] GetAllWorkers()
        {
            Load();
            PrintDbToConsole();
        }

        public Woreker GetWorkerByID()
        {
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(workers[id]);
        }

        public void DeleteWorker(int id)
        {
            workers[id] = new Woreker ;  //не понимаю, как удалить
        }

        public void AddWorker(Woreker worker)
        {
            Add(worker); //не понимаю, что еще добавить
        }
        public Woreker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            workers.OrderBy(workers => workers.AddTime) //попытка в сортировку с последующим выводом, но я не понимаю, чт оу нас по итону по
        }

    }

}
}
