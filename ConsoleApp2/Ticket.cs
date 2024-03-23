using System;
using System.Collections.Generic;
using System.Linq;
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

        int Places, Clas; // Номер места и класса;
        int PriceTck, numberKassa; // Цена билета, номер кассы;
        string FIOPASS, FIOKASS; // Имя, фамилия, отчество пассажира и кассира;
        DateTime DateBuy; // дата покупки билета

        //todo: добавить ссылку на Route + метод SetRoute (его вызывать в момент продажи билета из класса Route)


 


        public string GetDescription()
        {
            string tmp = "Билет такой то, продан " + PassengerName + "  ";
            return tmp;
        }
       
    }
}
