using SRCM.Core.DomainObjects;
using SRCM.Domain.Shared.Enums;

namespace SRCM.Domain.Entities
{
    public class Staff : Entity
    {
        public Staff(string name, string cpf, string carteiraTrabalho, string email, DateTime birthday, Positions position, Guid addressId)
        {
            Name = name;
            Cpf = cpf;
            CarteiraTrabalho = carteiraTrabalho;
            Email = email;

            Birthday = birthday;
            Position = position;
            AddressId = addressId;

        }

        protected Staff() { }

        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public string CarteiraTrabalho { get; private set; }
        public string Email { get; private set; }
        public Guid AddressId { get; private set; }
        public DateTime Birthday { get; private set; }
        public Positions Position { get; private set; }

        public Address Address { get; private set; }
    }
}
