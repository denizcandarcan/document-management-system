using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Interfaces
{
    public interface IDeparmentService : IService<DepartmentCreateDto,DepartmentUpdateDto,DepartmentListDto,Department>
    {
    }
}
