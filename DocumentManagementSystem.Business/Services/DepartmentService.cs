using AutoMapper;
using DocumentManagementSystem.Business.Interfaces;
using DocumentManagementSystem.DataAccess.UnitOfWork;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Services
{
    public class DepartmentService : Service<DepartmentCreateDto,DepartmentUpdateDto,DepartmentListDto,Department>,IDeparmentService
    {
        public DepartmentService(IMapper mapper,IValidator<DepartmentCreateDto> createDtoValidator, IValidator<DepartmentUpdateDto> updateDtoValidator,IUow uow ) : 
            base(mapper,createDtoValidator,updateDtoValidator,uow)
        {

        }
    }
}
