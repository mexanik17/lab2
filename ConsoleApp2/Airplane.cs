using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2


{
  //todo: написать GetDescription, в нем сформировать описание объекта, со всеми его полями
 //todo: добавить кол-во мест

    internal class Airplane
    {
        public string Model { get; private set; }
        public int Year { get; private set; }
        public int SerialNumber { get; private set; }
        public DateTime ManufactureDate { get; private set; }
 
        public int Capacity { get; private set; } // вместимость самолета

        // Конструктор с пятью параметрами
        public Airplane(string model, int year, int serialNumber, DateTime manufactureDate, int capacity)
        {
            Model = model;
            Year = year;
            SerialNumber = serialNumber;
            ManufactureDate = manufactureDate;
            Capacity = capacity;
        }



        //Конструктор с параметром для установки вместимости самолета

        public Airplane(int capacity)
        {
            Capacity = capacity;
        }

        //Конструктор по умолчанию 
        public Airplane()
        {
            Capacity = 0;
        }

        // Метод для получения описания объекта

        public string GetDescription()
        {
            return $"Самолет вмещает {Capacity} пассажиров";
        }
    }
}
        //todo: написать GetDescription, в нем сформировать описание объекта, со всеми его полями
        //todo: добавить кол-во мест






//    string PlaneType { get; set; } // тип лайнера;
//    int YearOfissue;
//    int YearofAircraft; //бортовой номер, год выпуска;
//    DateTime TehnicalInspection; // дата последнего техосмотра;
//    int NumberofSeats; // кол-во мест
//    public Airplane(string planeType, int yearOfissue, int yearofAircraftNumber, DateTime technicalInspection, int numberOfSeats) 
//    { 
//        PlaneType = planeType;
//        YearOfissue = yearOfissue;
//        YearofAircraft = yearofAircraftNumber;
//        TehnicalInspection = technicalInspection;
//        NumberofSeats = numberOfSeats;

//    }
//    // Метод для получения описания объекта

//    public string GetDescription()
//     {
//    return $"Тип лайнера: {PlaneType}\n" +
//           $"Год выпуска: {YearOfissue}\n" +
//           $"Бортовой номер: {YearofAircraft}\n" +
//           $"Дата последнего техосмотра: {TehnicalInspection}\n" +
//           $"Количество мест: {NumberofSeats}";
//      }


