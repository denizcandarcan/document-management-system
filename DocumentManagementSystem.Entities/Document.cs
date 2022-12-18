using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Entities
{
    public class Document :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeDocId { get; set; }
        public TypeOfDoc TypeOfDoc { get; set; }
        public int ClassOfDocId { get; set; }
        public ClassOfDoc ClassOfDoc { get; set; }
        public DocState DocState { get; set; }
        public DocStatus DocStatus { get; set; }
        public int? ReplyDocId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ReceiveDate { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public List<AppUserDocument> AppUserDocuments { get; set; }
    }

    public enum DocState
    {
        Physical,
        Electronic
    }
    public enum DocStatus
    {
        Sent,
        Delivered
    }
}
