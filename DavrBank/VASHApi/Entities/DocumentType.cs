using System.Collections.Generic;
using VASHApi.Entities.Abstracts;

namespace VASHApi.Entities
{
    public class DocumentType : EntityBase
    {
        public string Name { get; set; }

        public ICollection<Client> Clients { get; set; }

    }
}
