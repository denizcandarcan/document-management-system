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
    public class DocumentService: Service<DocumentCreateDto,DocumentUpdateDto,DocumentListDto,Document>,IDocumentService
    {
        public DocumentService(IMapper mapper, IValidator<DocumentCreateDto> createDtoValidator,IValidator<DocumentUpdateDto> updateDtoValidator, IUow uow):base(mapper,createDtoValidator,updateDtoValidator,uow)
        {

        }
    }
}
