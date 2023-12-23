using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworkers_1._0
{
    struct Woreker
    {
        private int ID { get; set; } // номер по списку
        private string AddTime { set => AddTime = DateTime.Now.ToString; }
        public string FIO { get; set; } // ФИО
        public int Age { get; set; } // возраст
        public int Height { get; set; } // рост
        public DateTime BirthDay { get; set; } // дата рождения
        public string PoB { get; set; } // место рождения (place of birth)
        public string Print() // вывод данных о сотруднике
        {
            return $"Номер по порядку: {ID} " +
                $"\n Время добавления записи: {AddTime}" +
                $"\nФ.И.О.: {FIO} " +
                $"\nВозраст: {Age} " +
                $"\nРост: {Height} " +
                $"\nДата рождения: {BirthDay.ToShortDateString()}" +
                $"\nМесто рождения: {PoB}";
        }

    }
}
