using SRCM.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRCM.Domain.Entities
{
    public class Patient : Entity
    {
        public Patient(string name, 
            DateTime birthday,
            string cpf,
            string email,
            Guid addressId)
        {
            Name = name;
            Birthday = birthday;
            CPF = cpf;
            Email = email;
            AddressId = addressId;
        }

        protected Patient() { }


        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public Guid AddressId { get; private set; }

        public Address Address { get; private set; }
    }
}
