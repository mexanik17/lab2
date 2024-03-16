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
    }
}
