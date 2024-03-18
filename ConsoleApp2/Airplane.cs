using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Airplane
    {
        //todo: написать GetDescription, в нем сформировать описание объекта, со всеми его полями
        //todo: добавить кол-во мест
        string PlaneType { get; set; } // тип лайнера;
        int YearOfissue;
        int YearofAircraft; //бортовой номер, год выпуска;
        DateTime TehnicalInspection; // дата последнего техосмотра;
        int NumberofSeats; // кол-во мест
        public Airplane(string planeType, int yearOfissue, int yearofAircraftNumber, DateTime technicalInspection, int numberOfSeats) 
        { 
            PlaneType = planeType;
            YearOfissue = yearOfissue;
            YearofAircraft = yearofAircraftNumber;
            TehnicalInspection = technicalInspection;
            NumberofSeats = numberOfSeats;

        }
        // Метод для получения описания объекта
        public string GetDescription()
         {
        return $"Тип лайнера: {PlaneType}\n" +
               $"Год выпуска: {YearOfissue}\n" +
               $"Бортовой номер: {YearofAircraft}\n" +
               $"Дата последнего техосмотра: {TehnicalInspection}\n" +
               $"Количество мест: {NumberofSeats}";
          }

    }
    
    // Метод для получения описания объекта
    
}
