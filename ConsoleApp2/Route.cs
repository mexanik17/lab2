using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //todo: добавить булевый массив из 7 элементов - расписание вылетов (один элемент - один день недели)
    //добавить метод продажи билета на рейс: добавить список проданных билетов,
    //в методе реализовать проверку - если пытаемся продать билет на день, в которы рейс не летает, ничего не происходит,
    //+добавляем проверку на то, что эти места уже не проданы
    //+добавить проверку, что номер места меньше, чем вместимость лайнера (не можем продать билет на 200 место для самолета с вместимость 10 пассажиров)
    //иначе добавляет в список

    //todo: написать GetDescription, в нем сформировать описание объекта, со всеми его полями
    //todo: написать метод GetTotalPrice, который выведет сумму всех проданных билетов

    internal class Route
    {
        // Создаем булевый массив для расписания вылетов, где каждый элемент представляет день недели
        bool[] flightSchedule = new bool[7];
        private List<Ticket> soldTickets = new List<Ticket>(); // Список проданных билетов
        private HashSet <int> soldSeats = new HashSet<int>(); // Места которые уже проданы
        private int airplaneCapacity; // вместимость самолета
        public string RouteCode { get; set; } // шифр маршрута
        public string StartingPoint { get; set; } // начальный пункт,
        public string LastingPoint { get; set; } // конечный пункт;
        public Airplane Airplane { get; set; } // Ссылка на Авиалайнер
                                               
        // Конструктор класса Route
        public Route(string routeCode, string startingPoint, string lastingPoint, int capacity)
        {
            RouteCode = routeCode;
            StartingPoint = startingPoint;
            LastingPoint = lastingPoint;
            airplaneCapacity = capacity;
            

            // Присваиваем значения по умолчанию (например, все дни недели выключены)
            for (int i = 0; i < flightSchedule.Length; i++)
            {
                flightSchedule[i] = false;
            }
        }
        // Метод для продажи билета на рейс
        public void SellTicket(string passengerName, int dayOfWeek, int seatNumber)
        {
            if (dayOfWeek < 0 || dayOfWeek >= flightSchedule.Length)

            {
                Console.WriteLine($"Ошибка: Некорректный день недели. ");
                return;

            }

            if (!flightSchedule[dayOfWeek])
            {
                Console.WriteLine($"Ошибка: Рейс на день {dayOfWeek} не осуществляется.");
                return;
            }
            if (seatNumber < 1 || seatNumber > airplaneCapacity)
            {
                Console.WriteLine($"Ошибка: Неккоректный номер места. Номер места должен быть в диапозоне от 1 до  {airplaneCapacity}.");
                return;
            }
            if (soldSeats.Contains(seatNumber))
            {
                Console.WriteLine($"Ошибка: место {seatNumber} уже продано.");
                return;
            }
            Ticket ticket = new Ticket(passengerName, seatNumber);
            soldTickets.Add(ticket);
            soldSeats.Add(seatNumber);
            Console.WriteLine($"Билет на рейс {RouteCode}");
        }

    }
}
