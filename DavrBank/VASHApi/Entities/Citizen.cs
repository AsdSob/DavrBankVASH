using System.Collections.Generic;
using VASHApi.Entities.Abstracts;

namespace VASHApi.Entities
{
    public class Citizen : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Client> Clients { get; set; }

    }
}
