using DocumentManagementSystem.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.ValidationRules
{
    public class DocumentUpdateDtoValidator : AbstractValidator<DocumentUpdateDto>
    {
        public DocumentUpdateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title can't be empty.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description can't be empty.");
            RuleFor(x => x.ClassOfDoc).NotEmpty().WithMessage("Class of Document can't be empty.");
            RuleFor(x => x.TypeOfDoc).NotEmpty().WithMessage("Type of Document can't be empty.");
            RuleFor(x => x.SenderName).NotEmpty().WithMessage("Sender name must be added.");
            RuleFor(x => x.ReceiverName).NotEmpty().WithMessage("Receiver name must be added.");
        }
    }
}
