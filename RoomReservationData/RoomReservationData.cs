using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomReservationData;

namespace Wrox.ProCsharp.WCF
{
    public class RoomReservationData
    {
        public void ReserveRoom(RoomReservations roomReservations)
        {
            using (var data = new RoomReservationsEntities())
            {
                data.RoomReservations.Add(roomReservations);
                data.SaveChanges();
            }           

        }
        public RoomReservations[] GetRoomReservations(DateTime fromDate,DateTime toDate)
        {
            using (var data=new RoomReservationsEntities())
            {
                return (from r in data.RoomReservations 
                        where r.StartDate>fromDate && r.EndDate<toDate select r).ToArray();
            }
        }
    }
}
