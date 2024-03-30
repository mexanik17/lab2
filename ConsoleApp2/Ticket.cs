using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Ticket
    {
        public string PassengerName { get; set; }
        public int SeatNumber { get; set; }

       
        //todo: для всех классов сделать объявления переменных с новых строк
        //todo: для всех классов добавить св-ва для доступа к переменным
        //todo: для всех классов привести в порядок именование: поля с маленькой буквы в camelCase, свойства, методы, классы с большой (PascalCase)
        //todo: для всех классов названия переменных и методов должны отражать суть
        //todo: дописать GetDescription, в нем сформировать описание объекта, со всеми его полями
        //todo: для всех классов реализовать проверки значений свойств с именем пассажира и кассира - записываться должны только непустые значения
        //todo: для всех классов проверки других свойств, где это применимо (допустим, неотрицательная цена билета)
        //todo: для всех классов добавить конструктор с параметрами и без (по умолчанию)

        private int places, clas; // Номер места и класса;
        private int  price, kassanumber; // Цена билета, номер кассы;
        public string passengerName, cashierName; // Имя, фамилия, отчество пассажира и кассира;
        public DateTime dateOfPurchase; // дата покупки билета
        public Route route; // Ссылка на маршрут
        //todo: добавить ссылку на Route + метод SetRoute (его вызывать в момент продажи билета из класса Route)

        public int Places
        {
            get { return  places; }
            set { places = value;  }
        }

        public int Class
        {
            get { return clas; }
            set { clas = value; }
        }
        public int Price
        {
            get { return price;}
            set { price = value; }
        }
        public int Kassanumber
        {
            get { return kassanumber; }
            set { kassanumber = value; }
        }
        public string CashierName
        {
            get { return cashierName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    cashierName = value;
            }
        }

        public DateTime DateOfPurchase
        {
            get { return dateOfPurchase; }
            set { dateOfPurchase = value; }
        }
        public Ticket(int places, int clas, int price,int kassaNumber, string passengerName, string cashierName, DateTime dateOfPurchase,  int seatNumber)
        {
            Places = places;
            Class = clas;
            Price = price;
            Kassanumber = kassaNumber;
            PassengerName = passengerName;
            SeatNumber = seatNumber;
            DateOfPurchase = dateOfPurchase;
        }

        //Конструктор по умолчанию
        public Ticket() { }

        public Ticket(string passengerName, int seatNumber)
        {
            this.passengerName = passengerName;
            SeatNumber = seatNumber;
        }

        //Метод для получения описания билета
        public string GetDescription()
        {
            return $"Билет на место{Places} класса {Class}, цена: {Price} руб., продан{DateOfPurchase}, пассажир: {PassengerName}";
        }
       
        // Метод для установки маршрута
        public void SetRoute(Route route) 
        {
            this.route = route ;
        }
    }
}
