using DocumentManagementSystem.Dtos.Interfaces;
using DocumentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Dtos
{
    public class DocumentCreateDto : IDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeDocId { get; set; }
        public string TypeOfDoc { get; set; }
        public int ClassOfDocId { get; set; }
        public string ClassOfDoc { get; set; }
        public DocState DocState { get; set; }
        public DocStatus DocStatus { get; set; }
        public int? ReplyDocId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
    }
}
