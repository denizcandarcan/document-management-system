using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Entities
{
    public class TypeOfDoc:BaseEntity
    {
        public string Definition { get; set; }
        public List<Document> Documents { get; set; }

    }
}
