using SRCM.Core.DomainObjects;
using SRCM.Domain.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Entities
{
    public class Appointment : Entity
    {
        public Appointment (Guid idDoctor, Guid idPatient, AppointmentType type, string observation) {
            IdDoctor = idDoctor;
            IdPatient = idPatient;
            Type = type;
            Observation = observation;
        }
        
        protected Appointment() { }

        public Guid IdDoctor { get; private set; }
        public Guid IdPatient { get; private set; }
        public AppointmentType Type { get; private set; }
        public string Observation { get; private set; }

        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
    }
}
