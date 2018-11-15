using System;
using System.Collections.Generic;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRepository repo = ReservationRepository.Current;

        public IEnumerable<Reservation> GetAll()
        {
            return this.repo.GetAll();
        }

        public Reservation GetReservation(Int32 id)
        {
            return repo.Get(id);
        }

        public Reservation PostReservation(Reservation item)
        {
            return this.repo.Add(item);
        }

        public Boolean PutReservation(Reservation item)
        {
            return this.repo.Update(item);
        }

        public void DeleteReservation(Int32 id)
        {
            this.repo.Remove(id);
        }
    }
}