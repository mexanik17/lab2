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

        public string RouteCode { get; set; } // шифр маршрута
        public string StartingPoint { get; set; } // начальный пункт,
        public string LastingPoint { get; set; } // конечный пункт;
        public Airplane Airplane { get; set; } // Ссылка на Авиалайнер
                                               
        // Конструктор класса Route
        public Route(string routeCode, string startingPoint, string lastingPoint)
        {
            RouteCode = routeCode;
            StartingPoint = startingPoint;
            LastingPoint = lastingPoint;

            // Присваиваем значения по умолчанию (например, все дни недели выключены)
            for (int i = 0; i < flightSchedule.Length; i++)
            {
                flightSchedule[i] = false;
            }
        }
        // Метод для продажи билета на рейс
        public void SellTicket(Ticket ticket)
        {
            soldTickets.Add(ticket);
            Console.WriteLine($"Билет на рейс {RouteCode} продан: {ticket.PassengerName}");
        }
    }
}
