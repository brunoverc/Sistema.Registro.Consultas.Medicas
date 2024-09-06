using SRCM.Core.DomainObjects;
using SRCM.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Entities
{
    public class AppointmentScheduling : Entity
    {
        public AppointmentScheduling(DateTime date, Guid idAppointment, AppointmentStatus status)
        {
            Date = date;
            IdAppointment = idAppointment;
            Status = status;
        }
        protected AppointmentScheduling() { }
        
        public DateTime Date { get; private set; }
        public Guid IdAppointment { get; private set; }
        public AppointmentStatus Status { get; private set; }

        public Appointment Appointment { get; private set; }
    }
}