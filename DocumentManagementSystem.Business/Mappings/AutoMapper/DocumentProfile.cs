using AutoMapper;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Mappings.AutoMapper
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<Document, DocumentListDto>().ReverseMap();
            CreateMap<Document, DocumentCreateDto>().ReverseMap();
            CreateMap<Document, DocumentUpdateDto>().ReverseMap();

        }
    }
}
