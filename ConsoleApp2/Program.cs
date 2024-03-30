﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Ticket ticket = new Ticket();
            {
               PassengerName = "John Smith",
               SeatNumber = 1;
            };

            Route route = new Route("ABC123", "CityA", "CityB", 3);

            // Продажа билета, передавая объект типа Ticket
            route.SellTicket(ticket);
            //Вывод описания маршрута
            string routeDescription = route.GetDescription();
            Console.WriteLine(routeDescription);
            //определение номера дня недели
            Console.WriteLine((int)DateTime.Today.DayOfWeek);




            // Создание объекта Airplane
            Airplane airplane = new Airplane("Boeing 747", 2005, 12345, new DateTime(2023, 5, 12), 300);

            // получение и вывод описания объекта
            string description = airplane.GetDescription();
            Console.WriteLine( description );


            

            //todo: создать маршрут (Route), самолет из 3х мест
            //продать 2 билета с нормальными условиями 
            //вывести описание маршрута (в GetDescription должно показать проданные места)
            //попробовать "продать" еще один билет на место, которое уже занято - ничего не должно измениться
            //попробовать "продать" еще один билет на день недели, в который рейс не летает - ничего не должно измениться
            //вывести описание маршрута (в GetDescription должно показать те же места)
            //продаем еще 2 билета (по факту продаться должен 1, т.к. места всего 3)
            //вывести описание маршрута (в GetDescription должно показать те же места)


        }
    }


}
