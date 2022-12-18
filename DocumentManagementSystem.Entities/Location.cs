using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Entities
{
    public class Location: BaseEntity
    {
        public string RoomNumber { get; set; } = string.Empty;
        public string ShelfNumber { get; set; } = string.Empty;
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public bool isBorrowed { get; set; } = false;
        public int BorrowerId { get; set; }
        public AppUser Borrower { get; set; } = null;
    }
}
