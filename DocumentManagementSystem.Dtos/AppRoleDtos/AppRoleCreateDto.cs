using DocumentManagementSystem.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Dtos
{
    public class AppRoleCreateDto : IDto
    {
        public string Definition { get; set; }
    }
}
