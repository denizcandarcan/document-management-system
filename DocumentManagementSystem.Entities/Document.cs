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
        public string TypeOfDoc { get; set; }
        public string ClassOfDoc { get; set; }
        public DocState DocState { get; set; }
        public DocStatus DocStatus { get; set; }
        public int? ReplyDocId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ReceiveDate { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public string ShelfNumber { get; set; } = string.Empty;
        public bool isBorrowed { get; set; } = false;
        public string BorrowerName { get; set; } = string.Empty;
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
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
