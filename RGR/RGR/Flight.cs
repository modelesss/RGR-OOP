using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    
    public class Flight
    {
        //Властивості класу
        public string FlightNumber { get; set; }
        public string PlaneName { get; set; }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal TicketPrice { get; set; }

        //Перевантаження методу для виведення 
        public override string ToString()
        {
            return $"Рейс {FlightNumber}: з {DeparturePoint} до {DestinationPoint}, " +
                   $"відпр. {DepartureTime:dd.MM.yyyy HH:mm}, приб. {ArrivalTime:dd.MM.yyyy HH:mm}, " +
                   $"ціна: {TicketPrice}$";
        }
    }
}
