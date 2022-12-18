using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Entities
{
    public class AppUserDocument : BaseEntity
    {
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }
        public RoleOfUser RoleOfUser { get; set; }
    }

    public enum RoleOfUser
    {
        Creator,
        Sender,
        Receiver
    }
}
