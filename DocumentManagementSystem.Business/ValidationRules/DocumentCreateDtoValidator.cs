using DocumentManagementSystem.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.ValidationRules
{
    public class DocumentCreateDtoValidator:AbstractValidator<DocumentCreateDto>
    {
        public DocumentCreateDtoValidator()
        {
            RuleFor(x=>x.Title).NotEmpty();
            RuleFor(x=>x.Description).NotEmpty();
            RuleFor(x=>x.ClassOfDoc).NotEmpty();
            RuleFor(x=>x.TypeOfDoc).NotEmpty();
        }
    }
}
