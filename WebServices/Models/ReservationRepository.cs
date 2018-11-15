using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();

        public static ReservationRepository Current
        {
            get { return repo; }
        }

        private List<Reservation> data = new List<Reservation>() {
            new Reservation(){ ClientName = "Adam", Location="BoardRoom", ReservationId= 1 },
            new Reservation(){ ClientName = "Jacqui", Location="Lecture Hall", ReservationId= 2 },
            new Reservation(){ ClientName = "Russell", Location="Meeting Room 1", ReservationId= 3 },
        };

        public IEnumerable<Reservation> GetAll()
        {
            return this.data;
        }

        public Reservation Get(Int32 id)
        {
            return data.Where(item => item.ReservationId == id).FirstOrDefault();
        }

        public Reservation Add(Reservation item)
        {
            item.ReservationId = this.data.Count + 1;
            data.Add(item);
            return item;
        }

        public void Remove(Int32 id)
        {
            Reservation item = this.Get(id);
            if (item != null)
            {
                data.Remove(item);
            }
        }

        public Boolean Update(Reservation item)
        {
            Boolean result = false;
            Reservation temp = this.Get(item.ReservationId);
            if (temp != null)
            {
                temp.ClientName = item.ClientName;
                temp.Location = item.Location;
                result = true;
            }
            return result;
        }
    }

}